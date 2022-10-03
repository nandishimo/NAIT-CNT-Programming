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
    int radius=0;
    List<Ball> balls = new List<Ball>();
    public Form1()
    {
      InitializeComponent();
      _tBarBallSize.ValueChanged += _tBarBallSize_ValueChanged;
      _btnAddBalls.MouseDown += _btnAddBalls_MouseDown;
      _btnAddBalls.Text = $"Add Balls : Size {_tBarBallSize.Value}";
    }

    private void _btnAddBalls_MouseDown(object sender, MouseEventArgs e)
    {
      Ball.Loading = true;
      int success = 0;
      int fail = 0;
      do
      {
        Ball ball = new Ball(radius);
        if (balls.Contains(ball))
        {
          fail++;
        }
        else
        {
          ball.AddBall();
          balls.Add(ball);
          success++;
        }
      } while (fail <= 1000 && success <= 25);
      
      Ball.Loading = false;

    }

    private void _tBarBallSize_ValueChanged(object sender, EventArgs e)
    {
      _btnAddBalls.Text = $"Add Balls : Size {_tBarBallSize.Value}";
      radius = _tBarBallSize.Value;
    }
  }
}
