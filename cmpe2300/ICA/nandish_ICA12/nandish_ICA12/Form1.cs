/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A12
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

namespace nandish_ICA12
{
  public partial class Form1 : Form
  {
    //initialize new timer, list of ball, and drawer
    Timer _timer = new Timer();
    List<Ball> balls = new List<Ball>();
    CDrawer drawer = null;
    public Form1()
    {
      InitializeComponent();
      //enable timer at 20ms 
      _timer.Interval = 20;
      _timer.Enabled = true;
      //initialize cdrawer with continuous update false
      drawer = new CDrawer();
      drawer.ContinuousUpdate = false;
      drawer.BBColour = Color.Snow;
      _timer.Tick += _timer_Tick;
      //set start position of 
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
      drawer.Position = new Point(Location.X + Width, Location.Y);
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
      drawer.Clear();
      //get position of last mouse click
      if (drawer.GetLastMouseLeftClick(out Point lClick))
      {
        //create a ball with random type (Ball, CBall, SBall)
        int i = Ball.rand.Next(0, 3);
        Ball tmp = null;
        switch (i) {
          case 0:
            tmp = new Ball(lClick, Color.Blue);
            break;
          case 1:
            tmp = new CBall(lClick, Color.HotPink);
            break;

          case 2:
            tmp = new SBall(lClick, Color.Green);
            break;
        }
        balls.Add(tmp);
      }

      //foreach iterate through balls and get ball type with RTTI, invoke correct Move
      balls.ForEach(ball => {
        if (ball is CBall cball)
          cball.Move(drawer);
        else if (ball is SBall sball)
          sball.Move(drawer);
        else
          ball.Move(drawer);
      });

      //for through balls and get ball type with RTTI, invoke correct Show
      for (int i = 0; i < balls.Count; i++)
      {
        if(balls[i] is CBall cball)
          cball.Show(drawer);
        else if (balls[i] is SBall sball)
          sball.Show(drawer);
        else
          balls[i].Show(drawer);
      }
      drawer.Render();
    }
  }
}
