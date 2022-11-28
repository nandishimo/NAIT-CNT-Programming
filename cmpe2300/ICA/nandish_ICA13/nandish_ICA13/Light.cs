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
      drawer.AddPolygon(lCenter.X, lCenter.Y, (int)radius, 5, 0, Color.FromArgb(opacity, color));
      base.Draw(drawer);
    }
  }
}
