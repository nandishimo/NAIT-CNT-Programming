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


    public GridManager(int Width, int Height)
    {
      _XSize = Width;
      _YSize = Height;
    }


    public void Render()
    {
      foreach (Block block in _grid)
      {
        
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
