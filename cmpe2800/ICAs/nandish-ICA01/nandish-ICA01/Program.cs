/*************************************
 * Submission Code: 1222_2800_A02_A01
 * Nandish Patel
 * 2023/01/12
 * 
 *************************************/

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
      Random _rnd = new Random();

      List<int> iNums = new List<int>(new int[] { 4, 12, 4, 3, 5, 6, 7, 6, 12 });
      foreach (KeyValuePair<int, int> scan in iNums.Categorize())
        Console.WriteLine($"{scan.Key:d3} x {scan.Value:d5}");

      List<string> names = new List<string>(new string[] {
      "Rick", "Glenn", "Rick", "Carl", "Michonne", "Rick", "Glenn" });
      foreach (KeyValuePair<string, int> scan in names.Categorize())
        Console.WriteLine($"{scan.Key} x {scan.Value:d5}");

      LinkedList<char> llfloats = new LinkedList<char>();
      while (llfloats.Count < 1000)
        llfloats.AddLast((char)_rnd.Next('A', 'Z' + 1));
      foreach (KeyValuePair<char, int> scan in llfloats.Categorize())
        Console.WriteLine($"{scan.Key} x {scan.Value:d5}");
      string TestString = "This is the test string, do not panic!";
      foreach (KeyValuePair<char, int> scan in TestString.Categorize())
        Console.WriteLine($"{scan.Key} x {scan.Value:d5}");
    }

  }

  internal static class ExtentionMethods
  {
    static Random rand = new Random();
    public static Dictionary<T, int> Categorize<T>(this IEnumerable<T> sourcelist)
    {
      Dictionary<T, int> result = new Dictionary<T, int>();
      foreach (T i in sourcelist)
      {
        if (result.ContainsKey(i))
        {
          result[i]++;
        }
        else
          result.Add(i, 1);
      }
      return result.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

    }

    public static T Rando<T>(this IEnumerable<T> source)
    {
      return source.ElementAt(rand.Next(0, source.Count()));
    }

    public static (key,val) Rando<key,val>(this Dictionary<key,val> source)
    {
      KeyValuePair<key, val> kvp = source.ElementAt(rand.Next(0, source.Count()));
      return (kvp.Key, kvp.Value);
    }



  }
}
