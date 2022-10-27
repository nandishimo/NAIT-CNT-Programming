using GDIDrawer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nandish_ICA08
{
  public partial class Form1 : Form
  {
    List<Ball> redBalls = new List<Ball>();
    List<Ball> greenBalls = new List<Ball>();
    List<Ball> blueBalls = new List<Ball>();
    CDrawer upperDrawer = null;
    CDrawer lowerDrawer = null;
    public Form1()
    {
      InitializeComponent();
      //create a timer 
      Timer timer = new Timer();
      timer.Interval = 50;
      timer.Enabled = true;
      timer.Tick += Timer_Tick;
      
      //create drawers of size 600x300 with continuos update = false
      upperDrawer = new CDrawer(600,300);
      lowerDrawer = new CDrawer(600,300);
      upperDrawer.ContinuousUpdate = lowerDrawer.ContinuousUpdate = false;
      Shown += Form1_Shown;
      timer.Start();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      //position main form and drawer windows
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
      upperDrawer.Position = new Point(Width, 0);
      lowerDrawer.Position = new Point(Width, upperDrawer.ScaledHeight);
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      if(upperDrawer.GetLastMouseLeftClick(out Point leftClick))
      {
        Ball redball = new Ball(new PointF((float)leftClick.X, (float)leftClick.Y), RandColor.GetColor());
        if (redBalls.IndexOf(redball) == -1)
        {
          redBalls.Add(redball);
        }
      }
      if (upperDrawer.GetLastMouseRightClick(out Point rightClick))
      {
        Ball greenball = new Ball(new PointF((float)leftClick.X, (float)leftClick.Y), RandColor.GetColor());
        if (!greenBalls.Contains(greenball))
        {
          greenBalls.Insert(0,greenball);
        }
      }
      foreach (Ball ball in redBalls)
      {
        ball.Move(upperDrawer);
      }
      foreach (Ball ball in greenBalls)
      {
        ball.Move(upperDrawer);
      }
      foreach(Ball ball in blueBalls)
      {
        ball.Move(lowerDrawer);
      }
      List<Ball> tmp = new List<Ball>(redBalls.Intersect(greenBalls));
      redBalls.RemoveAll(ball => tmp.Contains(ball));
      greenBalls.RemoveAll(ball => tmp.Contains(ball));
      blueBalls = new List<Ball>(redBalls.Union(blueBalls));
      upperDrawer.Clear();
      upperDrawer.AddText($"Red : {redBalls.Count} Green : {greenBalls.Count}",50,Color.Cyan);
      for(int i=0;i<redBalls.Count&&i<greenBalls.Count&&i<blueBalls.Count;i++)
      {
        if (redBalls[i] != null)
          redBalls[i].Show(upperDrawer, i);
        if (greenBalls[i] != null)
          greenBalls[i].Show(upperDrawer, i);
        if (blueBalls[i] != null)
          blueBalls[i].Show(lowerDrawer, i);
      }
      upperDrawer.Render();
      lowerDrawer.Render();
    }
  }
}
