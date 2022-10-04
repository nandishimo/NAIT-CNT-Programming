using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nandish_ICA05
{
  public partial class Form1 : Form
  { 
    List<Ball> balls = new List<Ball>();
    float radius = 10;
    public Form1()
    {
      InitializeComponent();
      MouseDown += Form1_MouseDown;
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
      
      Ball ball = new Ball(radius);
      balls.Add(ball);
      Ball.Loading = true;
      foreach(Ball b in balls)
      {
        b.ShowBall();
      }
      Ball.Loading = false;
    }
  }
}
