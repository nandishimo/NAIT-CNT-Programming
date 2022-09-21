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
    int xVel=0;
    int yVel=0;
    int opacity = 128;
    public Form1()
    {
      InitializeComponent();
      this.Text = "ICA02 - Bouncing Balls";
      window = new CDrawer();
      window.ContinuousUpdate = false;
      timer.Enabled = true;
      timer.Interval = 20;
      Shown += Form1_Shown;
      timer.Tick += Timer_Tick;
      _lblOpacityVal.MouseWheel += _lblOpacityVal_MouseWheel;
      _lblXVal.MouseWheel += _lblXVal_MouseWheel;
      _lblYVal.MouseWheel += _lblYVal_MouseWheel;

    }

    private void _lblYVal_MouseWheel(object sender, MouseEventArgs e)
    {
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
    }

    private void _lblXVal_MouseWheel(object sender, MouseEventArgs e)
    {
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
    }

    private void _lblOpacityVal_MouseWheel(object sender, MouseEventArgs e)
    {
      if (balls.Count == 0) return;
      if (e.Delta > 0)
        opacity+=10;
      else
      {
        opacity-=10;
      }
      if(_cBoxAll.Checked)
      {
        foreach(Ball ball in balls)
        {
          ball.Opacity = opacity;
        }
      }
      else
      {
        balls.Last().Opacity = opacity;
      }
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      window.Clear();
      foreach (Ball ball in balls)
      {
        ball.MoveBall(window);
        ball.ShowBall(window);
      }
      if (window.GetLastMouseLeftClick(out Point lClick))
      {
        balls.Add(new Ball(lClick));
        
      }
      if (window.GetLastMouseRightClick(out Point rClick))
      {
        balls.Clear();
      }
      if (balls.Count > 0)
      {
        _lblBallData.Text = balls.Last().ToString();
      }
      else
        _lblBallData.Text = "";
      _lblXVal.Text = xVel.ToString();
      _lblYVal.Text = yVel.ToString();
      _lblOpacityVal.Text = opacity.ToString();
      window.Render();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      this.Location = new Point(0,0);
      window.Position = new Point(this.Location.X + this.Width, this.Location.Y);
    }
    
  }
}
