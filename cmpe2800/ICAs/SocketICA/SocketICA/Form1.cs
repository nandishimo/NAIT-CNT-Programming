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
		public string Address { get { return UI_tb_Address.Text; } }
		public string Port { get { return UI_tb_Port.Text; } }
		public ConnectDialog()
		{
			InitializeComponent();
		}
	}
}
