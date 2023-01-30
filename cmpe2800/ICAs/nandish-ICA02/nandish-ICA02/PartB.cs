using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA02
{
  internal static class PartB
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

    public static IEnumerable<T> PullMin<T>(this IEnumerable<T> sourceCollection) where T : IComparable
    {
      List<T> listCollection = new List<T>(sourceCollection);
      HashSet<T> set = new HashSet<T>();
      for (int i = listCollection.Count; i > 0; i--)
      {
        var min = listCollection.Min();
        yield return min;
        set.Add(listCollection.Min());
        listCollection.Remove(listCollection.Min());
      }
    }

  }
}
