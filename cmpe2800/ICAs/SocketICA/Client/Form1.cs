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
using SocketICA;

namespace Client
{
	public partial class ClientForm : Form
	{
		private Socket _sok = null;
		private ConnectDialog _connectDialog = null;
		public ClientForm()
		{
			InitializeComponent();
		}

		private void UI_btn_Connect_Click(object sender, EventArgs e)
		{
			_connectDialog = new ConnectDialog();
			if(_connectDialog.ShowDialog() == DialogResult.OK)
			{
				_sok = _connectDialog.Socket;
				if (_sok != null)
					WriteLine("got a socket back!");
			}
			/*
			string address = "localhost";
			int port = 1666;
			if(_connectDialog.DialogResult==DialogResult.OK)
			{
				address = _connectDialog.Address;
				port = _connectDialog.Port;
			}
			try
			{
				_sok.BeginConnect(address, port, Callback_ConnectDone, 42);
			}
			catch (Exception ex)
			{

				WriteLine($"UI_btn_Connect_Click {ex.Message}");
			}
			*/
		}


		private void UI_btn_Send_Click(object sender, EventArgs e)
		{
			byte[] data = new byte[5] { 42, 43, 4, 5, 2 };
			_sok.Send(data, 0, 5, SocketFlags.None);
		}
	}
}
