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
  public abstract class Shape
  {
    protected internal PointF _position { get; protected set; }
    protected Color _fill { get; set; }
    protected int _radius { get; set; }
    protected Shape(PointF Position, Color? Fill=null, int Radius=5)
    {
      _position = new PointF(Position.X-Radius,Position.Y-Radius);
      _fill = Fill.HasValue ? Fill.Value : Color.LightGray;
      if(Radius < 1)
        throw new ArgumentOutOfRangeException(nameof(Radius), "Radius cannot be less than 1");
      _radius = Radius;
    }
    public void Render(CDrawer dr)
    {
      ARender(dr);
    }
    public abstract void ARender(CDrawer dr);

  }
  public class Polygon:Shape
  {
    protected int _sides { get; set; }
    public Polygon(PointF p, Color c, int r, int Sides) : base(p, c, r)
    {
      if (Sides < 3)
        throw new ArgumentOutOfRangeException(nameof(Sides), "Need a minimum of 3 sides");
      _sides = Sides;
    }
    public override void ARender(CDrawer dr)
    {
      dr.AddPolygon((int)_position.X, (int)_position.Y, _radius, _sides,0,_fill);
    }
  }
  public class Shadow : Polygon
  {
    private double _sizeIncrease { get; set; }
    public Shadow(PointF p, Color c, int r, int Sides, double delta = 0.5) : base(p, c, r, Sides)
    {
      _sizeIncrease = delta;
    }
    public override void ARender(CDrawer dr)
    {
      dr.AddPolygon((int)(_position.X-_radius * _sizeIncrease), (int)(_position.Y - _radius * _sizeIncrease), (int)(_radius + _radius * _sizeIncrease), _sides, 0, Color.FromArgb(127,_fill));
      base.ARender(dr);
    }
  }
  public abstract class AniGon:Polygon
  {
    protected double _sequence { get; set; }
    protected double _delta { get; set; }
    public AniGon(PointF p, Color c, int r, int Sides, double dAniIncrement, double dAniValue) :base(p,c,r,Sides)
    {
      _sequence = dAniValue;
      _delta = dAniIncrement;
    }
    public void Tick()
    {
      VTick();
    }
    public virtual void VTick()
    {
      _sequence += _delta;
    }
  }
  public class Spinner:AniGon
  {
    public Spinner(PointF p, Color c, int r, int sides, double dAniIncrement = 0, double dAniValue = 0) : base(p,c,r,sides,dAniIncrement,dAniValue)
    {

    }
    public override void ARender(CDrawer dr)
    {
      dr.AddPolygon((int)_position.X, (int)_position.Y, _radius, _sides, _sequence, _fill);
    }
  }
  public abstract class AniChild : AniGon
  {
    protected Shape _parent { get; set; }
    protected double _dDistToParent { get; set; }
    protected AniChild(PointF p, Color c, int r, int Sides, double dDistToParent, double dAniIncrement = 0, double dAniValue = 0) :base(p,c,r,Sides, dAniIncrement, dAniValue)
    {
      _dDistToParent = dDistToParent;
    }
  }
  public class Orbiter : AniChild
  {
    PointF _ratio { get; set; }
    public Orbiter(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0):base(parent._position,c,r,sides,dDistToParent,dAniIncrement,dAniValue)
    {
      _ratio = ratio;
    }
    public new void VTick()
    {
      
    }
  }
  public class Fader:Orbiter
  {
    public Fader(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0) :base(c,r,sides,parent,dDistToParent,ratio,dAniIncrement,dAniValue)
    {

    }
  }

  public class Grower:Orbiter
  {
    public Grower(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0):base(c, r, sides, parent, dDistToParent, ratio, dAniIncrement, dAniValue)
    {

    }
  }


}
