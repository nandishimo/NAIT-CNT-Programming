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
    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> sourceCollection)where T : IEnumerator
    {
      void Swap(T valA, T valB)
      {
        (valB, valA) = (valA, valB);
      }
      int n = sourceCollection.Count();
      for (int i = 0; i < n; i++)
      {
        Swap(sourceCollection.ElementAt(i), sourceCollection.ElementAt(rand.Next(i, n)));
      }
      return sourceCollection;
    }
  }
}
