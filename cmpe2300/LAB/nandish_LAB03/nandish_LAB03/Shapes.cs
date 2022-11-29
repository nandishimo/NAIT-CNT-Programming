using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace nandish_LAB03
{
  public interface IRenderable
  {
    //render instance to supplied drawer
    void Render(CDrawer dr);
  }
  public interface IAnimate
  {
    //cause per tick changes to instance (movement, animation, etc.)
  }
  internal abstract class Shape
  {
    protected PointF _position { get; set; }
    protected Color _fill { get; set; }
    protected int _radius { get; set; }
    protected Shape(PointF Position, Color Fill, int Radius=5)
    {
      _position = Position;
      _fill = Fill;
      if(Radius < 1)
        throw new ArgumentOutOfRangeException(nameof(Radius), "Radius cannot be less than 1");
      _radius = Radius;
    }
  }
  internal class Polygon:Shape
  {
    private int _sides { get; set; }
    public Polygon(PointF p, Color c, int r, int Sides) : base(p, c, r)
    {
      if (Sides < 3)
        throw new ArgumentOutOfRangeException(nameof(Sides), "Need a minimum of 3 sides");
      _sides = Sides;
    }
  }
}
