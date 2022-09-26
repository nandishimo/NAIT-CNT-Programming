﻿using System;
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
        if (value == 0) value = 1;
        else if (value < 0) value *= -1;
        if (value > Math.Min(window.ScaledWidth, window.ScaledHeight))
          value = Math.Min(window.ScaledWidth, window.ScaledHeight);
        _radius = value; 
      } 
    }
    private Color _color;
    private PointF _point;
    private Vector2 _velocity;
    private int _iAlive;

    static Ball()
    {
      window = new CDrawer(rand.Next(600,901),rand.Next(500,801),false);
      Radius = rand.Next(10, 81);
    }
    public Ball()
    {
      _color = RandColor.GetKnownColor();
      _velocity = new Vector2((float)(rand.NextDouble()-0.5)*20, (float)(rand.NextDouble() - 0.5) * 20);
      double x = Radius / 2 +(window.ScaledWidth - Radius)*rand.NextDouble();
      double y = Radius / 2 + (window.ScaledHeight - Radius) * rand.NextDouble();
      _point = new PointF((float)x,(float)y);
    }
    public static Point DrawerLocation
    {
      set { window.Position=value; }
    }

    public void ShowBall()
    {
      window.AddCenteredEllipse((int)_point.X,(int)_point.Y, _radius / 2, _radius / 2, _color);
    }

    public void MoveBall()
    {
      _iAlive--;
      if (_iAlive < 1)
      {
        double x = Radius / 2 + (window.ScaledWidth - Radius) * rand.NextDouble();
        double y = Radius / 2 + (window.ScaledHeight - Radius) * rand.NextDouble();
        _point = new PointF((float)x, (float)y);
        _iAlive = rand.Next(50, 128);
      }
      PointF tmp = new PointF(_point.X+_velocity.X, _point.Y+_velocity.Y);
      if (tmp.X < 0)
      {
        _velocity.X *= -1;
        tmp.X = _radius / 2;
      }
      else if(tmp.X > window.ScaledWidth - _radius/2)
      {
        _velocity.X *= -1;
        tmp.X = window.ScaledWidth-_radius/2;
      }
      if (tmp.Y < 0)
      {
        _velocity.Y *= -1;
        tmp.Y = _radius / 2;
      }
      else if(tmp.Y > window.ScaledHeight - _radius / 2)
      {
        _velocity.Y *= -1;
        tmp.Y = window.ScaledHeight-_radius/2;
      }
      _point = tmp;
    }
    public static bool Loading
    {
      set { Loading = value; }
    }
    
  }
}
