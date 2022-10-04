using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Nandish_ICA05
{
  internal class Ball:IComparable
  {
    private static CDrawer window = null;
    private static Random rand = new Random();
    private float _radius;
    public float Radius
    { set { _radius = Math.Abs(value); } }
    private Color _color;
    private PointF _center;
    public enum ESortType
    {
      eRadius,
      eDistance,
      eColor
    }
    public ESortType _sort { get; set; }
    
    static Ball()
    {
      window = new CDrawer();
      window.ContinuousUpdate = false;
      window.BBColour = Color.White;
    }
    public Ball(float radius)
    {
      Radius = radius;
      _color = RandColor.GetColor();
      _center = new PointF((float)(_radius + (window.ScaledWidth - 2 * _radius) * rand.NextDouble()),
        (float)(_radius + (window.ScaledHeight - 2 * _radius) * rand.NextDouble()));
    }
    public static bool Loading
    {
      set
      {
        if (value) window.Clear();
        else window.Render();
      }
    }
    public static Point Location
    {
      set
      {
        window.Position = value;
      }
    }
    public void ShowBall()
    {
      window.AddCenteredEllipse((int)_center.X, (int)_center.Y, (int)_radius * 2, (int)_radius * 2, _color);
    }
    public float DistanceFrom(PointF point)
    {
      double dx = this._center.X - point.X;
      double dy = this._center.Y - point.Y;
      return (float)Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
    }
    public override bool Equals(object obj)
    {
      if(!(obj is Ball ball))
        return false;
      return (DistanceFrom(ball._center)-this._radius-ball._radius)<0;
    }
    public override int GetHashCode()
    {
      return 1;
    }
    public int CompareTo(object obj)
    {
      if(!(obj is Ball ball))
      {
        throw new ArgumentException($"Ball:CompareTo:{nameof(obj)} - Not a valid Ball");
      }
      int value;
      if (_sort == ESortType.eRadius)
      {
        value = _radius.CompareTo(ball._radius);
      }
      else if (_sort == ESortType.eDistance)
      {
        value = (int)DistanceFrom(new PointF(0, 0)).CompareTo(ball.DistanceFrom(new PointF(0, 0)));
      }
      else
      {
        value = _color.ToArgb().CompareTo(ball._color.ToArgb()); 
      }
      return value;
    }
  }
}
