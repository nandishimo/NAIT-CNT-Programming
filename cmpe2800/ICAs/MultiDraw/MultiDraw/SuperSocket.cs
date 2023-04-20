using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Diagnostics.Trace;

namespace MultiDraw
{
	public class SuperSocket
	{
		public Socket _socket { get; private set; }
		public Action<string> CallbackStatus { get; set; }
		public Action<string> CallbackReceive { get; set; }
		private Thread RxThread = null;
		public bool Connected
		{
			get
			{
				if (_socket != null)
				{
					try
					{
						return _socket.Connected;
					}
					catch (Exception ex)
					{
						WriteLine(ex.Message);
					}
				}
				return false;
			}
		}
		public int framesRX = 0;
		public int fragments = 0;
		public double destackAVG { get { try { return framesRX / receiveEvents; } catch { return 1; } } }
		public long bytesRX = 0;
		public int receiveEvents = 0;

		public SuperSocket(Socket socket, Action<string> StatusMethod, Action<string> ReceiveMethod)
		{
			_socket = socket;
			CallbackStatus = StatusMethod;
			CallbackReceive = ReceiveMethod;
			try
			{
				if (Connected)
				{
					RxThread = new Thread(Rx);
					RxThread.IsBackground = true;
					RxThread.Start();
					try
					{
						CallbackStatus.Invoke("Connection established!");
					}
					catch (Exception ex)
					{
						WriteLine($"Error invoking CallbackStatus - {ex.Message}");
					}

				}
			}
			catch (Exception)
			{
				WriteLine("Given a bad socket");
			}
		}

		void Rx()
		{
			string json = "";
			string jsonRX;
			int braces = 0;
			while (_socket != null)
			{
				byte[] buffer = new byte[4096]; //create new buffer to receive response from server
				string frame = "";
				try
				{
					int numBytesRx = _socket.Receive(buffer); //receive response and count bytes received
					bytesRX += numBytesRx;
					if (numBytesRx == 0) //if 0 bytes received disconnect
					{
						//issue soft disconnect
						SocketDisconnect();
						return;
					}
					jsonRX = UnWrapData(buffer);

					json += jsonRX;
					int j = 0;
					for (int i = 0; i < json.Length; i++)
					{
						if (braces == 0)
						{
							i = json.IndexOf('{', 0);
							if (j == -1)
								break;
						}
						if (json[i] == '{')
						{
							braces++;
						}
						else if (json[i] == '}')
						{
							braces--;
							if (braces == 0)
							{
								frame = json.Substring(j, i - j + 1);
								framesRX++;
								json = json.Remove(0, j + 1);
								i = 0;
								try
								{
									CallbackReceive.Invoke(frame);//unpack response
								}
								catch (Exception er)
								{
									WriteLine($"Error invoking callback method - {er.Message}");
									return;
								}
							}
						}
					}

				}
				catch (Exception ex)
				{
					WriteLine($"Error receiving guess from server! - {ex.Message}"); //catch error
					try
					{
						CallbackStatus.Invoke($"Error receiving data RX- {ex.Message}");//unpack response
					}
					catch (Exception er)
					{
						WriteLine($"Error invoking callback method - {er.Message}");
						return;
					}
					SocketDisconnect(); //ensure socket is closed and set to null
				}
			}
		}

		public void SendData(string json)
		{
			if (_socket != null && Connected)
			{
				byte[] data = WrapData(json);

				try
				{
					_socket.Send(data); //send data
				}
				catch (Exception ex)
				{
					WriteLine($"Error sending data - {ex.Message}");
				}
				return;
			}
		}
		public void SocketDisconnect()
		{
			if (_socket != null)
			{
				try
				{
					_socket.Shutdown(SocketShutdown.Both);
					_socket.Close();
					_socket = null;
				}
				catch (Exception ex)
				{
					WriteLine($"Error disconnecting from server - {ex.Message}");
				}
			}
			if (RxThread.IsAlive)
			{
				RxThread.Abort();
			}
			try
			{
				CallbackStatus.Invoke("Disconnected from server...");
			}
			catch (Exception ex)
			{

				WriteLine($"Error invoking CallbackStatus - {ex.Message}");
			}
		}
		private string UnWrapData(byte[] buffer)
		{
			string receivedData = null;
			try
			{
				receivedData = Encoding.UTF8.GetString(buffer);
			}
			catch (Exception ex)
			{
				WriteLine($"Error encountered while encoding data - {ex.Message}");
			}
			return receivedData;
		}
		/// <summary>
		/// Convert a GGdata with intNum into an array of bytes
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		private byte[] WrapData(string json)
		{
			byte[] data = null;
			try
			{
				data = Encoding.UTF8.GetBytes(json);
			}
			catch (Exception ex)
			{
				WriteLine($"Error encountered while encoding data - {ex.Message}");
			}
			return data;
		}
	}
}
