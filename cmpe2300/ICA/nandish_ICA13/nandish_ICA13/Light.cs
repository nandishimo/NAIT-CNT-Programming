using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace nandish_ICA13
{
  internal class Light
  {
    protected Point lCenter;
    public virtual bool bKillMe { get; } = false;
    protected Color color;
    public Light(Point center)
    {
      lCenter = center;
      color = RandColor.GetColor();
    }
    public virtual void Animate()
    {

    }
    public virtual void Draw(CDrawer drawer)
    {
      drawer.AddCenteredEllipse(lCenter, 8, 8, Color.Red);
    }
  }
  internal class FadeLight : Light
  {
    protected int opacity = 255;
    protected double radius;
    public FadeLight(Point Center, double Radius) : base(Center)
    {
      lCenter = Center;
      radius = Radius;
    }
    public override bool bKillMe { get { return opacity < 50; } }
    public override void Animate()
    {
      opacity -= 4;
      if (opacity < 1)
      {
        opacity = 1;
      }
    }
    public override void Draw(CDrawer drawer)
    {
      drawer.AddPolygon(lCenter.X-(int)radius, lCenter.Y-(int)radius, (int)radius, 5, 0, Color.FromArgb(opacity, color));
      base.Draw(drawer);
    }
  }
  internal class SpinLight : Light
  {
    double rotation = 2*Math.PI;
    public SpinLight(Point Center):base(Center)
    {

    }
    public override bool bKillMe { get { return rotation < 0.1; } }
    public override void Animate()
    {
      rotation *= 0.95;
    }
    public override void Draw(CDrawer drawer)
    {
      drawer.AddPolygon(lCenter.X-40, lCenter.Y-40, 40,3,rotation,color);
      base.Draw(drawer);
    }
  }
  internal class ShrinkLight : FadeLight
  {
    public ShrinkLight(Point Center, int Radius):base(Center, Radius)
    {

    }
    public override bool bKillMe { get { return (radius<10||base.bKillMe); } }
    public override void Animate()
    {
      base.Animate();
      radius *= 0.95;
    }
  }
}
