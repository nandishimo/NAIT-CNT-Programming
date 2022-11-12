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
    //Form members
    Table poolTable = null;
    Timer _timer = new Timer();
    bool _running = false;
    int numBalls = 10;

    public Form1()
    {
      InitializeComponent();
      Text = "Lab02 - Pool";
      _btn_Table.MouseWheel += _btn_Table_MouseWheel;
      _btn_Table.Click += _btn_Table_Click;
      _lbl_FrictionValue.MouseWheel += _lbl_FrictionValue_MouseWheel;
      _rb_Hits.Click += _rb_Click;
      _rb_Radius.Click+= _rb_Click;
      _rb_TotalHits.Click += _rb_Click;
      _rb_Radius.Checked = true;
      
      _dgv.DataSource = null;
      _timer.Enabled = true;
      _timer.Interval = 35;
      _timer.Tick += _timer_Tick;

      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
    }

    private void _rb_Click(object sender, EventArgs e)
    {
      UpdateGridView();
    }
    private void UpdateGridView()
    {
      if (poolTable == null)
        return;
      List<Ball> balls = poolTable.copyBalls;
      if (_rb_Radius.Checked)
      {
        balls.Sort();
      }
      if (_rb_Hits.Checked)
      {
        balls.Sort(Ball.SortDescHits);
      }
      if (_rb_TotalHits.Checked)
      {
        balls.Sort(Ball.SortDescTotalHits);
      }
      _dgv.DataSource = null;
      _dgv.DataSource = balls;
      _dgv.RowHeadersVisible = false;
      _dgv.Columns["BallColor"].Visible = false;
      _dgv.Columns["Center"].Visible = false;
      _dgv.Columns["Velocity"].Visible = false;
      int ballsHit = 0;
      foreach(Ball b in balls)
      {
        if (b.Hits > 0)
        {
          ballsHit++;
        }
      }
      Text = $"Lab02 - Pool - {ballsHit/balls.Count*100}% of Balls Hit";

    }

    private void _lbl_FrictionValue_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta < 0)
      {
        Ball.Friction -= 0.001f;
        if (Ball.Friction < 0)
        {
          Ball.Friction = 0;
        }
      }
      if (e.Delta > 0)
      {
        Ball.Friction += 0.001f;
        if(Ball.Friction>1)
        {
          Ball.Friction = 1;
        }
      }
      _lbl_FrictionValue.Text = Ball.Friction.ToString("F3");
    }

    private void _btn_Table_Click(object sender, EventArgs e)
    {
      if (poolTable == null)
      {
        poolTable = new Table();
      }
      
      poolTable.MakeTable(800, 600, numBalls);
      poolTable.drawer.Position = new Point(Location.X + Width, Location.Y);
      _timer.Start();
      _running = true;
      
    }

    private void _btn_Table_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta < 0)
      {
        if (numBalls > 1)
        {
          numBalls--;
        }
      }
      if (e.Delta > 0)
      {
          numBalls++;
      }
      _btn_Table.Text = $"New Table [{numBalls}]";
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
      if (poolTable == null)
        return;
      poolTable.ShowTable();
      if(_running)
        if (!poolTable.Running)
        {
          UpdateGridView();
        }
    }
  }
}
