using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA02
{
  internal class CGrid : IEnumerable, IEnumerator
  {
    public (int X, int Y) _gridSize;
    public (int X, int Y) _Pos;
    private int eNum = -1;
    public CGrid(int GridXSize, int GridYSize)
    {
      _gridSize.X = GridXSize;
      _gridSize.Y = GridYSize;
      _Pos = (0, 0);
    }
    public void SetCursorPos(int PosX, int PosY)
    {
      if (PosX < 0 || PosY < 0 || PosX > _gridSize.X || PosY > _gridSize.Y)
        throw new ArgumentOutOfRangeException("Supplied position is out of grid range!");
      _Pos.X = PosX;
      _Pos.Y = PosY;
    }
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator)this;
    }

    public bool MoveNext()
    {
      eNum++;
      return eNum < 9;
    }

    public void Reset()
    {
      eNum = -1;
    }

    public object Current
    {
      get
      {
        //   6 7 8
        //   3 4 5
        //   0 1 2
        (int X, int Y) value;
        //(int X, int Y)[] values = { (-1, -1), (-1, -1), (-1, -1), (-1, -1), (-1, -1), (-1, -1), (-1, -1), (-1, -1) };
        //values[2].X = values[1].X = values[0].X = _Pos.X + 1;
        //values[3].X = values[7].X = _Pos.X;
        //values[4].X = values[5].X = values[6].X = _Pos.X - 1;
        //values[2].Y = values[1].Y = values[0].Y = _Pos.Y + 1;
        //values[3].Y = values[7].Y = _Pos.Y;
        //values[4].Y = values[5].Y = values[6].Y = _Pos.Y - 1;
        switch (eNum)
        {
          case 2:
            value = (_Pos.X + 1, _Pos.Y - 1);
            break;
          case 5:
            value = (_Pos.X + 1, _Pos.Y);
            break;
          case 8:
            value = (_Pos.X + 1, _Pos.Y + 1);
            break;
          case 7:
            value = (_Pos.X, _Pos.Y + 1);
            break;
          case 6:
            value = (_Pos.X - 1, _Pos.Y + 1);
            break;
          case 3:
            value = (_Pos.X - 1, _Pos.Y);
            break;
          case 0:
            value = (_Pos.X - 1, _Pos.Y - 1);
            break;
          case 1:
            value = (_Pos.X, _Pos.Y - 1);
            break;
          case 4:
            value = (_Pos.X, _Pos.Y);
            break;
          default:
            value = (-1, -1);
            break;
        }
        if (value.X < 0 || value.Y < 0 || value.X > _gridSize.X || value.Y > _gridSize.Y)
        {
          value = (-1, -1);
        }
        return value;
      }
    }

  }
}
