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
using System.Threading;
using static System.Diagnostics.Trace;

namespace Server
{
	public partial class ServerForm : Form
	{
		private Socket _LSock = null;
		private Socket _CSock = null;
		private Thread _TRxBody = null;
		public ServerForm()
		{
			InitializeComponent();
		}

		private void ServerForm_Load(object sender, EventArgs e)
		{
			_LSock = new Socket(
				AddressFamily.InterNetwork,
				SocketType.Stream,
				ProtocolType.Tcp);
			try
			{
				// bind the socket to the endpoint(any interface, port 1666)
				_LSock.Bind(new IPEndPoint(IPAddress.Any, 1666));
			}
			catch (Exception ex)
			{
				WriteLine($"Can't bind! - {ex.Message}");
			}

			_LSock.Listen(5);

			_LSock.BeginAccept(Callback_Accept, null);
		}

		private void Callback_Accept(IAsyncResult ar)
		{
			try
			{
				_CSock = _LSock.EndAccept(ar);
				Invoke(new Action(() => Text = "Connected!"));

				_TRxBody = new Thread(RXBody);
				_TRxBody.IsBackground = true;
				_TRxBody.Start();
			}
			catch (Exception ex)
			{
				WriteLine($"Can't accept {ex.Message}!");
				Invoke(new Action(() => Text = "Bad Connection Attempt!"));
			}
		}

		private delegate void delVoidInt(int value);
		private void Foo(int i)
		{
			Text = $"I got {i} bytes!";
		}
		private void RXBody()
		{
			byte[] buff = new byte[2048];
			while(true)
			{
				try
				{
					int iNumBytesRxED = _CSock.Receive(buff);

					if(iNumBytesRxED == 0)
					{
						return;
					}
					Invoke(new delVoidInt(Foo), iNumBytesRxED);
				}
				catch (Exception ex)
				{
					WriteLine($"RXBody : {ex.Message}");
					return;
				}
			}
		}
	}
}
