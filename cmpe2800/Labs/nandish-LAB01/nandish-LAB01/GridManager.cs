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
    private List<Grid> _grid = new List<Grid>(); //list of grid objects
    private int _YSize; //height of window in grid units
    private int _BSize; //block size i.e. grid size

    public GridManager(int Height, int BlockSize)
    {
      _YSize = Height / BlockSize; //convert pixel height to grid height
      _BSize = BlockSize; //save block size
    }

    public void Tick()
    {
      foreach(Block block in _grid.Where(b => b is Block)) //foreach through grid list and check if blocks can fall
      {
        if(CanBlockFall(block,_grid)&& block.Location.Y < _YSize - 1)
          block.Fall();
      }
      List<Grid> fallingBlocks = new List<Grid>(); //create new list of falling blocks
      foreach (Block block in _grid.Where(b => b is Block))
      {
        if(block.RelativeY!=0)
        {
          fallingBlocks.Add(block); //copy over falling blocks to new list
        }
      }
      _grid.RemoveAll(x => x is GridRetainer); //clear grid retainer list
      foreach (Grid block in fallingBlocks) //add a grid retainer into the grid space below each falling block
      {
        AddGridRetainer(new Point(block.Location.X,block.Location.Y+1));
      }
      _grid.RemoveAll(block => block is Block b && b.Dead); //remove all dead blocks from list
    }

    private bool CanBlockFall(Block currentBlock, List<Grid> blocks) 
    { 
      //check all Block objects in grid List. if any have no grid object below them, then they can fall
      return !blocks.Where(block=>block is Block).Any(b=>b!=currentBlock&&b.Location.X==currentBlock.Location.X&&b.Location.Y==currentBlock.Location.Y+1);
    }

    public void KillBlock(Point drawerCoordinate)
    {
      Point gridLocation = new Point(drawerCoordinate.X / _BSize, drawerCoordinate.Y / _BSize); //convert drawer coordinate to grid coordinate
      Block toDie = (Block)_grid.Find(block => block is Block b && block.Location == gridLocation); //looks for a block at the clicked grid location 
      if(!toDie.Falling) //if the block is not falling, then it must die
        toDie.Die();
    }


    public void Render(CDrawer drawer) //drawer passed from main form
    {
      drawer.Clear(); //clear the drawer
      
      foreach (Block block in _grid.Where(b=>b is Block))
      {
        //add all free and solid blocks from list to drawer
        drawer.AddRectangle(block.Location.X*_BSize, block.Location.Y*_BSize+block.RelativeY, _BSize, _BSize, block.Color,1,Color.Black);
      }
      drawer.Render(); //render drawer
    }

    public void AddFreeBlock(Point drawerCoordinate)
    {
      Point gridLocation = new Point(drawerCoordinate.X/_BSize, drawerCoordinate.Y/_BSize); //convert drawer coordinate to grid coordinate
      if (!_grid.Any(block => { return block.Location == gridLocation; })) //check if a grid object exists in that spot
      {
        _grid.Add(new Block(gridLocation.X, gridLocation.Y, _BSize, Block.BlockType.Free)); //add a new Free block if the spot is free
      }

    }

    public void AddSolidBlock(Point drawerCoordinate) 
    {
      Point gridLocation = new Point(drawerCoordinate.X / _BSize, drawerCoordinate.Y / _BSize); //convert drawer coordinate to grid coordinate
      if (!_grid.Any(block => { return block.Location == gridLocation; })) //check if a grid object exists in that spot
      {
        _grid.Add(new Block(gridLocation.X, gridLocation.Y,  _BSize, Block.BlockType.Solid)); //add a new Solid block if the spot is free
      }
    }

    private void AddGridRetainer(Point gridLocation) //convert drawer coordinate to grid coordinate
    {
      if (!_grid.Any(block => { return block.Location == gridLocation; })) //check if a grid object exists in that spot
      {
        _grid.Add(new GridRetainer(gridLocation.X, gridLocation.Y)); //add a new GridRetainer if the spot is free
      }
    }

  }
}
