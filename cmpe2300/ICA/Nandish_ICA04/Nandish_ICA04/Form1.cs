using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nandish_ICA04
{
  public partial class Form1 : Form
  {
    //initialize startingradius to 5
    int radius = 5;
    List<Ball> balls = new List<Ball>();
    public Form1()
    {
      InitializeComponent();
      _tBarBallSize.ValueChanged += _tBarBallSize_ValueChanged;
      _btnAddBalls.MouseDown += _btnAddBalls_MouseDown;
      _tBarBallSize.Value = radius; //set track bar to starting radius
      _btnAddBalls.Text = $"Add Balls : Size {_tBarBallSize.Value}"; //update button text
    }

    private void _btnAddBalls_MouseDown(object sender, MouseEventArgs e)
    {
      Ball.Loading = true;//clear window
      int success = 0;
      int fail = 0;
      do
      {
        //add balls to window. either overlapping or distinct based on mouse button
        //count fails and successes
        Ball ball = new Ball(radius); //create new ball 
        if (e.Button == MouseButtons.Left) //add distinct balls only
        {
          if (balls.Contains(ball))
          { //check if ball overlaps with existing balls and add if it is distinct
            fail++;
          }
          else
          {
            balls.Add(ball);
            success++;
          }
        }
        if (e.Button == MouseButtons.Right)
        { //add overlapping balls only
          if (balls.Count == 0) 
          { //if there is no starting ball, add one
            balls.Add(ball);
            success++;
          }
          if (!balls.Contains(ball))
          {
            fail++;
          }
          else
          {
            balls.Add(ball);
            success++;
          }
        }
      } while (fail < 1000 && success < 25);//add either 25 balls or try until 1000 fails
      foreach(Ball ball in balls)
      {
        ball.AddBall();
      }
      Ball.Loading = false;//render balls to window
      Text = $"Loaded {success} distinct balls with {fail} discards";//update form text
      _pBar.Value = fail;//progress bar tracks # of fails

    }

    private void _tBarBallSize_ValueChanged(object sender, EventArgs e)
    {
      _btnAddBalls.Text = $"Add Balls : Size {_tBarBallSize.Value}";//update button text
      radius = _tBarBallSize.Value;//update radius 
    }
  }
}
