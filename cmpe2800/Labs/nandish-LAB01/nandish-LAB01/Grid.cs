using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nandish_LAB01
{
  internal abstract class Grid
  {
    protected Point _gridLocation; //protected grid location in abstract, private but can be accessed by derived classes
    protected int _relativeY = 0; //y pixel coordinate relative to the blocks grid location

    public Point Location { get { return _gridLocation; } } //block stores its location
    public Grid(Point iiLocation) //all derived grid objects need a location
    {
      _gridLocation = iiLocation;

    }

    public abstract void Die(); //method to start death sequence for dying blocks, needs override 
  }
  internal class GridRetainer : Grid
  {
    //ctor for grid retainer only requires location
    public GridRetainer(int XPos, int YPos) : base(new Point(XPos, YPos))
    {

    }
    public override void Die() { return; } //gridretainers are invisible and dont need to have a dying sequence
  }
  internal class Block : Grid
  {
    //private color field and public get only member
    private Color _color;
    public Color Color { get { return _color; } }
    private int _opacity = 255; //private field for block's opacity
    //private field and public getonly member for block size in pixels
    private int _size;
    public int Size { get { return _size; } }
    public int RelativeY { get { return _relativeY; } } //public member to set parent class field
    public bool Falling { get { return _relativeY != 0; } } //bool member to check if falling (relative Y has changed from 0 if block is falling
    public bool Dead { //check if block is dead
      get 
      { 
        //getting the status of the block updates the dying animation (color fading)
        if(blockType==BlockType.Dying)
        {
          _opacity -= 20;
          if(_opacity< 0) { _opacity= 0; }  
          _color = Color.FromArgb(_opacity, _color);
        }
        return _opacity == 0; //once block is invisible, it is dead
      } 
    }

    public enum BlockType
    {
      Free, //these blocks can fall
      Solid, //these blocks will stay put
      Dying //these blocks will fade when getting the Dying bool
    }

    public BlockType blockType { get; private set; }//public get and private set member
    public Block(int XPos, int YPos, int Size, BlockType type) : base(new Point(XPos, YPos))
    {
      //ctor populates size and blocktype, color is dependant on blocktype
      _size = Size;
      blockType = type;
      if (blockType == BlockType.Free)
        _color = Color.Red;
      else if(blockType == BlockType.Solid)
        _color = Color.Orange;
    }
    public void Fall()
    {
      //if the block is Free, then fall but changing its Y coordinate.
      //update grid location and reset relative Y coordinate when it has moved a full block height
      if (blockType != BlockType.Free) { return; }
      _relativeY++;
      if (_relativeY >= _size)
      {
        _relativeY = 0;
        _gridLocation.Y++;
      }
    }

    public override void Die()
    {
      //change the block type to dying (starts death sequence with bool Dying member
      blockType = BlockType.Dying;
    }
  }
}
