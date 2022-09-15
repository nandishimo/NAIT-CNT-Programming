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
    CDrawer window = null;
    Timer timer = new Timer();
    Random rand = new Random();
    public Form1()
    {
      InitializeComponent();
      window = new CDrawer(900, 500);
      window.BBColour = Color.Black;
      window.Scale = 50;
      window.ContinuousUpdate = false;
      timer.Enabled = true;
      timer.Interval = 100;
      timer.Tick += Timer_Tick;      
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
      Shown += Form1_Shown;
      KeyPreview = true;
      KeyDown += Form1_KeyDown;
      
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      window.Position = new Point(this.Location.X + this.Width, this.Location.Y);
      Activate();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.NumPad1:
          if (trekLamps.Count()<window.ScaledWidth*window.ScaledHeight)
          trekLamps.Add(new TrekLamp());
          break;
        case Keys.NumPad2:
          if (trekLamps.Count() < window.ScaledWidth * window.ScaledHeight)
            trekLamps.Add(new TrekLamp(180,Color.Orange));
          break;
        case Keys.NumPad3:
          if (trekLamps.Count() < window.ScaledWidth * window.ScaledHeight)
            trekLamps.Add(new TrekLamp((byte)rand.Next(60, 221), RandColor.GetColor(), 4));
          break;
        case Keys.Subtract:
          for (int i = 0; i < trekLamps.Count(); ++i)
          {
            trekLamps[i].RedAlert(false);
          }
          break;

        case Keys.Enter:
          for(int i = 0; i < trekLamps.Count(); ++i)
          {
            trekLamps[i].RedAlert(true);
          }
          break;

        case Keys.Escape:
          if (trekLamps.Count() > 0)
            trekLamps.RemoveAt(trekLamps.Count() - 1);
          break;

      }
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      window.Clear();
      for (int i=0; i<trekLamps.Count;++i)
      {
        trekLamps[i].TickLamp();
        trekLamps[i].RenderLamp(ref window,i);
      }
      window.Render();
    }
  }
}
