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

    public abstract void Die();
  }
  internal class GridRetainer : Grid
  {
    public GridRetainer(int XPos, int YPos) : base(new Point(XPos, YPos))
    {

    }
    public override void Die() { return; }
  }
  internal class Block : Grid
  {
    private Color _color;
    public Color Color { get { return _color; } }
    private int _opacity = 255;
    private int _size;
    public int Size { get { return _size; } }
    public int RelativeY { get { return _relativeY; } }
    public bool Falling { get { return _relativeY == 0; } }
    public bool Dead { 
      get 
      { 
        if(blockType==BlockType.Dying)
        {
          _opacity -= 20;
          if(_opacity< 0) { _opacity= 0; }  
          _color = Color.FromArgb(_opacity, _color);
        }
        return _opacity == 0;
      } 
    }

    public enum BlockType
    {
      Free,
      Solid,
      Dying
    }

    public BlockType blockType { get; private set; }
    public Block(int XPos, int YPos, int Size, BlockType type) : base(new Point(XPos, YPos))
    {
      _size = Size;
      blockType = type;
      if (blockType == BlockType.Free)
        _color = Color.Red;
      else if(blockType == BlockType.Solid)
        _color = Color.Orange;
    }
    public void Fall()
    {
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
      blockType = BlockType.Dying;
    }
  }
}
