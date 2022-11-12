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

    //consts
    const int tableWidth = 800;
    const int tableHeight = 800;
    const float fDelta = 0.001f;


    public Form1()
    {
      InitializeComponent();
      Text = "Lab02 - Pool";
      _btn_Table.MouseWheel += _btn_Table_MouseWheel; //bind mousewheel scroll event to button
      _btn_Table.Click += _btn_Table_Click; //bind click event to button
      _lbl_FrictionValue.MouseWheel += _lbl_FrictionValue_MouseWheel; //bind mousewheel scroll to label
      //bind all radio buttons to same click event
      _rb_Hits.Click += _rb_Click; 
      _rb_Radius.Click+= _rb_Click;
      _rb_TotalHits.Click += _rb_Click;
      _rb_Radius.Checked = true; //set Radius radio button to checked
      
      _dgv.DataSource = null; //initialize datagridview to null
      //enable a 35ms interval timer and bind tick event
      _timer.Enabled = true;
      _timer.Interval = 35;
      _timer.Tick += _timer_Tick;

      //set location of main form
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
    }
    
    private void _rb_Click(object sender, EventArgs e)
    {
      UpdateGridView(); //invoke helper method whenever radio button is clicked
    }
    /// <summary>
    /// Accepts and returns nothing. Gets a copy of balls from table class and sorts based on selected method.
    /// Displays results in a DataGridView
    /// </summary>
    private void UpdateGridView()
    {
      if (poolTable == null) //only run if there is a pool table
        return;
      List<Ball> balls = poolTable.copyBalls; //gets copy of ball collection from pool table
      if (_rb_Radius.Checked)
      {
        balls.Sort(); //default compareto sorts by radius desc
      }
      if (_rb_Hits.Checked)
      {
        balls.Sort(Ball.SortDescHits); //invoke static Ball method to sort by Hits desc
      }
      if (_rb_TotalHits.Checked)
      {
        balls.Sort(Ball.SortDescTotalHits); //invoke static Ball method to sort by Total Hits desc
      }
      _dgv.DataSource = null; //clear datagridview
      _dgv.DataSource = balls; //show sorted collection
      _dgv.RowHeadersVisible = false; //hide headers
      _dgv.Columns["BallColor"].Visible = false; //hide ball color column
      _dgv.Columns["Center"].Visible = false; //hide ball center location column
      _dgv.Columns["Velocity"].Visible = false; //hide velocity column

      //count and display percentage of balls hit during last shot
      int ballsHit = 0;
      foreach(Ball b in balls)
      {
        if (b.Hits > 0)
        {
          ballsHit++;
        }
      }
      Text = $"Lab02 - Pool - {ballsHit/balls.Count*100}% of Balls Hit"; //update form text with percentage of balls hit

    }

    private void _lbl_FrictionValue_MouseWheel(object sender, MouseEventArgs e)
    {
      //if scrolling down, reduce friction value (balls slow down more)
      if (e.Delta < 0)
      {
        Ball.Friction -= fDelta;
        if (Ball.Friction < 0)
        {
          Ball.Friction = 0; //minimum zero friction (balls dont move)
        }
      }
      //if scrolling up increase friction value (balls slow down less)
      if (e.Delta > 0)
      {
        Ball.Friction += fDelta;
        if(Ball.Friction>1)
        {
          Ball.Friction = 1; //max friction of 1 (balls dont slow down)
        }
      }
      _lbl_FrictionValue.Text = Ball.Friction.ToString("F3"); //update label
    }

    private void _btn_Table_Click(object sender, EventArgs e)
    {
      //create a new table class if one doesnt exist
      if (poolTable == null)
      {
        poolTable = new Table();
      }
      
      poolTable.MakeTable(tableWidth, tableHeight, numBalls); //make a new table with specificed size and number of balls
      poolTable.drawer.Position = new Point(Location.X + Width, Location.Y); //move drawer window next to main form
      _timer.Start(); //start timer
      _running = true; //set running flag
      
    }

    private void _btn_Table_MouseWheel(object sender, MouseEventArgs e)
    {
      //reduce number of balls to make if scrolling down (min 1 ball)
      if (e.Delta < 0)
      {
        if (numBalls > 1)
        {
          numBalls--;
        }
      }
      //increase number of balls to make if scrolling up
      if (e.Delta > 0)
      {
          numBalls++;
      }
      _btn_Table.Text = $"New Table [{numBalls}]"; //update button text
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
      if (poolTable == null) //return if pool table doesnt exist
        return;
      poolTable.ShowTable(); //invoke method to render table and balls
      if(_running)
        if (!poolTable.Running)
        {
          UpdateGridView(); //update datagridview when all balls have stopped moving
        }
    }
  }
}
