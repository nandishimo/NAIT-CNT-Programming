/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_L03
***********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace nandish_LAB03
{
  public partial class Form1 : Form
  {
    List<Shape> _shapes = new List<Shape>(); //list of class objects derived from Shape class
    CDrawer drawer = new CDrawer(1200,1200,false); //CDdrawer with continuous render disabled

    public Form1()
    {
      InitializeComponent();
      Text = "Lab 03 - Carnival";
      //move main form and drawer window
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
      drawer.Position = new Point(Location.X+Width, Location.Y);  

      //create timer and run at 50ms interval
      Timer timer = new Timer();
      timer.Interval = 50;
      timer.Tick += Timer_Tick;
      timer.Enabled = true;

      //invoke test code
      Test();

    }

    /// <summary>
    /// Runs every timer tick. Clear drawer, animate IAnimate objects in _shapes.
    /// Render all Shapes to drawer
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Timer_Tick(object sender, EventArgs e)
    {
      drawer.Clear();
      foreach (IAnimate ani in _shapes.Where(shape => shape is IAnimate))
      { //check Shape in _shapes and invoke Tick to animate if Shape supports IAnimate interface
        ani.Tick();
      }
      foreach (Shape shape in _shapes)
      {
        //if (shape is AniGon aShape)
        //  aShape.Tick();

        //if (shape is IAnimate aniShape)
        //  aniShape.Tick();

        //(shape as IAnimate)?.Tick();

        shape.Render(drawer);
      }
      drawer.Render();
    }

    private void Test()
    {
      // This code assumes you have a List<Shape> called _shapes
      // If you do not, make one and after this code completes, add it to your
      // actual collection used by your timer

      // CTOR Declarations used for this test code
      //public Polygon(PointF p, Color c, int r, int Sides) : base(p, c, r)
      //public Shadow(PointF p, Color c, int r, int Sides, double delta = 0.5):
      //public Spinner(PointF p, Color c, int r, int sides, double dAniIncrement = 0, double dAniValue = 0) :
      //public Orbiter(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0)
      //public Fader(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0)
      //public Grower(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0)

      int DebugLevel = 9;
      // Polygon
      if (DebugLevel > 0)
      { // Bottoms Up
        _shapes.Add(new Polygon(new Point(50, 50), Color.Orange, 10, 3));
        _shapes.Add(new Polygon(new Point(50, 100), Color.Green, 15, 4));
        _shapes.Add(new Polygon(new Point(100, 100), Color.LightCoral, 20, 5));
        _shapes.Add(new Polygon(new Point(100, 50), Color.Violet, 25, 6));
      }

      // Shadow
      if (DebugLevel > 1)
      {
        _shapes.Add(new Shadow(new Point(250, 50), Color.Orange, 10, 3, 0.2));
        _shapes.Add(new Shadow(new Point(250, 100), Color.Green, 15, 4, 0.4));
        _shapes.Add(new Shadow(new Point(300, 100), Color.LightCoral, 20, 5));
        _shapes.Add(new Shadow(new Point(300, 50), Color.Violet, 25, 6, 0.8));
      }

      // Spinner
      if (DebugLevel > 2)
      {
        List<Shape> local = new List<Shape>();
        local.Add(new Spinner(new Point(450, 50), Color.Orange, 20, 3, 0.1));
        local.Add(new Spinner(new Point(450, 150), Color.Green, 30, 4, 0.15));
        local.Add(new Spinner(new Point(550, 50), Color.LightCoral, 40, 5, 0.2));
        local.Add(new Spinner(new Point(550, 150), Color.Violet, 50, 6, 0.3));
        _shapes.AddRange(local);
      }

      // Orbiter using a Spinner parent
      if (DebugLevel > 3)
      {
        PointF hOnly = new PointF(1, 0); // 100% X, no Y, Horizontal only
        PointF vOnly = new PointF(0, 1); // no X, 100% Y, Vertical only
        PointF circular = new PointF(1, 1); // no X, 100% Y, Vertical only
        { // One Horizontal only
          List<Shape> local = new List<Shape>();
          local.Add(new Spinner(new Point(500, 250), Color.HotPink, 20, 3, 0.1)); // 100 distance
          local.Add(new Orbiter(Color.OrangeRed, 10, 8, local.Last(), 100, hOnly, 0.1, 0.0));
          _shapes.AddRange(local);
        }
        { // Many Horizontal only, chained together, parent is previous Orbiter
          List<Shape> local = new List<Shape>();
          local.Add(new Spinner(new Point(500, 300), Color.HotPink, 25, 3, 0.1));
          for (int i = 1; i < 10; ++i)
            local.Add(new Orbiter(Color.OrangeRed, 10, 8, local.Last(), 35, hOnly, 0.1, 0.0));
          _shapes.AddRange(local);
        }
        { // One Vertical only, Shadow as parent
          List<Shape> local = new List<Shape>();
          local.Add(new Shadow(new Point(60, 500), Color.Green, 25, 6, 0.3));
          local.Add(new Orbiter(Color.Purple, 10, 8, local.Last(), 30, vOnly, 0.1, 0.0));
          _shapes.AddRange(local);
        }
        { // Many Vertical only, chained together, parent is previous Orbiter
          List<Shape> local = new List<Shape>();
          local.Add(new Shadow(new Point(30, 500), Color.Green, 25, 6, 0.3));
          for (int i = 1; i < 15; ++i)
            local.Add(new Orbiter(Color.Magenta, 10, 8, local.Last(), 30, vOnly, 0.1, 0.0));
          _shapes.AddRange(local);
        }
        { // Orbit Circle - one circle, 2 ellipses
          List<Shape> local = new List<Shape>();
          local.Add(new Shadow(new Point(700, 100), Color.Yellow, 25, 6, 0.3));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 100, new PointF(1, 1), 0.1, 0.0));//circle
          local.Add(new Orbiter(Color.Green, 10, 8, local.First(), 150, new PointF(1.5f, 0.5f), -0.1, 2 * Math.PI / 3));//wide
          local.Add(new Orbiter(Color.Blue, 10, 8, local.First(), 100, new PointF(0.5f, 1), 0.1, 4 * Math.PI / 3));//tall
          _shapes.AddRange(local);
        }
        { // What's this ?
          List<Shape> local = new List<Shape>();
          local.Add(new Shadow(new Point(200, 600), Color.GreenYellow, 15, 6, 0.3));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 35, circular, 0.1, 0.0));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 35, circular, 0.1, Math.PI / 2));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 35, circular, 0.1, Math.PI));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 35, circular, 0.1, 3 * Math.PI / 2));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 70, circular, -0.05, 0.0));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 70, circular, -0.05, Math.PI / 2));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 70, circular, -0.05, 3 * Math.PI));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 70, circular, -0.05, 3 * Math.PI / 2));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 100, circular, 0.025, 0.0));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 100, circular, 0.025, Math.PI / 2));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 100, circular, 0.025, Math.PI));
          local.Add(new Orbiter(Color.Red, 10, 8, local.First(), 100, circular, 0.025, 3 * Math.PI / 2));
          _shapes.AddRange(local);
        }
      }

      //another Orbiter test, chained to sequence of Spinners, offset increasing oscillations
      if (DebugLevel > 5)
      {
        double aniVal = 0; // increments for each Orbiter
        List<Shape> local = new List<Shape>();
        for (int i = 50; i < 1000; i += 50)
        {
          local.Add(new Spinner(new Point(i, 800), Color.Fuchsia, 25, 3, 0.1, aniVal));
          local.Add(new Orbiter(Color.LimeGreen, 10, 8, local.Last(), 15 * aniVal, new PointF(0, 1), 0.1, aniVal += 0.7));
        }
        _shapes.AddRange(local);
      }

      // Orbiters - the CCW "Whip"
      if (DebugLevel > 6)
      {
        List<Shape> local = new List<Shape>();
        local.Add(new Spinner(new Point(250, 350), Color.BlueViolet, 15, 8, 0.1));
        local.Add(new Orbiter(Color.Yellow, 10, 8, local.Last(), 100, new PointF(1, 1), -0.1, Math.PI));
        local.Add(new Orbiter(Color.Turquoise, 10, 8, local.Last(), 75, new PointF(1, 1), -0.15, Math.PI));
        local.Add(new Orbiter(Color.Blue, 10, 8, local.Last(), 50, new PointF(1, 1), -0.2, Math.PI));
        local.Add(new Orbiter(Color.Green, 10, 8, local.Last(), 25, new PointF(1, 1), -0.25, Math.PI));
        _shapes.AddRange(local);
      }
      // Orbiters, Vertical, Horizontal, Circular all chained to gether in the "Machine"
      if (DebugLevel > 7)
      {
        List<Shape> local = new List<Shape>();
        local.Add(new Spinner(new Point(800, 500), Color.Cyan, 20, 6, 0.01));
        local.Add(new Orbiter(Color.Red, 10, 8, local.Last(), 100, new PointF(1, 0), 0.1));
        local.Add(new Orbiter(Color.OrangeRed, 10, 8, local.Last(), 100, new PointF(0, 1), 0.15));
        local.Add(new Orbiter(Color.LightBlue, 10, 8, local.Last(), 30, new PointF(1.2f, 0.8f), 0.15));
        _shapes.AddRange(local);
      }

      // Growers and Faders, varying orbits
      if (DebugLevel > 8)
      {
        List<Shape> local = new List<Shape>();
        local.Add(new Spinner(new Point(500, 500), Color.Cyan, 20, 6, 0.01));
        local.Add(new Fader(Color.HotPink, 15, 3, local.First(), 50, new PointF(0.5f, 1), 0.1));
        local.Add(new Fader(Color.HotPink, 15, 4, local.First(), 50, new PointF(0.5f, 1), 0.1, Math.PI / 2));
        local.Add(new Fader(Color.HotPink, 15, 5, local.First(), 50, new PointF(0.5f, 1), 0.1, Math.PI));
        local.Add(new Fader(Color.HotPink, 15, 6, local.First(), 50, new PointF(0.5f, 1), 0.1, 3 * Math.PI / 2));
        local.Add(new Grower(Color.YellowGreen, 25, 3, local.First(), 200, new PointF(1, 0.5f), -0.05));
        local.Add(new Grower(Color.YellowGreen, 25, 6, local.First(), 200, new PointF(1, 0.5f), -0.05, Math.PI / 2));
        local.Add(new Grower(Color.YellowGreen, 25, 6, local.First(), 200, new PointF(1, 0.5f), -0.05, Math.PI));
        local.Add(new Grower(Color.YellowGreen, 25, 9, local.First(), 200, new PointF(1, 0.5f), -0.05, 3 * Math.PI / 2));
        _shapes.AddRange(local);
      }
    }

  }
}
