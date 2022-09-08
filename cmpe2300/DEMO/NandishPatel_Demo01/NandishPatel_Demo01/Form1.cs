using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NandishPatel_Demo01
{
  public partial class Form1 : Form
  {
    DemoDialog _demoDialog = null;
    public Form1()
    {
      InitializeComponent();
      Text = "Demo01";
      _pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      Shown += Form1_Shown;
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      //Allocate a DemoDialog
      _demoDialog = new DemoDialog();
      _demoDialog._GetColor += _demoDialog__GetColor;
      _demoDialog.StartPosition = FormStartPosition.Manual;
      _demoDialog.Location = new Point(this.Left + this.Width, this.Top);
      _demoDialog.Show();
    }

    private void _demoDialog__GetColor(object sender, Color color)
    {
      BackColor = color;
    }
  }
}
