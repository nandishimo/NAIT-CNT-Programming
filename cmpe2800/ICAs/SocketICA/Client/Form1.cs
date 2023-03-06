using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using static System.Diagnostics.Trace;

namespace Client
{
	public partial class ClientForm : Form
	{
		private Socket _sok = new Socket(
			AddressFamily.InterNetwork, //ipv4 scheme
			SocketType.Stream, //streaming socket
			ProtocolType.Tcp); //use tcp protocol
		public ClientForm()
		{
			InitializeComponent();
		}

		private void UI_btn_Connect_Click(object sender, EventArgs e)
		{
			try
			{
				_sok.BeginConnect("localhost", 1666, Callback_ConnectDone, 42);
			}
			catch (Exception ex)
			{

				WriteLine($"UI_btn_Connect_Click {ex.Message}");
			}
		}

		private void Callback_ConnectDone(IAsyncResult ar)
		{
			WriteLine($"The thing I gave me : {(int)ar.AsyncState}");
			try
			{
				_sok.EndConnect(ar);
				WriteLine($"Connected!");
			}
			catch (Exception ex)
			{
				WriteLine($"Callback_ConnectDone {ex.Message}");
				Invoke(new Action<string>((q) => Text = $"Not Connected! {q}"), ex.Message);
			}
		}

		private void UI_btn_Send_Click(object sender, EventArgs e)
		{
			byte[] data = new byte[5] { 42, 43, 4, 5, 2 };
			_sok.Send(data, 0, 5, SocketFlags.None);
		}
	}
}
