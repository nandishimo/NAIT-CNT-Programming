/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A06
***********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Nandish_ICA06
{
  internal class Ball : IComparable
  {
    private static CDrawer window = null;//static drawer member
    private static Random rand = new Random();//static Random member
    private float _radius;//float member for radius
    public float Radius//set only property for radius
    { set { _radius = Math.Abs(value); } }
    private Color _color;//color member
    private PointF _center;//position of ball center

    static Ball() //static contructor for creating drawer window with white background
    {
      window = new CDrawer();
      window.BBColour = Color.White;
      window.ContinuousUpdate = false;
    }
    public Ball(float radius)
    { //instance contructor accepts radius, creates ball of speficifed size and random color and random position
      Radius = radius;
      _color = RandColor.GetColor();
      _center = new PointF((float)(_radius + (window.ScaledWidth - 2 * _radius) * rand.NextDouble()),
        (float)(_radius + (window.ScaledHeight - 2 * _radius) * rand.NextDouble()));
    }
    public static bool Loading
    {//virtual property for clearing and rendering drawer
      set
      {
        if (value) window.Clear();
        else window.Render();
      }
    }
    public static Point Location
    {//manual property to set drawer window position
      set
      {
        window.Position = value;
      }
    }
    public void ShowBall()
    {//method to add ball to drawer
      window.AddCenteredEllipse((int)_center.X, (int)_center.Y, (int)_radius * 2, (int)_radius * 2, _color);
    }
    public float DistanceFrom(PointF point)
    {//method to calculate disance between two points
      double dx = this._center.X - point.X;
      double dy = this._center.Y - point.Y;
      return (float)Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
    }
    public override bool Equals(object obj)
    {//check if balls overlap
      if (!(obj is Ball ball))
        return false;
      return (DistanceFrom(ball._center) - this._radius - ball._radius) < 0;
    }
    public override int GetHashCode()
    {
      return 1;
    }
    public int CompareTo(object obj)
    {//compare radius sort descending
      if (!(obj is Ball ball))//null check
      {
        throw new ArgumentException($"Ball:CompareTo:{nameof(obj)} - Not a valid Ball");
      }
      int value;
      value = -1 * _radius.CompareTo(ball._radius);
      if (value == 0)//tiered sort, color within radius
      {
        value = CompareByColor(this, ball);
      }
      return value;
    }
    public static int CompareByDistance(Ball ball1, Ball ball2)
    {//compare distance to origin, sort descending
      //null checks
      if (ball1 == null)
        throw new ArgumentNullException(nameof(ball1));
      if (ball2 == null)
        throw new ArgumentNullException(nameof(ball2));

      return -1 * ball1.DistanceFrom(new PointF(0, 0)).CompareTo(ball2.DistanceFrom(new PointF(0, 0)));
    }
    public static int CompareByColor(Ball ball1, Ball ball2)
    {//compare color, sort ascending
      if (ball1 == null)
        throw new ArgumentNullException(nameof(ball1));
      if (ball2 == null)
        throw new ArgumentNullException(nameof(ball2));
      int value = ball1._color.ToArgb().CompareTo(ball2._color.ToArgb());
      if(value==0)//tiered sort, ascending radius within color
      {
        value = ball1._radius.CompareTo(ball2._radius);
      }
      return value;
    }
  }
}
