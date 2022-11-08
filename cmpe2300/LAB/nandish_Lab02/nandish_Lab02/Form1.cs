using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using GDIDrawer;

namespace nandish_Lab02
{
  public partial class Form1 : Form
  { 
    List<Ball> balls = new List<Ball>();
    CDrawer pool = null;
    public Form1()
    {
      InitializeComponent();
      Text = "Lab02 - Pool";
      pool = new CDrawer();
      _dgv.DataSource = null;
      Timer _timer = new Timer();
      _timer.Start();
      _timer.Interval = 10;
      _timer.Tick += _timer_Tick;
      balls.Add(new Ball(pool));
      balls.Add(new Ball(pool,Color.Red));
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
      pool.Clear();
      foreach (Ball ball in balls)
      {
        ball.Move(pool, balls);
        ball.Show(pool);
        if (ball.Velocity.X == 0)
        {
          ball.Set_velocity(new Vector2(10, 10));
        }
        
      }
    }
  }
}
