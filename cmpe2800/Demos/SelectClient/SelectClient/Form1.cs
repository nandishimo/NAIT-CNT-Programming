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

namespace SelectClient
{
	public partial class Form1 : Form
	{
		Socket sok = new Socket(
			AddressFamily.InterNetwork, // IP V4 address scheme
			SocketType.Stream, // streaming socket (connection based)
			ProtocolType.Tcp); // use TCP as protocol

		public Form1()
		{
			InitializeComponent();
		}

		private void UI_btn_connect_Click(object sender, EventArgs e)
		{
			try
			{
				sok.BeginConnect("www.microsoft.com", 1666, Callback_ConnectDone, 42);
			}
			catch (Exception ex)
			{

				System.Diagnostics.Trace.WriteLine($"UI_btn_connect_Click - {ex.Message}");
			}
			
		}

		private void Callback_ConnectDone(IAsyncResult ar)
		{
			System.Diagnostics.Trace.WriteLine($"The thing I gave myself, {(int)ar.AsyncState}");
			try
			{
				sok.EndConnect(ar);
				System.Diagnostics.Trace.WriteLine("It worked!");
				// t/c
				Invoke(new Action(() => Text = "Connected!"));
			}
			catch (Exception ex)
			{

				System.Diagnostics.Trace.WriteLine($"Callback_ConnectDone - {ex.Message}");
				Invoke(new Action<string>((a) => Text = $"Not Connected! - {a}"),ex.Message);
			}
			
		}
	}
}
