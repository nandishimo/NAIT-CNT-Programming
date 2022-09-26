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

namespace nandish_ICA03
{
  public partial class Form1 : Form
  {
    List<Ball> balls = new List<Ball>();
    public Form1()
    {
      InitializeComponent();
      Text = "ICA03 - Static Balls";
      Location = new Point(0,0);
      MouseWheel += Form1_MouseWheel;
      KeyDown += Form1_KeyDown;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Add)
      {
        for (int i = 0; i < 5; ++i)
        {
          balls.Add(new Ball());
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
  }
}
