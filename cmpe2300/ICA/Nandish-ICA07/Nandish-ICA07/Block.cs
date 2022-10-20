/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A07
***********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Nandish_ICA07
{
  internal class Block : IComparable
  {
    public static CDrawer Drawer { get; private set; }
    public static int Height { get; private set; }
    private static Random rand = new Random(1);
    public int Width { private set; get; }
    public bool HighLight { set; get; }
    private Color _color;

    static Block()
    {
      Height = 20;
      Drawer = new CDrawer(1000,800);
      Drawer.BBColour = Color.Black;
      Drawer.ContinuousUpdate = false;
    }
    public Block()
    {
      Width = rand.Next(1, 20) * 10;
      HighLight = false;
      _color = Color.FromArgb(rand.Next(4, 9) * 32 - 1, rand.Next(4, 9) * 32 - 1, rand.Next(4, 9) * 32 - 1);
    }
    
    public override bool Equals(object obj)
    {
      if(!(obj is Block block)) { return false;}
      return this.Width.Equals(block.Width) && this._color.Equals(block._color);
    }
    public override int GetHashCode()
    {
      return 1;
    }
    public int CompareTo(object obj)
    {
      if (!(obj is Block block)) 
      {
        throw new ArgumentException($"Block:CompareTo:{nameof(obj)} - Not a valid Block");
      }
      return _color.ToArgb().CompareTo(block._color.ToArgb());
    }
    public static int CompareColorWithinWidth(Block block1, Block block2)
    {
      int value;
      //null checks
      if (block1 == null)
        throw new ArgumentNullException(nameof(block1));
      if (block2 == null)
        throw new ArgumentNullException(nameof(block2));
      value =  block1.Width.CompareTo(block2.Width);
      if(value == 0)
      {
        value = block1.CompareTo(block2);
      }
      return value;
    }
    public void ShowBlock(Point point)
    {
      Drawer.AddRectangle(point.X, point.Y, Width, Height, _color, HighLight ? 3 : 1, HighLight ? Color.White : Color.Black);
    }
    public static bool IsBright(object obj)
    {
      if(!(obj is Block block))
      {
        throw new ArgumentException($"Block:CompareTo:{nameof(obj)} - Not a valid Block");
      }
      return block._color.GetBrightness() > 0.7;
    }
  }
}
