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
    public Point Location { get { return _iiLocation; } }

  }
  internal class GridRetainer : Grid
  {
    public GridRetainer(int XPos, int YPos)
    {
      _iiLocation.X = XPos;
      _iiLocation.Y = YPos;
    }
  }
  internal class Block : Grid
  {
    public Block(int XPos, int YPos, Color Color) 
    {
      _iiLocation.X = XPos;
      _iiLocation.Y = YPos;
      _color = Color;
    }
    public void Fall()
    {
      _iiLocation.Y--;
    }

  }
}
