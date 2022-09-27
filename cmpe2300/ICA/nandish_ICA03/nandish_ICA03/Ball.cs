using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Numerics;

namespace nandish_ICA03
{
  internal class Ball
  {
    private static Random rand = new Random();
    private static CDrawer window = null;
    private static int _radius;
    public static int Radius { 
      get { return _radius; } 
      set 
      {
        value = Math.Abs(value);
        if (value == 0) value = 1;
        else if (value > Math.Min(window.ScaledWidth/2, window.ScaledHeight/2))
          value = Math.Min(window.ScaledWidth/2, window.ScaledHeight/2);
        _radius = value; 
      } 
    }
    private Color _color;
    private PointF _point;
    private Vector2 _velocity;
    private int _iAlive;

    static Ball() //static constructor (all balls render to same drawer and same radius)
    {
      window = new CDrawer(rand.Next(600,901),rand.Next(500,801),false);
      Radius = rand.Next(10, 81);
    }
    public Ball() //CTOR, random color, random velocity between -10 and 10, radius capped at smaller of width or height
      // location at given point
    {
      _color = RandColor.GetKnownColor();
      _velocity = new Vector2((float)(rand.NextDouble()-0.5)*20, (float)(rand.NextDouble() - 0.5) * 20);
      double x = _radius +(window.ScaledWidth - 2*_radius) * rand.NextDouble();
      double y = _radius + (window.ScaledHeight - 2*_radius) * rand.NextDouble();
      _point = new PointF((float)x,(float)y);
    }
    public static Point DrawerLocation
    { //set location of drawer window
      set { window.Position=value; }
    }

    public void ShowBall()
    { //add ball to drawer. used iAlive as opacity so it fades out
      Color color = Color.FromArgb(_iAlive, _color);
      window.AddCenteredEllipse((int)_point.X,(int)_point.Y, _radius*2, _radius*2, color);
    }

    public void MoveBall() //adjust position of ball based on velocity and alive counter
    { 
      _iAlive--;
      if (_iAlive < 1)
      {// count down iAlive so ball fades out, then set new random position
        double x = _radius + (window.ScaledWidth - 2 * _radius) * rand.NextDouble();
        double y = _radius + (window.ScaledHeight - 2 * _radius) * rand.NextDouble();
        _point = new PointF((float)x, (float)y);
        _iAlive = rand.Next(50, 128);
      }
      //move ball by added velocity to position, bound ball position to drawer size so it bounces
      PointF tmp = new PointF(_point.X+_velocity.X, _point.Y+_velocity.Y);
      if (tmp.X < _radius)
      {
        _velocity.X *= -1;
        tmp.X = _radius;
      }
      else if(tmp.X > (window.ScaledWidth - _radius))
      {
        _velocity.X *= -1;
        tmp.X = (window.ScaledWidth-_radius);
      }
      if (tmp.Y < _radius)
      {
        _velocity.Y *= -1;
        tmp.Y = _radius;
      }
      else if(tmp.Y > (window.ScaledHeight - _radius))
      {
        _velocity.Y *= -1;
        tmp.Y = (window.ScaledHeight-_radius);
      }
      _point = tmp; //set position to adjusted temp point
    }
    public static bool Loading
    {//use this to clear and render drawer
      set 
      {
        if (value)
        {
          window.Clear();
        }
        else
          window.Render();
      }
    }
    
  }
}
