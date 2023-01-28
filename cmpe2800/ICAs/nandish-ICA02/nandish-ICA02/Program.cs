using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      {
        Console.WriteLine("Corner test : \r\n");
        CGrid myTestGrid = new CGrid(10, 8);
        foreach ((int x, int y) q in myTestGrid)
          if (q.x != -1 && q.y != -1)
            Console.WriteLine($"Adjacent : {q.x}, {q.y}");
        Console.WriteLine("\r\nCorner test done\r\n\r\n");
      }
      {
        Console.WriteLine("Edge test : \r\n");
        CGrid myTestGrid = new CGrid(10, 8);
        myTestGrid.SetCursorPos(0, 4);
        foreach ((int x, int y) q in myTestGrid)
          if (q.x != -1 && q.y != -1)
            Console.WriteLine($"Adjacent : {q.x}, {q.y}");
        Console.WriteLine("\r\nEdge test done\r\n\r\n");
      }
      {
        Console.WriteLine("Open test : \r\n");
        CGrid myTestGrid = new CGrid(10, 8);
        myTestGrid.SetCursorPos(3, 5);
        foreach ((int x, int y) q in myTestGrid)
          if (q.x != -1 && q.y != -1)
            Console.WriteLine($"Adjacent : {q.x}, {q.y}");
        Console.WriteLine("\r\nOpen test done\r\n\r\n");
      }
      */

      List<string> testCollection = new List<string>( new string[] { "Alice", "Bob", "Nando", "Stanley", "Yelnats" }) ;


      foreach (var item in testCollection) 
      { Console.Write(item.ToString() + ",");  }
      Console.WriteLine("\n");


      PartB.Shuffle(testCollection);
      //Swap(testCollection, 0, 3);


      foreach (var item in testCollection)
      { Console.Write(item.ToString() + ",");  }
      Console.WriteLine("\n");



    }
    static void Swap<T>(List<T> list, int i, int j)
    {
      T temp = list[i];
      list[i] = list[j];
      list[j] = temp;
    }
  }
}
