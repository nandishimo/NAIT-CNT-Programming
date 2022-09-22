/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A02
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

namespace nandish_ica02
{
  public partial class Form1 : Form
  {
    CDrawer window = null;
    List<Ball> balls = new List<Ball>();
    Timer timer = new Timer();
    int xVel=0; //for manual set by user
    int yVel=0; //for manual set by user
    int opacity = 128; //for manual set by user
    public Form1()
    {
      InitializeComponent();
      this.Text = "ICA02 - Bouncing Balls";
      window = new CDrawer();
      window.ContinuousUpdate = false;
      //start timer with interval 20ms
      timer.Interval = 20;
      timer.Enabled = true;

      //subscribe to required events
      Shown += Form1_Shown;
      timer.Tick += Timer_Tick;
      _lblOpacityVal.MouseWheel += _lblOpacityVal_MouseWheel;
      _lblXVal.MouseWheel += _lblXVal_MouseWheel;
      _lblYVal.MouseWheel += _lblYVal_MouseWheel;
    }

    private void Form1_Shown(object sender, EventArgs e)
    {//sets location of main form and drawer window
      this.Location = new Point(0, 0);
      window.Position = new Point(this.Location.X + this.Width, this.Location.Y);
    }

    private void _lblYVal_MouseWheel(object sender, MouseEventArgs e)
    {//sets Y velocity of last ball or all balls upon scrolling on label
      if(balls.Count==0) return;
      if (e.Delta > 0)
        yVel++;
      else
      {
        yVel--;
      }
      if (_cBoxAll.Checked)
      {
        foreach(Ball ball in balls)
        {
          ball.Y = yVel;
        }
      }
      else
      {
        balls.Last().Y = yVel;
      }
      _lblYVal.Text = yVel.ToString();
    }

    private void _lblXVal_MouseWheel(object sender, MouseEventArgs e)
    {//sets X velocity of last ball or all balls upon scrolling on label
      if (balls.Count == 0) return;
      if (e.Delta > 0)
        xVel++;
      else
      {
        xVel--;
      }
      if (_cBoxAll.Checked)
      {
        foreach (Ball ball in balls)
        {
          ball.X = xVel;
        }
      }
      else
      {
        balls.Last().X = xVel;
      }
      _lblXVal.Text = xVel.ToString();
    }

    private void _lblOpacityVal_MouseWheel(object sender, MouseEventArgs e)
    {//sets opacity of last ball or all balls upon scrolling on label 
      if (e.Delta > 0)
        opacity+=10;
      else
      {
        opacity-=10;
      }
      if (balls.Count == 0) return;
      if (_cBoxAll.Checked)
      {
        
        foreach (Ball ball in balls)
        {
          ball.Opacity = opacity;
        }
      }
      else
      {
        balls.Last().Opacity = opacity;
      }
      _lblOpacityVal.Text = opacity.ToString();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {//iterate through balls list and move+show balls in window
      window.Clear();//clear window then move and show balls
      foreach (Ball ball in balls)
      {
        ball.MoveBall(window);
        ball.ShowBall(window);
      }
      if (window.GetLastMouseLeftClick(out Point lClick))
      { //create new ball and add to window upon left mouse click
        balls.Add(new Ball(lClick));
        balls.Last().ShowBall(window);
      }
      if (window.GetLastMouseRightClick(out Point rClick))
      {//clear all balls from window upon right mouse click
        balls.Clear();
      }
      if (balls.Count > 0)
      {//update ui with last ball info
        _lblBallData.Text = balls.Last().ToString();
      }
      else
        _lblBallData.Text = "";
      //update UI with user controlled values (lbl scroll events)
      
      
      
      window.Render();
    }
  }
}
