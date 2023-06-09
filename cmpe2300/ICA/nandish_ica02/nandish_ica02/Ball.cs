﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace nandish_ica02
{
  internal class Ball
  {
    private static Random Random = new Random();
    public PointF _center { get; private set;}
    private float _xVel;
    public float X
    {
      set 
      { //bound xvelocity between -10 and 10
        if(value<-10)
          value = -10;
        else if (value > 10)
          value = 10;
        _xVel = value;
      }
    }
    public float Y { get; set; }
    private Color _color;
    private int _opacity;
    public int Opacity 
    { 
      set 
      {//bound opacity between 20 and 255. always ensure opacity is positive
        value= Math.Abs(value);
        if(value<20)
        {
          value = 20;
        }
        else if (value > 255)
        {
          value = 255;
        }
        _opacity = value;
      } 
    }
    public readonly int _radius;

    public Ball(PointF center)
    {
      _center = new PointF(center.X, center.Y);
      _color = RandColor.GetColor();
      _radius = Random.Next(30, 101);
      _xVel = (float)(Random.NextDouble()-0.5)*20;
      Y = (float)(Random.NextDouble() - 0.5) * 20;
      _opacity = 128;
    }
    public void MoveBall(CDrawer window)
    {
      PointF tmp = _center;
      tmp.X += _xVel;
      tmp.Y += Y;
      //check if out of bounds (4 sides of window) and move ball inbounds + reverse velocity(bounce)
      if(tmp.X<_radius)
      {
        tmp.X = _radius;
        _xVel *= -1;
      }
      else if(tmp.X > window.ScaledWidth-_radius)
      {
        tmp.X = window.ScaledWidth - _radius;
        _xVel *= -1;
      }
      if (tmp.Y < _radius)
      {
        tmp.Y = _radius;
        Y *= -1;
      }
      else if (tmp.Y > window.ScaledHeight - _radius)
      {
        tmp.Y = window.ScaledHeight - _radius;
        Y *= -1;
      }
      _center = tmp;
    }
    public void ShowBall(CDrawer window)
    {//add circle to drawer window to represent ball
      window.AddCenteredEllipse((int)_center.X, (int)_center.Y, _radius*2, _radius*2, Color.FromArgb(_opacity,_color));
    }

    public override string ToString()
    {//override tostring for nice UI element
      return $"{_center} - Vel: {_xVel:n3}, {Y:n3} - Opacity: {_opacity}";
    }
  }
}
