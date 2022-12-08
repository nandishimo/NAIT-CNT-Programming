﻿using System;
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
    public PointF _position { get; set; }
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
  }
  public abstract class AniGon:Polygon
  {
    public double _sequence { get; set; }
    public double _delta { get; set; }
    public AniGon(PointF p, Color c, int r, int Sides, double dAniIncrement, double dAniValue) :base(p,c,r,Sides)
    {
      _sequence = dAniIncrement;
      _delta = dAniValue;
    }
    public void Tick()
    {
      ATick();
    }
    public abstract void ATick();
  }
  public class Spinner:AniGon
  {
    public Spinner(PointF p, Color c, int r, int sides, double dAniIncrement = 0, double dAniValue = 0) : base(p,c,r,sides,dAniIncrement,dAniValue)
    {

    }
    public override void ATick()
    {
      _sequence += _delta;
    }
    public override void ARender(CDrawer dr)
    {
      dr.AddPolygon((int)_position.X, (int)_position.Y, _radius, _sides, Math.Sin(_sequence), _fill);
    }
  }
  public abstract class AniChild : AniGon
  {
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
    public override void ATick()
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
