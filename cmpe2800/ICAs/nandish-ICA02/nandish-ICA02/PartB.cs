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

    public static IEnumerable<T> InRange<T>(this IEnumerable<T> sourceCollection, (T, T) range) where T : IComparable
    {
      for (int i = 0; i < sourceCollection.Count(); i++)
      {
        if (sourceCollection.ElementAt(i).CompareTo(range.Item1) >= 0 && sourceCollection.ElementAt(i).CompareTo(range.Item2) <= 0)
        {
          yield return sourceCollection.ElementAt(i);
        }
      }
    }

    public static IEnumerable<ulong> Factors(this ulong number)
    {
      yield return 1;
      for (ulong i = 2; i <= number / 2; i++)
      {
        if (number % i == 0)
          yield return i;
      }
      yield return number;
    }

    public static IEnumerable<string> Password()
    {
      int length;
      string newPassword;
      List<char> specialChars = new List<char>();
      for(char i='!'; i<='/'; i++)
      {
        specialChars.Add(i);
      }
      for (char i = ':'; i <= '@'; i++)
      {
        specialChars.Add(i);
      }
      for (char i = '['; i <= '`'; i++)
      {
        specialChars.Add(i);
      }
      for (char i = '{'; i <= '~'; i++)
      {
        specialChars.Add(i);
      }
      while (true)
      {
        length = rand.Next(8, 11);
        newPassword = "";
        newPassword += rand.Next(0, 10); //digit
        newPassword += specialChars[rand.Next(0, specialChars.Count)]; //special
        newPassword += (char)rand.Next('A', '['); //uppercase
        newPassword += (char)rand.Next('a', '{'); //lowercase
        while (newPassword.Length < length)
        {
          newPassword += (char)rand.Next(33, 127);
        }
        yield return newPassword;
      }



    }

  }
}
