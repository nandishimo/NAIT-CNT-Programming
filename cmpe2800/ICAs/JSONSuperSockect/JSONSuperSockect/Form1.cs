using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using static System.Diagnostics.Trace;
using SocketICA;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace NumGuessClient
{
	public partial class Form1 : Form
	{
		private Socket _sock = null; //connecting socket													 
		private Thread receiveData = null;
		private delegate void delvoidint(int x);
		delvoidint UpdateUI = null;


		JsonSerializer serializer = new JsonSerializer(); //newtonsoft json serializer

		private int response = -1;
		public Form1()
		{
			InitializeComponent();
			UpdateUI = ResponseHandler;
		}

		private void UI_Tbar_Guess_Scroll(object sender, EventArgs e)
		{
			Invoke(new Action(() =>
			{
			}));
		}

		private void UI_Btn_Connect_Click(object sender, EventArgs e)
		{
			//Client.Client _connectDialog = new Client.Client(false, false, "localhost");
			SocketICA.ConnectDialog _connectDialog = new ConnectDialog();
			if (_connectDialog.ShowDialog() == DialogResult.OK) //open dialog and attempt to get connected socket back
			{
				try
				{
					//_sock = _connectDialog.socketConnect; //grab socket from dialog
					_sock = _connectDialog.Socket;

					//dont reprogram timeouts
				}
				catch (Exception ex)
				{
					WriteLine(ex.Message);
				}
			}
			else
				return;
			if (_sock.Connected) //if connected, disable the button and display status message
			{
				receiveData = new Thread(ReceiveHandler);
				receiveData.IsBackground = true;
				receiveData.Start();
				UpdateStatus("Connected to Server!");
			}
			else
			{
				UpdateStatus("Connection could not be made to server!");
			}
		}

		private void UI_Btn_Guess_Click(object sender, EventArgs e)
		{
			if (_sock != null && _sock.Connected)
			{
				byte[] data = WrapData(""); //convert guess to GGdata class -> json string and then to byte array

				try
				{
					_sock.Send(data); //send data
				}
				catch (Exception ex)
				{
					WriteLine($"Error sending data - {ex.Message}");
				}
				return;
			}
		}
		/// <summary>
		/// Set minimum and maximum trackbar values and update corresponding text boxes
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		private void SetTrackbarLimits(int min = 1, int max = 1000)
		{
			try
			{
				Invoke(new Action(() => { }));
				Invoke(new Action(() => { }));
				Invoke(new Action(() => { }));
				Invoke(new Action(() => { }));
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}


		}
		/// <summary>
		/// Update the text in the status textbox
		/// </summary>
		/// <param name="message"></param>
		private void UpdateStatus(string message)
		{
			try
			{
				Invoke(new Action( () => message.ToLower()));
			}
			catch (Exception ex)
			{
				WriteLine($"Error updating status text - {ex.Message}");
			}

		}
		/// <summary>
		/// Convert array of bytes into GGData class and extract int Num
		/// </summary>
		/// <param name="buffer"></param>
		/// <returns></returns>
		private int UnWrapData(byte[] buffer)
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
			GGData response = JsonConvert.DeserializeObject<GGData>(receivedData);
			return response.Num;
		}
		/// <summary>
		/// Convert a GGdata with intNum into an array of bytes
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		private byte[] WrapData(string data)
		{
			GGData guess = new GGData();
			guess.Num = int.Parse(data);
			string json = JsonConvert.SerializeObject(guess);
			return Encoding.UTF8.GetBytes(json);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SocketDisconnect(); //issue soft disconnect
		}
		/// <summary>
		/// Issue a soft disconnect from server and reset game trackbar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UI_Btn_Disconnect_Click(object sender, EventArgs e)
		{
			SocketDisconnect(); //issure soft disconnect
			SetTrackbarLimits(); //reset trackbar
		}

		/// <summary>
		/// Issue socket shudown, close the socket and set socket to null
		/// </summary>
		private void SocketDisconnect()
		{
			if (_sock != null)
			{
				try
				{
					_sock.Shutdown(SocketShutdown.Both);
					_sock.Close();
					_sock = null;
				}
				catch (Exception ex)
				{
					WriteLine($"Error disconnecting from server - {ex.Message}");
				}
			}

		}

		private void UI_Btn_SendEmpty_Click(object sender, EventArgs e)
		{
			byte[] data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject("")); //convert guess to GGdata class -> json string and then to byte array
			if (_sock == null || !_sock.Connected)
			{
				return;
			}
			try
			{
				_sock.Send(data); //send data
			}
			catch (Exception ex)
			{
				WriteLine($"Error sending data - {ex.Message}");
			}
		}

		private void UI_Btn_WrongJSON_Click(object sender, EventArgs e)
		{
			FakeData guess = new FakeData();
			string json = JsonConvert.SerializeObject(guess);
			byte[] data = Encoding.UTF8.GetBytes(json);
			if (_sock == null || !_sock.Connected)
			{
				return;
			}
			try
			{
				_sock.Send(data); //send data
			}
			catch (Exception ex)
			{

				WriteLine($"Error sending data - {ex.Message}");
			}

			ReceiveHandler();
		}
		public void ReceiveHandler()
		{
			while (_sock != null && _sock.Connected)
			{
				byte[] buffer = new byte[2048]; //create new buffer to receive response from server
				try
				{
					int numBytesRx = _sock.Receive(buffer); //receive response and count bytes received
					if (numBytesRx == 0) //if 0 bytes received disconnect
					{
						//issue soft disconnect
						SocketDisconnect();
						return;
					}
					response = UnWrapData(buffer);//unpack response

				}
				catch (Exception ex)
				{
					WriteLine($"Error receiving guess from server! - {ex.Message}"); //catch error
					UpdateStatus("Disconnected from server!");
					SocketDisconnect(); //ensure socket is closed and set to null
					SetTrackbarLimits(); //reset trackbar
					try
					{
						Invoke(new Action(() =>
						{
						}));
						return;
					}
					catch (Exception err)
					{
						WriteLine(err.Message);
					}

				}
				try
				{
					UpdateUI.Invoke(response);
				}
				catch (Exception ex)
				{
					WriteLine($"Error updating UI - {ex.Message}");
				}

			}
			UpdateStatus("Disconnected from server!");
		}
		private void ResponseHandler(int response)
		{
			if (response == 0) //update status text and trackbar based on response
			{
				SetTrackbarLimits(); //set trackbar back to default
				UpdateStatus("Correct Guess!"); //update status message
			}
			else if (response > 0)
			{
				try
				{
					Invoke(new Action(() =>
					{
						//UI_Tbar_Guess.Value -= 1;
						//UI_Tbox_Current.Text = UI_Tbar_Guess.Value.ToString(); //populate current trackbar value to textbox
						//SetTrackbarLimits(UI_Tbar_Guess.Minimum, UI_Tbar_Guess.Value); //change minimum value to current guess
					}));

					UpdateStatus("Guess is too high!"); //update status text box

				}
				catch (Exception ex)
				{
					WriteLine($"Error updating UI - {ex.Message}");
				}
			}
			else
			{
				try
				{
					Invoke(new Action(() => { 
						//UI_Tbar_Guess.Value += 1;
						//SetTrackbarLimits(UI_Tbar_Guess.Value, UI_Tbar_Guess.Maximum); 
					}));//change max value to current guess
					UpdateStatus("Guess is too low!"); //update status text
				}
				catch (Exception ex)
				{
					WriteLine($"{ex.Message}");
				}
			}
		}
	}
	/// <summary>
	/// GGData class to send and receive guesses/responses
	/// </summary>
	public class GGData
	{
		public int Num { get; set; }
	}
	/// <summary>
	/// Fake data class for bug testing
	/// </summary>
	public class FakeData
	{
		public string Num { get; set; }
	}
}
