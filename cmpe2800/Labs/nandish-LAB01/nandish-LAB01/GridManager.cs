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

    public void Tick()
    {
      foreach(Block block in _grid.Where(b => b is Block))
      {
        if(CanBlockFall(block,_grid)&& block.Location.Y < _YSize - 1)
          block.Fall();
      }
      List<Grid> fallingBlocks = new List<Grid>();
      foreach (Block block in _grid.Where(b => b is Block))
      {
        if(block.RelativeY!=0)
        {
          fallingBlocks.Add(block);
        }
      }
      _grid.RemoveAll(x => x is GridRetainer);
      foreach (Grid block in fallingBlocks)
      {
        AddGridRetainer(new Point(block.Location.X,block.Location.Y+1));
      }
      _grid.RemoveAll(block => block is Block b && b.Dead);
    }

    private bool CanBlockFall(Block currentBlock, List<Grid> blocks) 
    { 
      return !blocks.Where(block=>block is Block).Any(b=>b!=currentBlock&&b.Location.X==currentBlock.Location.X&&b.Location.Y==currentBlock.Location.Y+1);
    }

    public void KillBlock(Point drawerCoordinate)
    {
      Point gridLocation = new Point(drawerCoordinate.X / _BSize, drawerCoordinate.Y / _BSize);
      Grid toDie = _grid.Find(block => block.Location == gridLocation);
      toDie.Die();
    }


    public void Render(CDrawer drawer)
    {
      drawer.Clear();
      
      foreach (Block block in _grid.Where(b=>b is Block))
      {

        drawer.AddRectangle(block.Location.X*_BSize, block.Location.Y*_BSize+block.RelativeY, _BSize, _BSize, block.Color,1,Color.Black);
      }
      drawer.Render();
    }

    public void AddFreeBlock(Point drawerCoordinate)
    {
      Point gridLocation = new Point(drawerCoordinate.X/_BSize, drawerCoordinate.Y/_BSize);

      if (!_grid.Any(block => { return block.Location == gridLocation; }))
      {
        _grid.Add(new Block(gridLocation.X, gridLocation.Y, _BSize, Block.BlockType.Free));
      }

    }

    public void AddSolidBlock(Point drawerCoordinate)
    {
      Point gridLocation = new Point(drawerCoordinate.X / _BSize, drawerCoordinate.Y / _BSize);
      if (!_grid.Any(block => { return block.Location == gridLocation; }))
      {
        _grid.Add(new Block(gridLocation.X, gridLocation.Y,  _BSize, Block.BlockType.Solid));
      }
    }

    private void AddGridRetainer(Point gridLocation)
    {
      if (!_grid.Any(block => { return block.Location == gridLocation; }))
      {
        _grid.Add(new GridRetainer(gridLocation.X, gridLocation.Y));
      }
    }

  }
}
