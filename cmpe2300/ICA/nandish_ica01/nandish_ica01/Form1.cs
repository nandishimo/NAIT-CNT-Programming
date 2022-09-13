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
using GDIDrawer;

/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A01
***********************************/

namespace nandish_ica01
{
  public partial class Form1 : Form
  {
    List<TrekLamp> trekLamps = new List<TrekLamp>();
    CDrawer window = new CDrawer(900, 500);
    Timer timer = new Timer();
    public Form1()
    {
      InitializeComponent();
      window.BBColour = Color.Black;
      window.Scale = 50;
      timer.Enabled = true;
      timer.Interval = 100;
      timer.Tick += Timer_Tick;

      KeyPreview = true;
      KeyDown += Form1_KeyDown;
      
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.Key)
      {
        case Keys.NumPad1:

          break;
        case Keys.NumPad2:

          break;
        case Keys.NumPad3:

          break;
        case Keys.Enter:

          break;
        case Keys.Subtract:

          break;

      }
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      for (int i=0; i<trekLamps.Count;++i)
      {
        trekLamps[i] = new TrekLamp();
      }
    }
  }
}
