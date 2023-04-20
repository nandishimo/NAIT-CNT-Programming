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
		public Socket Socket { get; private set; } = new Socket(
			AddressFamily.InterNetwork, 
			SocketType.Stream, 
			ProtocolType.Tcp);
		public string Address { get; private set; }
		public int Port { get; private set; }
		public ConnectDialog(string Address = "localhost", int Port = 1666, bool EnableIPAddressTextBox = true, bool EnablePortTextBox = true)
		{
			InitializeComponent();
			UI_tb_Address.Text = this.Address = Address;
			UI_tb_Address.Enabled = EnableIPAddressTextBox;
			this.Port = Port;
			UI_tb_Port.Text = this.Port.ToString();
			UI_tb_Port.Enabled= EnablePortTextBox;
		}

		private void UI_btn_Connect_Click(object sender, EventArgs e)
		{
			try
			{
				Socket.BeginConnect(Address, Port, Callback_ConnectDone, 42);
			}
			catch (Exception ex)
			{
				WriteLine($"Error starting socket connection - {ex.Message}");
			}
		}

		private void UI_btn_Cancel_Click(object sender, EventArgs e)
		{
			DialogResult=DialogResult.Cancel;
		}

		private void Callback_ConnectDone(IAsyncResult ar)
		{
			try
			{
				Socket.EndConnect(ar);
				try
				{
					Invoke(new Action<string>((q) => Text = $"Connected! {q}"), ar.AsyncState);
				}
				catch (Exception ex)
				{

					WriteLine($"Error updating text - {ex.Message}");
				}
			}
			catch (Exception ex)
			{
				WriteLine($"Callback_ConnectDone - {ex.Message}");
				try
				{
					Invoke(new Action<string>((q) => Text = $"Not Connected! {q}"), ex.Message);
				}
				catch (Exception)
				{

					WriteLine($"Error updating text - {ex.Message}");
				}
			}
			finally
			{
				DialogResult = DialogResult.OK;
			}
		}

		private void ConnectDialog_Load(object sender, EventArgs e)
		{

		}

		private void UI_tb_Address_TextChanged(object sender, EventArgs e)
		{
			Address = UI_tb_Address.Text;
		}

		private void UI_tb_Port_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(UI_tb_Port.Text, out int port);
			Port = port;
		}
	}
}
