using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using static System.Diagnostics.Trace;


namespace NumGuessClient
{
	public class SuperSocket
	{
		/* Things needed:
		 * 
		 * takes a connected socket
		 * status callback
		 * data callback
		 * rxthread
		 */
		public Socket _socket { get; private set; }
		public delegate void delvoidstring(string s);
		public delvoidstring CallbackStatus { get; set; }
		public delvoidstring CallbackReceive { get; set; }
		private Thread RxThread = null;

		public SuperSocket(Socket socket, delvoidstring StatusMethod, delvoidstring ReceiveMethod)
		{
			_socket = socket;
			CallbackStatus = StatusMethod;
			CallbackReceive = ReceiveMethod;
			try
			{
				if (_socket.Connected)
				{
					RxThread = new Thread(Rx);
					RxThread.IsBackground = true;
					RxThread.Start();
				}
			}
			catch (Exception)
			{
				WriteLine("Given a bad socket");
			}

		}

		void Rx()
		{
			while (_socket != null)
			{
				byte[] buffer = new byte[2048]; //create new buffer to receive response from server
				try
				{
					int numBytesRx = _socket.Receive(buffer); //receive response and count bytes received
					if (numBytesRx == 0) //if 0 bytes received disconnect
					{
						//issue soft disconnect
						SocketDisconnect();
						return;
					}
					try
					{
						CallbackReceive.Invoke(UnWrapData(buffer));//unpack response
					}
					catch (Exception er)
					{
						WriteLine($"Error invoking callback method - {er.Message}");
						return;
					}
				}
				catch (Exception ex)
				{
					WriteLine($"Error receiving guess from server! - {ex.Message}"); //catch error
					try
					{
						CallbackStatus.Invoke($"Error receiving data - {ex.Message}");//unpack response
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
			if (_socket != null && _socket.Connected)
			{
				byte[] data = WrapData(json); //convert guess to GGdata class -> json string and then to byte array

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
