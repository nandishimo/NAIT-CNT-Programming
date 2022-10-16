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
    Thread thread = null;
    public Form1()
    {
      InitializeComponent();
      Text = "ICA06";
      _lblSize.MouseClick += _lblSize_MouseClick;
      MouseWheel += Form1_MouseWheel;
      thread = new Thread(ShowBalls);
      thread.IsBackground = true;
      //thread.Start();
      _lblSize.Text = $"{radius}px";
      StartPosition = FormStartPosition.Manual;
      
      Ball.Location = new Point(Location.X + Width, Location.Y);
    }

    private void Form1_MouseWheel(object sender, MouseEventArgs e)
    {
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
        if (thread.IsAlive)
        {
          thread.Abort();
          
        }
        Invoke(new ThreadStart(ShowBalls));

      }
      if(e.Button == MouseButtons.Right)
      {
        lock (balls)
          balls.RemoveRange(0,balls.Count/2);
      }
    }
    void ShowBalls()
    {
        Ball.Loading = true;
        foreach(Ball ball in balls)
        {
          lock (balls)
            ball.ShowBall();
          Thread.Sleep(2);
          Ball.Loading = false;
        }
    }

    private void _rbClick(object sender, EventArgs e)
    {
      if (_rbRadius.Checked)
      {
        foreach(Ball b in balls)
        {
          b._sort = Ball.ESortType.eRadius;
        }
        lock (balls)
          balls.Sort();

      }
      else if (_rbDistance.Checked)
      {
        foreach (Ball b in balls)
        { 
          b._sort = Ball.ESortType.eDistance;
        }
        lock (balls)
          balls.Sort();
      }
      else
      {
        foreach (Ball b in balls)
        {
          b._sort = Ball.ESortType.eColor;

        }
        lock (balls)
          balls.Sort();
      }
      Invoke(new ThreadStart(ShowBalls));

    }
  }
}
