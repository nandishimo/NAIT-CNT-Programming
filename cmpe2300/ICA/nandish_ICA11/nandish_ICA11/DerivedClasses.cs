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
      BBColour = Color.White;
      for(int i=0;i<100;i++)
        AddRectangle(_drand.NextDrawerRect(drawer), RandColor.GetKnownColor());

    }
  }
  internal class PosDrawer : GDIDrawer.CDrawer
  {
    public enum EPosition
    {
      eRight,
      eBelow,
      eBelowRight,
      eNone
    };
    public void SetPosition (Form1 form, EPosition position)
    {
      int x;
      int y;
      if(position == EPosition.eRight)
      {
        x = form.Location.X + form.Width;
        y = form.Location.Y;
      }
      else if(position == EPosition.eBelow)
      {
        x=form.Location.X;
        y=form.Location.Y+form.Height;
      }
      else if(position == EPosition.eBelowRight)
      {
        x = form.Location.X + form.Width;
        y = form.Location.Y + form.Height;
      }
      else
      {
        return;
      }
      this.Position = new Point(x, y);

    }
    public void SetPosition (CDrawer drawer, EPosition position)
    {
      int x;
      int y;
      if (position == EPosition.eRight)
      {
        x = drawer.Position.X + drawer.ScaledWidth;
        y = drawer.Position.Y;
      }
      else if (position == EPosition.eBelow)
      {
        x = drawer.Position.X;
        y = drawer.Position.Y + drawer.ScaledHeight;
      }
      else if (position == EPosition.eBelowRight)
      {
        x = drawer.Position.X + drawer.ScaledWidth;
        y = drawer.Position.Y + drawer.ScaledHeight;
      }
      else
      {
        return;
      }
      this.Position = new Point(x, y);
    }

    public PosDrawer(int width=600, int height=400, Form1 form=null, EPosition position=EPosition.eNone)
    {
      CDrawer drawer = new CDrawer(width, height, false);
      drawer.BBColour = Color.LemonChiffon;
      if (form == null)
        return;
      SetPosition(drawer, position);
      form.Activate();
    }

  }
  internal class PicDrawer : PosDrawer
  {

  }
}
