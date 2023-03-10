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
using System.Net;
using System.Threading;
using static System.Diagnostics.Trace;

namespace SocketICA
{
	public partial class ConnectDialog : Form
	{
		public Socket Socket { get; set; } = new Socket(
			AddressFamily.InterNetwork, 
			SocketType.Stream, 
			ProtocolType.Tcp);
		private string _address = "localhost";
		public string Address { get { return UI_tb_Address.Text; } }
		private int _port = 1666;
		public int Port { get { return int.Parse(UI_tb_Port.Text); } }
		public ConnectDialog(string Address = "localhost", int Port = 1666)
		{
			InitializeComponent();
			UI_tb_Address.Text = _address = Address;
			_port = Port;
			UI_tb_Port.Text = _port.ToString();
		}

		private void UI_btn_Connect_Click(object sender, EventArgs e)
		{
			try
			{
				Socket.BeginConnect(Address, Port, Callback_ConnectDone, 42);
			}
			catch (Exception)
			{

				throw;
			}
			DialogResult = DialogResult.OK;
		}

		private void UI_btn_Cancel_Click(object sender, EventArgs e)
		{
			DialogResult=DialogResult.Cancel;
		}

		private void Callback_ConnectDone(IAsyncResult ar)
		{
			WriteLine($"The thing I gave me : {(int)ar.AsyncState}");
			try
			{
				Socket.EndConnect(ar);
				Invoke(new Action<string>((q) => Text = $"Connected! {q}"), ar.AsyncState);
				WriteLine($"Connected!");
			}
			catch (Exception ex)
			{
				WriteLine($"Callback_ConnectDone {ex.Message}");
				Invoke(new Action<string>((q) => Text = $"Not Connected! {q}"), ex.Message);
			}
		}

		private void ConnectDialog_Load(object sender, EventArgs e)
		{

		}
	}
}
