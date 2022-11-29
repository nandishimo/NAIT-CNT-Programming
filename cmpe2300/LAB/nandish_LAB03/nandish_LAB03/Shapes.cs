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
    protected Shape(PointF Position, Color? Fill=null, int Radius=5)
    {
      _position = Position;
      _fill = Fill.HasValue ? Fill.Value : Color.LightGray;
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
  internal class Shadow : Polygon
  {
    private double _sizeIncrease { get; set; }
    public Shadow(PointF p, Color c, int r, int Sides, double delta = 0.5) : base(p, c, r, Sides)
    {
      _sizeIncrease = delta;
    }
  }
  internal abstract class AniGon:Polygon
  {
    double _sequence { get; set; }
    double _delta { get; set; }
    protected AniGon(PointF p, Color c, int r, int Sides, double sequence, double delta):base(p,c,r,Sides)
    {
      _sequence = sequence;
      _delta = delta;
    }
  }
  internal class Spinner:AniGon
  {
    public Spinner(PointF p, Color c, int r, int sides, double dAniIncrement = 0, double dAniValue = 0) : base(p,c,r,sides,dAniIncrement,dAniValue)
    {

    }
  }
  internal abstract class AniChild : AniGon
  {
    double _distance { get; set; }
    protected AniChild(PointF p, Color c, int r, int Sides, double sequence, double delta, double distance):base(p,c,r,Sides,sequence,delta)
    {
      _distance = distance;
    }
  }
  internal class Orbiter : AniChild
  {
    PointF _xyMultiply { get; set; }
    public Orbiter(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0):base()
    {

    }
  }
}
