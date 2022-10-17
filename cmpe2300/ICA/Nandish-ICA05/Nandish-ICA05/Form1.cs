﻿/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A05
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
using System.Threading;

namespace Nandish_ICA05
{
  public partial class Form1 : Form
  { 
    List<Ball> balls = new List<Ball>();
    float radius = -50;
    public Form1()
    {
      InitializeComponent();
      Text = "ICA05";
      _lblSize.MouseClick += _lblSize_MouseClick;
      MouseWheel += Form1_MouseWheel;
      _lblSize.Text = $"{radius}px";
      StartPosition = FormStartPosition.Manual;
      Ball.Location = new Point(Location.X + Width, Location.Y);
    }

    private void Form1_MouseWheel(object sender, MouseEventArgs e)
    { //increase or decrease ball radius, controlled by scroll direction
      if(e.Delta > 0)
      {
        radius++;
      }
      else
      {
        radius--;
      }
      _lblSize.Text = $"{radius}px";
    }

    private void _lblSize_MouseClick(object sender, MouseEventArgs e)
    {
      //add 50 distinct balls or stop if reaching 1000 fails
      int fail = 0;
      int success = 0;
      if(e.Button == MouseButtons.Left)
      {
        do
        {
          Ball ball = new Ball(radius);
          if (balls.Contains(ball))
          { //check if ball overlaps with existing balls and add if it is distinct
            fail++;
          }
          else
          {
            balls.Add(ball);
            success++;
          }
          _pBar.Value = fail;
        } while (fail < 1000 && success < 50);
        ShowBalls();

      }
      if(e.Button == MouseButtons.Right)
      {//remove half the balls
        balls.RemoveRange(0,balls.Count/2);
        ShowBalls();
      }
    }
    void ShowBalls()
    {//clear drawer, add balls from list, render drawer after adding each ball with delay
        Ball.Loading = true;
        foreach(Ball ball in balls)
        {
          ball.ShowBall();
          Thread.Sleep(2);
          Ball.Loading = false;
        }
    }

    private void _rbClick(object sender, EventArgs e)
    {//change sort type for all balls, sort collection and render balls
      if (_rbRadius.Checked)
      {
        foreach(Ball b in balls)
        {
          b._sort = Ball.ESortType.eRadius;
        }

      }
      else if (_rbDistance.Checked)
      {
        foreach (Ball b in balls)
        { 
          b._sort = Ball.ESortType.eDistance;
        }
      }
      else
      {
        foreach (Ball b in balls)
        {
          b._sort = Ball.ESortType.eColor;
        }
        
      }
      balls.Sort();
      ShowBalls();

    }
  }
}
