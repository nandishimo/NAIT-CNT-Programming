using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace nandish_ICA11
{
  internal class DrawerRandom : Random
  {
    private int maxSize;
    public DrawerRandom(int max)
    {
      maxSize = max;
    }
    public Rectangle NextDrawerRect(CDrawer drawer)
    {
      if(drawer == null)
      {
        throw new ArgumentNullException($"{nameof(drawer)} is null");
      }
      int sizeX = Next(10, maxSize);
      int sizeY = Next(10, maxSize);
      return new Rectangle(Next(0,drawer.ScaledWidth-sizeX), Next(0,drawer.ScaledHeight-sizeY), sizeX, sizeY);
    }
  }

  internal class RectDrawer : GDIDrawer.CDrawer
  {
    private DrawerRandom _drand = null;
    public RectDrawer()
    {
      CDrawer drawer = new CDrawer(400,800);
      _drand = new DrawerRandom((int) Math.Max(drawer.ScaledWidth, drawer.ScaledHeight)/5);
      drawer.BBColour = Color.White;
      for(int i=0;i<100;i++)
        drawer.AddRectangle(_drand.NextDrawerRect(drawer), RandColor.GetKnownColor());

    }
  }
}
