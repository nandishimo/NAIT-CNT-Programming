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
    List<Ball> yellowBalls = new List<Ball>();
    CDrawer upperDrawer = null;
    CDrawer lowerDrawer = null;
    public Form1()
    {
      InitializeComponent();
      //create a timer 
      Timer timer = new Timer();
      timer.Interval = 20;
      timer.Enabled = true;
      timer.Tick += Timer_Tick;

      //create drawers of size 600x300 with continuos update = false
      upperDrawer = new CDrawer(600, 300);
      lowerDrawer = new CDrawer(600, 300);
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
      lowerDrawer.Position = new Point(Width, upperDrawer.DrawerWindowSize.Height);
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      if (upperDrawer.GetLastMouseLeftClick(out Point leftClick))
      {
        Ball redball = new Ball(new PointF((float)leftClick.X, (float)leftClick.Y), Color.Red);
        if (redBalls.IndexOf(redball) == -1)
        {
          redBalls.Add(redball);
        }
      }
      if (upperDrawer.GetLastMouseRightClick(out Point rightClick))
      {
        Ball greenball = new Ball(new PointF((float)rightClick.X, (float)rightClick.Y), Color.Green);
        if (!greenBalls.Contains(greenball))
        {
          greenBalls.Insert(0, greenball);
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
      yellowBalls.ForEach(ball => { ball.Move(lowerDrawer); });//foreach lambda

      //tmp list of collided balls
      List<Ball> tmp = redBalls.Intersect(greenBalls).ToList();

      foreach(Ball ball in tmp)
      {
        while (redBalls.Remove(ball)) ;
        while (greenBalls.Remove(ball)) ;
        ball._color = Color.Yellow;
      }
      //combine tmp list with yellow balls without duplicates
      yellowBalls = new List<Ball>(yellowBalls.Union(tmp));

      upperDrawer.Clear();
      lowerDrawer.Clear();
      upperDrawer.AddText($"Red : {redBalls.Count} Green : {greenBalls.Count}", 50, Color.Cyan);
      lowerDrawer.AddText($"{yellowBalls.Count}", 50, Color.Cyan);

      for (int i = 0; i < redBalls.Count; i++)
      {
        redBalls[i].Show(upperDrawer, i);
      }
      for (int i = 0; i < greenBalls.Count; i++)
      {
        greenBalls[i].Show(upperDrawer, i);
      }
      for (int i = 0; i < yellowBalls.Count; i++)
      {
        yellowBalls[i].Show(lowerDrawer, i);
      }

      //render drawers
      upperDrawer.Render();
      lowerDrawer.Render();
    }
  }
}
