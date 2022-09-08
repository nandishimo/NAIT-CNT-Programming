using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Trace;

namespace NandishPatel_Demo01
{
  public partial class DemoDialog : Form
  {
    Timer timer = new Timer();
    Random _rnd = null; //member, unallocated as Random

    //delegates/events
    public delegate void dColorHandler(object sender, Color color); //delegate/event type
    public event dColorHandler _GetColor = null; //default to null
    public DemoDialog()
    {
      InitializeComponent();
      WriteLine("Starting...");
      Text = "DemoDialog";
      _rnd = new Random();

      timer.Interval = 2000;
      timer.Enabled = true;
      timer.Tick += TimerCallback;

      Click += DemoDialog_Click;
    }

    private void DemoDialog_Click(object sender, EventArgs e)
    {
      WriteLine("DemoDialog_Click");
    }

    private void TimerCallback(object sender, EventArgs e)
    {
      Text = DateTime.Now.ToShortTimeString();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
