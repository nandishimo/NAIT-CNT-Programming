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
using System.Numerics;
using System.Threading;

namespace nandish_ICA03
{
  public partial class Form1 : Form
  {
    List<Ball> balls = new List<Ball>();
    Thread th1 = null;
    object key = new object();
    public Form1()
    {
      InitializeComponent();
      Text = "ICA03 - Static Balls";
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0,0);
      MouseWheel += Form1_MouseWheel;
      KeyPreview = true;
      KeyDown += Form1_KeyDown;
      th1 = new Thread(Display);
      th1.IsBackground = true;
      th1.Start();
      
    }
    private void Form1_Shown(object sender, EventArgs e)
    {
      Ball.DrawerLocation = new Point(Location.X+Width,Location.Y);
      Activate();
    }


    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Add)
      {
        lock (key)
        {
          for (int i = 0; i < 5; ++i)
          {
            balls.Add(new Ball());
          }
        }
      }
      if(e.KeyCode == Keys.Subtract)
      {
        balls.Clear();
      }
    }


    private void Form1_MouseWheel(object sender, MouseEventArgs e)
    {
      Ball.Radius += e.Delta / 10;
    }

    public void Display()
    {
      while (true)
      {
        Ball.Loading = true;
        lock (key)
        {
          foreach (Ball b in balls)
          {
            b.MoveBall();
            b.ShowBall();
          }
        }
        Ball.Loading = false;
        Thread.Sleep(25);
      }

    }


  }
}
