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
    protected Point _iiLocation;
    protected Color _color;
    protected int _size;
    public Point Location { get { return _iiLocation; } }
    public int Size { get { return _size; } }
    public Color Color { get { return _color; } }

    public Grid(Point iiLocation, Color color, int size)
    {
      _iiLocation = iiLocation;
      _color = color;
      _size = size;
    }
  }
  internal class GridRetainer : Grid
  {
    public GridRetainer(int XPos, int YPos, int Size) : base(new Point(XPos, YPos), Color.FromArgb(0,0,0,0), Size)
    {

    }
  }
  internal class Block : Grid
  {
    public Block(int XPos, int YPos, Color Color, int Size) : base(new Point(XPos, YPos), Color, Size)
    {

    }
    public void Fall()
    {
      _iiLocation.Y--;
    }

  }
}
