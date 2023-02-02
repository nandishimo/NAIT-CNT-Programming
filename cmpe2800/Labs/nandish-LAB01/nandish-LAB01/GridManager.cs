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
      drawer.Clear();
      foreach (Block block in _grid)
      {
        drawer.AddRectangle(block.Location.X*_BSize, block.Location.Y*_BSize, _BSize, _BSize, block.Color);
      }
      drawer.Render();
    }

    public void AddFreeBlock(Point drawerCoordinate)
    {
      Point gridLocation = new Point(drawerCoordinate.X/_BSize, drawerCoordinate.Y/_BSize);
      if (_grid.Count == 0)
      {
        _grid.Add(new Block(gridLocation.X, gridLocation.Y, Color.Red, _BSize));
        return;
      }
      else if (!_grid.Any(block => { return block.Location == gridLocation; }))
      {
        _grid.Add(new Block(gridLocation.X, gridLocation.Y, Color.Red, _BSize));
      }

    }

  }
}
