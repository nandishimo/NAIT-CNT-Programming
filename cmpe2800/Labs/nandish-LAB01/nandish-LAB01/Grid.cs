using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_LAB01
{
  internal abstract class Grid
  {
    protected Point _gridLocation;
    protected int _relativeY = 0;

    public Point Location { get { return _gridLocation; } }


    public Grid(Point iiLocation)
    {
      _gridLocation = iiLocation;
      
    }
  }
  internal class GridRetainer : Grid
  {
    public GridRetainer(int XPos, int YPos) : base(new Point(XPos, YPos))
    {

    }
  }
  internal class Block : Grid
  {
    private Color _color;
    public Color Color { get { return _color; } }
    private int _size;
    public int Size { get { return _size; } }
    public int RelativeY { get { return _relativeY; } }
    public enum BlockType
    {
      Free,
      Solid
    }

    public BlockType blockType { get; private set; }
    public Block(int XPos, int YPos, int Size, BlockType type) : base(new Point(XPos, YPos))
    {
      _size = Size;
      blockType = type;
      if(blockType == BlockType.Free)
        _color = Color.Red;
      else 
        _color = Color.Orange;
    }
    public void Fall()
    {
      _relativeY++;
      if(_relativeY >= _size)
      {
        _relativeY = 0;
        _gridLocation.Y++;
      }
    }

  }
}
