using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;


namespace nandish_ICA15
{
  public abstract class BaseShape
  {
    public static PicDrawer _canvas { get; set; } // Change to your PicDrawer
    public static Random _rnd { get; private set; }
    private Point _pt { get; set; } // Center of Shape
    public Color _color { get; private set; } // Color of Shape
    private double _dir = 0; // Radians vector of direction
    private double _vel = 5; // Movement velocity
    static BaseShape()
    {
      _rnd = new Random(0);
    }
    public BaseShape(Point pt, Color c)
    {
      _pt = pt;
      _color = c;
      // 0 is right, then counter-clockwise, in radians
      _dir = _rnd.NextDouble() * 2 * Math.PI;
    }
    public Point Move() // NVI - public Move()
    {
      return VirtualMove(); // invokes VirtualMove()
    }
    public void Paint() // NVI - public Paint()
    {
      VirtualPaint(); // invokes VirtualPaint()
    }
    protected virtual Point VirtualMove()
    {
      // Adjust current direction by small random amount
      _dir = _dir + (_rnd.NextDouble() * 0.8 - 0.4);
      // Calculate new X, Y based on direction and velocity
      int iNewX = _pt.X + (int)(_vel * Math.Cos(_dir));
      int iNewY = _pt.Y - (int)(_vel * Math.Sin(_dir));
      // Bounce by adding 90 degrees to direction
      if (iNewX < 0 || iNewX >= _canvas.ScaledWidth)
      {
        _dir += Math.PI / 2;
        iNewX = _pt.X;
      }
      if (iNewY < 0 || iNewY >= _canvas.ScaledHeight)
      {
        _dir += Math.PI / 2;
        iNewY = _pt.Y;
      }
      _pt = new Point(iNewX, iNewY); // Save and return new Point
      return _pt;
    }
    protected abstract void VirtualPaint();
  }
  interface IAnimatable
  {
    void Animate(CDrawer drawer);
  }
  interface IMortal
  {
    bool Step();
  }
  public class Snake : BaseShape, IMortal
  {
    private LinkedList<Point> _points;
    private int Length;
    private int Lives;
    public Snake(Point point, int length) : base(point, Color.Red)
    {
      Length = length;
      Lives = length * 10;
    }
    protected override Point VirtualMove()
    {
      Point pt = base.VirtualMove();
      _points.AddFirst(pt);
      if (_points.Count > Length)
      {
        _points.RemoveLast();
      }
      return pt;
    }
    protected override void VirtualPaint()
    {
      LinkedListNode<Point> pt = _points.First;
      _canvas.AddCenteredEllipse(pt.Value, 3, 3, Color.Red);
      for (int CountDown = Length; CountDown > 0; --CountDown)
      {
        if (pt.Next != null)
          pt = pt.Next;
        _canvas.AddCenteredEllipse(pt.Value, 3, 3, Color.FromArgb(255 * CountDown / Length, _color));
        
      }
    }
    public bool Step()
    {
      bool alive = true;
      Lives--;
      if (Lives <= 0)
        alive = false;
      return alive;
    }
  }
  public class Blob : BaseShape, IAnimatable
  {
    private int Radius;
    private Point LastLocation;
    private double _Animate;
    public Blob(Point pt, Color color, int radius):base(pt,color)
    {
      Radius = radius;
      LastLocation = pt;
    }
    protected override Point VirtualMove()
    {
      Point pt =  base.VirtualMove();
      LastLocation = pt;
      return pt;
    }
    protected override void VirtualPaint()
    {
      int cRadius = Radius + (int)(0.5 * Radius * Math.Cos(_Animate));
      _canvas.AddCenteredEllipse(LastLocation, cRadius, cRadius, _color);
    }
    public void Animate(CDrawer drawer)
    {
      _Animate += Math.PI/8;
    }
  }
}
