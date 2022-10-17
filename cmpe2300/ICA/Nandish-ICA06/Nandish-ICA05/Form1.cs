/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A06
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

namespace Nandish_ICA06
{
  public partial class Form1 : Form
  { 
    List<Ball> balls = new List<Ball>();
    float radius = -50;
    public Form1()
    {
      InitializeComponent();
      Text = "ICA06";
      _lblSize.MouseClick += _lblSize_MouseClick;
      MouseWheel += Form1_MouseWheel;
      _lblSize.Text = $"{radius}px";
      StartPosition = FormStartPosition.Manual;
      Ball.Location = new Point(Location.X + Width, Location.Y);
    }

    private void Form1_MouseWheel(object sender, MouseEventArgs e)
    {//increase or decrease radius based on scroll direction
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
      
      int fail = 0;
      int success = 0;
      if(e.Button == MouseButtons.Left)
      {
        //add up to 50 distinct balls
        do
        {
          Ball ball = new Ball(radius);
          if (balls.Contains(ball))
          { //check if ball overlaps with existing balls and add if it is distinct
            fail++;
          }
          else
          {
            lock (balls)
              balls.Add(ball);
            success++;
          }
          _pBar.Value = fail;
        } while (fail < 1000 && success < 50);
        ShowBalls();
        Text = $"Loaded {success} distinct balls with {fail} discards";//update form text
      }
      if(e.Button == MouseButtons.Right)
      {//remove upper half of collection
        balls.RemoveRange(0,balls.Count/2);
        ShowBalls();
        Text = $"Removed half of the Balls!";//update form text
      }
    }
    void ShowBalls()
    {
        Ball.Loading = true;
        foreach(Ball ball in balls)
        {
          ball.ShowBall();
          Thread.Sleep(2);
          Ball.Loading = false;
        }
    }

    private void _rbClick(object sender, EventArgs e)
    {//check with radio button was clicked and sort accordingly
      //ReferenceEquals
      if (ReferenceEquals(sender,_rbRadius))
      {
        balls.Sort();
      }
      else if (ReferenceEquals(sender,_rbDistance))
      {
        balls.Sort(Ball.CompareByDistance);
      }
      else
      {
        balls.Sort(Ball.CompareByColor);
      }
      ShowBalls();

    }
  }
}
