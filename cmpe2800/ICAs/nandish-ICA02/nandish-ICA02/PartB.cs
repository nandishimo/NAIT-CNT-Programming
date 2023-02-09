/*************************************
 * Submission Code: 1222_2800_A02_A02
 * Nandish Patel
 * 2023/01/19
 * Part B - various iterator methods
 *************************************/
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

    //Shuffle extension method for collections of generic type.
    //Uses Fischer-yates method
    //Returns an IEnumerable<T>
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

    //PullMin extension method for IEnumerable collection of generic type
    //Copies the original collection and returns and removes the minimum value 
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
    //InRange extension method for IEnumerable of generic type
    //iterates through collection and returns elements within a given range
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

    //Factors extension method for IEnumberable collection of type long
    //checks each number from 2 to number/2 for factors (mod = 0)
    //returns valid factors
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

    //password generator method
    //ensures password meets minimum requirements for special characters and numbers
    //adds random valid characters until string minimum random length is met
    //shuffles and returns password as string
    //infinitely generates passwords
    public static IEnumerable<string> Password()
    {
      int length;
      char[] newPassword;
      List<char> specialChars = new List<char>();
      //create a list of valid special characters from ascii table
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
      //construct password starting with the 4 character requirements
      while (true)
      {
        length = rand.Next(8, 11);
        newPassword = new char[length];
        newPassword[0] = (char)rand.Next('0', '9'+1); //digit
        newPassword[1] = (char)specialChars[rand.Next(0, specialChars.Count)]; //special
        newPassword[2] = (char)rand.Next('A', '['); //uppercase
        newPassword[3] = (char)rand.Next('a', '{'); //lowercase
        //add more characters until min length is satisfied
        for(int j =4; j<length;j++)
        {
          newPassword[j] = (char)rand.Next(33, 127);
        }
        newPassword = newPassword.Shuffle().ToArray();
        yield return new string(newPassword);
      }



    }

  }
}
