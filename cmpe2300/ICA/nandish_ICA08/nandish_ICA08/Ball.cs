using GDIDrawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA08
{
  internal class Ball
  {
    //static Random object, initialized
    private static Random rand { get; set; } = new Random();

    //PointF field to hold ball location
    private PointF bCenter;

    //System.Windows.Vector for velocity
    private System.Windows.Vector velocity;

    //int field for ball radius
    private int bRadius;

    //automatic color property
    public Color _color { get; set; }
    
    //constructor, accepting point for ball location and ball color
    public Ball(PointF ballCenter, Color ballColor)
    {
      bCenter = ballCenter;
      _color = ballColor;
      velocity = new System.Windows.Vector(rand.NextDouble() * 12 - 6,rand.NextDouble() * 12 - 6);
      bRadius = rand.Next(20,51);
    }

    //Equals compares distance between centers to sum of radius of balls
    public override bool Equals(object obj)
    {
      if(!(obj is Ball ball))
      {
        throw new ArgumentException($"Ball:Equals - {nameof(obj)} is not a ball");
      }
      //balls are 'Equal' if touching (i.e. sum of ball radius > distance between ball locations) z = sqrt((x1-x2)^2
      return (bRadius + ball.bRadius) > Math.Sqrt(Math.Pow(bCenter.X - ball.bCenter.X, 2) + Math.Pow(bCenter.Y - ball.bCenter.Y, 2));
    }
    public override int GetHashCode()
    {
      return 1;
    }

    //move function to bounce balls
    public void Move(CDrawer drawer)
    {
      bCenter = new PointF(bCenter.X+ (float)velocity.X, bCenter.Y+(float)velocity.Y);
      //check left bound
      if(bCenter.X - bRadius < 0)
      {
        velocity.X *= -1;
        bCenter = new PointF(bRadius, bCenter.Y);
      }

      //check right bound
      if (bCenter.X + bRadius > drawer.ScaledWidth)
      {
        velocity.X *= -1;
        bCenter = new PointF(drawer.ScaledWidth-bRadius, bCenter.Y);
      }

      //check top bound
      if (bCenter.Y - bRadius < 0)
      {
        velocity.Y *= -1;
        bCenter = new PointF(bCenter.X, bRadius);
      }

      //check bottom bound
      if (bCenter.Y + bRadius > drawer.ScaledHeight)
      {
        velocity.Y *= -1;
        bCenter = new PointF(bCenter.X, drawer.ScaledHeight-bRadius);
      }
    }

    //show function to render balls with int num(index of ball in list)
    public void Show(CDrawer drawer, int index)
    {
      drawer.AddCenteredEllipse((int)bCenter.X, (int)bCenter.Y, bRadius * 2, bRadius * 2, _color);
      drawer.AddText(index.ToString(), 15, (int)bCenter.X - bRadius, (int)bCenter.Y - bRadius, bRadius * 2, bRadius * 2,Color.FromArgb(_color.ToArgb() ^ 0x00FFFFFF));
    }
  }
}
