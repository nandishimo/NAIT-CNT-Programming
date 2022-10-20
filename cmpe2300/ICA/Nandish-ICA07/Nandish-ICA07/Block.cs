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
    //public static automatic property
    public static CDrawer Drawer { get; private set; }
    //public static automatic property
    public static int Height { get; private set; }
    //private static random field, seeded with 1
    private static Random rand = new Random(1);
    //public automatic property, hidden set
    public int Width { private set; get; }
    //public automatic property
    public bool HighLight { set; get; }
    //private color instance field
    private Color _color;

    static Block()
    { //static constructor to set drawer window size, height=20, black background and continuous update off
      Height = 20;
      Drawer = new CDrawer(1000,800);
      Drawer.BBColour = Color.Black;
      Drawer.ContinuousUpdate = false;
    }
    public Block()
    { //construct blocks with random width 10 to 190
      Width = rand.Next(1, 20) * 10;
      HighLight = false;
      _color = Color.FromArgb(rand.Next(4, 9) * 32 - 1, rand.Next(4, 9) * 32 - 1, rand.Next(4, 9) * 32 - 1);
    }
    //override of equals. blocks are same if color and width are equal
    public override bool Equals(object obj)
    {
      if(!(obj is Block block)) { return false;}
      return this.Width.Equals(block.Width) && this._color.Equals(block._color);
    }
    public override int GetHashCode()
    {//required for IComparable
      return 1;
    }
    public int CompareTo(object obj)
    { //default compare color
      if (!(obj is Block block)) 
      {
        throw new ArgumentException($"Block:CompareTo:{nameof(obj)} - Not a valid Block");
      }
      return _color.ToArgb().CompareTo(block._color.ToArgb());
    }
    public static int CompareColorWithinWidth(Block block1, Block block2)
    { //class comparison method to sort color within width
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
    { //add block to drawer, black/1px border if highlight is false, white/3px border if highlight is true
      Drawer.AddRectangle(point.X, point.Y, Width, Height, _color, HighLight ? 3 : 1, HighLight ? Color.White : Color.Black);
    }
    public static bool IsBright(object obj)
    { //block is "bright" if color is brighter than 0.7
      if(!(obj is Block block))
      {
        throw new ArgumentException($"Block:CompareTo:{nameof(obj)} - Not a valid Block");
      }
      return block._color.GetBrightness() > 0.7;
    }
  }
}
