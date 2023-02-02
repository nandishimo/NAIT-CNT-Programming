using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace nandish_LAB01
{
  internal class GridManager
  {
    private List<Grid> _grid = new List<Grid>();
    private int _XSize;
    private int _YSize;
    private int _BSize;


    public GridManager(int Width, int Height, int BlockSize)
    {
      _XSize = Width / BlockSize;
      _YSize = Height / BlockSize;
      _BSize = BlockSize;
    }


    public void Render(CDrawer drawer)
    {
      foreach (Block block in _grid)
      {
        drawer.AddRectangle(block.Location.X, block.Location.Y, _BSize, _BSize);
      }
    }

    public bool AddFreeBlock(Point location)
    {
      if (_grid.Any(block => { return block.Location == location; }))
      {
        _grid.Add(new Block(location.X, location.Y, Color.Red));
        return true;
      }
      else return false;

    }

  }
}
