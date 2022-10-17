/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A04
***********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Nandish_ICA04
{
  internal class Ball
  {
    private static Random rand = new Random();
    private static CDrawer drawer = null;
    private int _radius = 1;//initialize to 1 incase user doesnt supply a valid number
    public int Radius //set _radius but protext it from being set to zero and abs negative values
    {
      set { if (value != 0) _radius = Math.Abs(value); }
    }
    private Color _color;
    private Point _center;
    static Ball()
    {//static drawer window with random background color
      drawer = new CDrawer();
      drawer.BBColour = RandColor.GetColor();
      drawer.ContinuousUpdate = false;
    }
    public Ball(int radius)
    { //create ball specified radius and random color
      _color = RandColor.GetColor();
      Radius = radius;
      _center = new Point(rand.Next(_radius, drawer.ScaledWidth - _radius), rand.Next(_radius,drawer.ScaledHeight - _radius));
    }
    public void AddBall()
    { //add ball to window
      drawer.AddCenteredEllipse(new Point(_center.X, _center.Y), _radius * 2, _radius * 2, _color); 
    }
    public static bool Loading
    { //empty property to control clearing and rendering
      set
      {
        if (value)
        {
          drawer.Clear();
        }
        else
          drawer.Render();
      }
    }
    public static Point Location
    {//set drawer window position
      set { drawer.Position = value; }
    }
    private static double BallDistance(Ball ball1, Ball ball2)
    {//calculate distance between edges of balls
      double dx = ball1._center.X - ball2._center.X;
      double dy = ball1._center.Y - ball2._center.Y;
      return Math.Sqrt(Math.Pow(dx,2)+Math.Pow(dy,2));
    }
    public override bool Equals(object obj)
    {//return true if balls overlap
      if(!(obj is Ball ball)) 
        return false;
      return (BallDistance(this, ball) - this._radius - ball._radius < 0);
    }

  }
}
