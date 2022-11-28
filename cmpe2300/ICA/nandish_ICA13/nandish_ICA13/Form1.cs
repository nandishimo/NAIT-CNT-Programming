using GDIDrawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nandish_ICA13
{
  public partial class Form1 : Form
  {
    Random random = new Random();
    Timer timer = new Timer();
    CDrawer drawer = null;
    List<Light> lights = new List<Light>();
    public Form1()
    {
      InitializeComponent();
      drawer = new CDrawer();
      drawer.ContinuousUpdate = false;
      timer.Tick += Timer_Tick;
      timer.Enabled = true;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      if(drawer.GetLastMouseLeftClick(out Point lClick))
      {
        lights.Add(new FadeLight(lClick, random.Next(30, 61)));
      }
      drawer.Clear();
      lights.ForEach(light => { light.Animate(); light.Draw(drawer); });
      lights.RemoveAll(light => light.bKillMe);
      drawer.Render();
    }
  }
}
