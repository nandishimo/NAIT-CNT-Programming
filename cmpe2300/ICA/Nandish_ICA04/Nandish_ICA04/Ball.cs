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
    private int _radius;
    public int Radius
    {
      set { if (value != 0) _radius = Math.Abs(value); }
    }
    private Color _color;
    private PointF _center;
    static Ball()
    {
      drawer = new CDrawer();
      drawer.BBColour = RandColor.GetColor();
      drawer.ContinuousUpdate = false;
    }
    public Ball(int radius)
    {
      _color = RandColor.GetColor();
      Radius = radius;
      _center = new PointF((float)rand.NextDouble() * drawer.ScaledWidth, (float)rand.NextDouble() * drawer.ScaledHeight);
    }
    public void AddBall()
    {
      drawer.AddCenteredEllipse(new Point((int)_center.X, (int)_center.Y), _radius * 2, _radius * 2, _color); 
    }
    public static bool Loading
    {
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
    {
      set { drawer.Position = value; }
    }
    private static double BallDistance(Ball ball1, Ball ball2)
    {
      double dx = ball1._center.X - ball2._center.X;
      double dy = ball1._center.Y - ball2._center.Y;
      return Math.Sqrt(Math.Pow(dx,2)+Math.Pow(dy,2));
    }
    public override bool Equals(object obj)
    {
      if(!(obj is Ball ball)) 
        return false;
      if (BallDistance(this,ball)-this._radius-ball._radius>0)
        return false;
      else
        return true;
    }
  }
}
