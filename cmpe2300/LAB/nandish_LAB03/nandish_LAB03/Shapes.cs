/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_L03
***********************************/
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
    void Tick();
  }
  //base abstract shape class. Takes arguments to specify position, Color and size. supports IRenderable
  public abstract class Shape:IRenderable
  {
    protected internal PointF _position { get; protected set; } //center point of shape
    protected Color _fill { get; set; } //color of shape
    protected int _radius { get; set; } //size of shape
    protected Shape(PointF Position, Color? Fill = null, int Radius = 5)
    {
      _position = new PointF(Position.X, Position.Y);
      _fill = Fill.HasValue ? Fill.Value : Color.LightGray;
      if (Radius < 1)
        throw new ArgumentOutOfRangeException(nameof(Radius), "Radius cannot be less than 1");
      _radius = Radius;
    }
    /// <summary>
    /// Method to render shape to a given drawer. Invokes abstract method that is replaced in derived classes.
    /// </summary>
    /// <param name="dr">CDrawer object</param>
    public void Render(CDrawer dr)
    {
      ARender(dr);
    }
    public abstract void ARender(CDrawer dr);

  }
  //Derived from Shape. Takes arguments to specify number of sides and overrides ARender
  public class Polygon : Shape
  {
    protected int _sides { get; set; } //number of sides of polygon
    public Polygon(PointF p, Color c, int r, int Sides) : base(p, c, r)
    {
      if (Sides < 3)
        throw new ArgumentOutOfRangeException(nameof(Sides), "Need a minimum of 3 sides");
      _sides = Sides;
    }
    /// <summary>
    /// Adds a polygon in the given drawer with the parameters set in the class members
    /// </summary>
    /// <param name="dr">CDrawer object</param>
    public override void ARender(CDrawer dr)
    {
      dr.AddPolygon((int)_position.X - _radius, (int)_position.Y - _radius, _radius, _sides, 0, _fill);
    }
  }
  //Derived from polygon, adds a "shadow" when rendering the polygon
  public class Shadow : Polygon
  {
    private double _sizeIncrease { get; set; } //multiplier to increase shadow size from base size
    public Shadow(PointF p, Color c, int r, int Sides, double delta = 0.5) : base(p, c, r, Sides)
    {
      _sizeIncrease = delta;
    }
    /// <summary>
    /// Adds a polygon shadow with specified size delta and invokes polygon ARender
    /// </summary>
    /// <param name="dr">CDrawer object</param>
    public override void ARender(CDrawer dr)
    {
      int shadowR = _radius + (int)(_radius * _sizeIncrease);
      dr.AddPolygon((int)(_position.X - shadowR), (int)(_position.Y - shadowR), shadowR, _sides, 0, Color.FromArgb(127, _fill));
      base.ARender(dr);
    }
  }
  /// <summary>
  /// Derived from polygon. Supports IAnimate interface. Adds members and CTOR parameters for sequence value and delta
  /// </summary>
  public abstract class AniGon : Polygon,IAnimate
  {
    protected double _sequence { get; set; } //to control animation state(animation state)
    protected double _delta { get; set; } //how much in increment sequence value
    public AniGon(PointF p, Color c, int r, int Sides, double dAniIncrement, double dAniValue) : base(p, c, r, Sides)
    {
      _sequence = dAniValue;
      _delta = dAniIncrement;
    }
    /// <summary>
    /// Method to handle animation sequence. Invokes Virtual method that is replaced by derived classes
    /// </summary>
    public void Tick()
    {
      VTick();
    }
    /// <summary>
    /// Increments sequence member value by delta member value
    /// </summary>
    protected virtual void VTick()
    {
      _sequence += _delta; 
    }
  }
  //Derived from Anigon. Overridees ARender to render a spinning polygon
  public class Spinner : AniGon
  {
    public Spinner(PointF p, Color c, int r, int sides, double dAniIncrement = 0, double dAniValue = 0) : base(p, c, r, sides, dAniIncrement, dAniValue)
    {

    }
    /// <summary>
    /// Draws a polygon whose rotation angle is specified by the sequence value
    /// </summary>
    /// <param name="dr">CDrawer object</param>
    public override void ARender(CDrawer dr)
    {
      dr.AddPolygon((int)_position.X - _radius, (int)_position.Y - _radius, _radius, _sides, _sequence, _fill);
    }
  }
  //Derived from Anigon. This abstract class is to add child shapes to a parent 
  public abstract class AniChild : AniGon
  {
    protected Shape _parent { get; set; } //shape instance that is a parent to this
    protected double _dDistToParent { get; set; } //distance to parent object
    protected AniChild(PointF p, Color c, int r, int Sides, Shape parent, double dDistToParent, double dAniIncrement = 0, double dAniValue = 0) : base(p, c, r, Sides, dAniIncrement, dAniValue)
    {
      _parent = parent; //the parent shape to this object
      _dDistToParent = dDistToParent; //distance to parent shape
      Tick(); //invoke tick to initialize position
    }
    /// <summary>
    /// Addes a white line from parent to child
    /// </summary>
    /// <param name="dr">CDrawer object</param>
    public override void ARender(CDrawer dr)
    {
      dr.AddLine((int)_parent._position.X, (int)_parent._position.Y, (int)_position.X, (int)_position.Y, Color.White);
      base.ARender(dr);
    }
  }
  //Derived from AniChild. Creates a shape that orbits the parent at a specifed distance
  public class Orbiter : AniChild
  {
    PointF _ratio { get; set; }
    public Orbiter(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0) : base(parent._position, c, r, sides, parent, dDistToParent, dAniIncrement, dAniValue)
    {
      _ratio = ratio; //controls how much orbiter moves in X and Y directions 0 is not movement, 1 is full movement
    }
    /// <summary>
    /// Calculates position relative to parent from the distance member and ratio.
    /// Invokes base VTick()
    /// </summary>
    protected override void VTick()
    {
      _position = new PointF((float)(_parent._position.X + _dDistToParent * Math.Sin(_sequence) * _ratio.X), (float)(_parent._position.Y + _dDistToParent * Math.Cos(_sequence) * _ratio.Y));
      base.VTick();
    }
  }
  //Derived from Orbiter. Fades color between 50% and 100% opacity.
  public class Fader : Orbiter
  {
    public Fader(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0) : base(c, r, sides, parent, dDistToParent, ratio, dAniIncrement, dAniValue)
    {

    }
    /// <summary>
    /// Fades color between 50% and 100% opacity based on sequence member
    /// </summary>
    protected override void VTick()
    {
      Color baseColor = _fill;
      int opac = (int)((127) + Math.Abs(127 * Math.Cos(_sequence))); //opacity controlled by sequence value
      _fill = Color.FromArgb(opac, baseColor); //set color to be base color with opacity
      base.VTick();
    }
  }
  //Derived from Orbiter. This shape will grow and shrink between 50% to 150% radius
  public class Grower : Orbiter
  {
    public Grower(Color c, int r, int sides, Shape parent, double dDistToParent, PointF ratio, double dAniIncrement = 0, double dAniValue = 0) : base(c, r, sides, parent, dDistToParent, ratio, dAniIncrement, dAniValue)
    {

    }
    /// <summary>
    /// Uses sequence member value to adjust radius for rendering
    /// </summary>
    /// <param name="dr">CDrawer object</param>
    public override void ARender(CDrawer dr)
    {
      int baseRadius = _radius; //save base radius
      _radius += (int)(0.5 * _radius * Math.Sin(_sequence)); //size modulation controlled by sequence value
      base.ARender(dr);
      _radius = baseRadius; //reset to original after render
    }

  }
}
