using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA02
{
  internal static  class PartB
  {
    static Random rand = new Random();
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> sourceCollection)
    {
      List<T> listCollection = new List<T>(sourceCollection);
      void Swap(List<T> list, int i, int j)
      {
        T temp = list[i];
        list[i] = list[j];
        list[j] = temp;
      }
      int n = listCollection.Count();
      for (int i = 0; i < n; i++)
      {
        Swap(listCollection, i, rand.Next(i, n));
        yield return listCollection[i];
      }
    }
  }
}
