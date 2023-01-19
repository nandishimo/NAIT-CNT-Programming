using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA02
{
  internal class CGrid:IEnumerable, IEnumerator
  {
    public (int X, int Y) _gridSize;
    public (int X, int Y) _Pos;
    private int eNum = -1;
    public CGrid((int X, int Y)GridSize)
    {
      _gridSize = GridSize;
      _Pos = (0,0);
    }
    public void SetCursorPos((int X, int Y) position)
    {
      if (position.X < 0 || position.Y < 0 || position.X > _gridSize.X || position.Y > _gridSize.Y)
        throw new ArgumentOutOfRangeException("Supplied position is out of grid range!");
      _Pos = position;
    }
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator)this;
    }

    public bool MoveNext()
    {
      eNum++;
    }

    public void Reset()
    {
      eNum = -1;
    }

    public object Current
    {
      get
      {
        //   4 3 2
        //   5 c 1
        //   6 7 0
        (int X, int Y) value;
        (int X, int Y)[] values = { (-1, -1), (-1, -1), (-1, -1), (-1, -1), (-1, -1), (-1, -1), (-1, -1), (-1, -1) };
        values[2].X = values[1].X = values[0].X = _Pos.X + 1;
        values[3].X = values[7].X = _Pos.X;
        values[4].X = values[5].X = values[6].X = _Pos.X - 1;
        values[2].Y = values[1].Y = values[0].Y = _Pos.Y + 1;
        values[3].Y = values[7].Y = _Pos.Y;
        values[4].Y = values[5].Y = values[6].Y = _Pos.Y - 1;
        switch(eNum)
        {
          case 0:
            break;
          case 1:

            break;
          case 2:

            break;
          case 3:

            break;
          case 4:

            break;
          case 5:

            break;
          case 6:

            break;
          case 7:

            break;
          case 8:

            break;
          case 9:

            break;
        }
        if (_Pos.X == 0)
        {
          values[4] = values[5] = values[6] = (-1, -1);
        }
        else if (_Pos.X == _gridSize.X)
        {
          values[0] = values[1] = values[2] = (-1, -1);
        }
        if (_Pos.Y == 0)
        {
          values[4] = values[3] = values[2] = (-1, -1);
        }
        else if (_Pos.Y == _gridSize.Y)
        {
          values[6] = values[7] = values[0] = (-1, -1);
        }

      }
    }

  }
}
