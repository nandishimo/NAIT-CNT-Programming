using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA01
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> iNums = new List<int>(new int[] { 4, 12, 4, 3, 5, 6, 7, 6, 12 });
      foreach (KeyValuePair<int, int> scan in iNums.Categorize())
        Console.WriteLine($"{scan.Key:d3} x {scan.Value:d5}");

    }

    public static Dictionary<int, int> Categorize(this List<int> sourcelist)
    {

    }
  }
}
