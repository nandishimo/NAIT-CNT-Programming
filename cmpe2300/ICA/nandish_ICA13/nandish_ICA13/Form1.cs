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
    Random rand = new Random();
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
      StartPosition = FormStartPosition.Manual;
      drawer.Position = new Point(Location.X + Width, Location.Y);
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      Point location = new Point(0, 0);
      int count = 0;
      if (drawer.GetLastMouseLeftClick(out Point lClick))
      {
        location = lClick;
        count = 1;
      }
      if (drawer.GetLastMouseRightClick(out Point rClick))
      {
        location = rClick;
        count = 20;
      }
      for (int i = 0; i < count; i++)
      {
        if (i == 0)
        {
          Light newLight = GetRandomLight(location);
          if (newLight is ShrinkLight)
            drawer.BBColour = Color.LightCoral;
          else if (newLight is SpinLight)
            drawer.BBColour = Color.LightSeaGreen;
          else
            drawer.BBColour = Color.LightSlateGray;
          lights.Add(newLight);
        }
        else
          lights.Add(GetRandomLight(new Point(rand.Next(0, drawer.ScaledWidth), rand.Next(0, drawer.ScaledHeight))));
      }
      drawer.Clear();
      lights.ForEach(light => { light.Animate(); light.Draw(drawer); });
      lights.RemoveAll(light => light.bKillMe);
      drawer.Render();
    }
    //helper to get a random light
    private Light GetRandomLight(Point Center)
    {
      int randClass = rand.Next(0, 3);
      Light light = null;
      switch (randClass)
      {
        case 0:
          light = new FadeLight(Center, rand.Next(30, 61));
          break;
        case 1:
          light = new SpinLight(Center);
          break;
        case 2:
          light = new ShrinkLight(Center, rand.Next(50, 81));
          break;
      }
      return light;
    }
  }
}
