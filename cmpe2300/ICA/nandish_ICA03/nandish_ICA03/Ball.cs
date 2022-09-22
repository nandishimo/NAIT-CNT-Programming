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
    }
    
  }
}
