using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Nandish_ICA07
{
  internal class Block
  {
    public static CDrawer Drawer
    { 
      private set
      {
        Drawer.ScaledHeight = value;
      } 
    }
    private static Random rand = new Random(1);
    public int Width { private set; get; }
    public bool HighLight { set; get; }
    private Color _color;
  }
}
