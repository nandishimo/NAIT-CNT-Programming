using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketICA
{
	public partial class ConnectDialog : Form
	{
		private string _address = "localhost";
		public string Address { get { return UI_tb_Address.Text; } }
		private int _port = 1666;
		public int Port { get { return int.Parse(UI_tb_Port.Text); } }
		public ConnectDialog()
		{
			InitializeComponent();
			UI_tb_Address.Text = _address;
			UI_tb_Port.Text = _port.ToString();
		}
	}
}
