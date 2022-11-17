using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace nandish_ICA11
{
  // DrawerRandom class derived from Random.
  // Supplies rectangles of random size (max 20% of greatest(width or height))
  // rectangles are positioned to be fully contained within provided CDrawer
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

  // RectDrawer CDrawer derived class
  // Uses DrawerRandom class to draw 100 random rectangles in 400x800 CDrawer
  internal class RectDrawer : GDIDrawer.CDrawer
  {
    private DrawerRandom _drand = null;
    public RectDrawer() : base(400,800)
    {
      _drand = new DrawerRandom(Math.Max(ScaledWidth, ScaledHeight)/5);
      BBColour = Color.White;
      for(int i=0;i<100;i++)
        AddRectangle(_drand.NextDrawerRect(this), RandColor.GetKnownColor());
    }
  }

  //PosDrawer class derived from CDrawer
  //Creates a drawer whose position can be specified relative to another drawer or form
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

    public PosDrawer(int width=600, int height=400, Form1 form=null, EPosition position=EPosition.eNone) : base(width, height, false)
    {
      BBColour = Color.LemonChiffon;
      if (form == null)
        return;
      SetPosition(form, position);
      Render();
      form.Activate();
    }

  }

  // Derived from Posdrawer, can specify position of drawer relative to form
  // Creates a appropriately sized drawer with half grayscale background image
  internal class PicDrawer : PosDrawer
  {
    public PicDrawer(Form1 form=null) : base(Properties.Resources.Yoshi.Width, Properties.Resources.Yoshi.Height, form, EPosition.eRight)
    {
      Bitmap pic = new Bitmap(Properties.Resources.Yoshi);
      int picW = pic.Width;
      int picH = pic.Height;

      //iterate through each pixel of picture
      for(int x = 0; x < picW; x++)
      {
        for(int y = 0; y < picH; y++)
        {
          Color color = pic.GetPixel(x, y);
          if (x < picW / 2) //change pixels in left half of image to be grayscale
          {
            int R = color.R;
            int G = color.G;
            int B = color.B;
            R = G = B = (R + G + B) / 3;
            color = Color.FromArgb(R, G, B);
          }
          SetBBScaledPixel(x, y, color );
        }
      }
      Render();
    }
  }
}
