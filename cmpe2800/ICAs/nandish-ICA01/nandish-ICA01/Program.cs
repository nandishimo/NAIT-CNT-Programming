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
      //create instance of Random
      Random _rnd = new Random();

      //test code for Categorize on List<int>
      Console.WriteLine("Test code for Categorize on ints");
      Console.WriteLine("Original List: \n4, 12, 4, 3, 5, 6, 7, 6, 12 \n");
      List<int> iNums = new List<int>(new int[] { 4, 12, 4, 3, 5, 6, 7, 6, 12 });
      Console.WriteLine("Categorized List:");
      foreach (KeyValuePair<int, int> scan in iNums.Categorize())
        Console.WriteLine($"{scan.Key:d3} x {scan.Value:d5}");
      Console.WriteLine();

      //test code for Categorize on List<string>
      Console.WriteLine("Test code for Categorize on strings");
      Console.WriteLine("Original List: \nRick, Glenn, Rick, Carl, Michonne, Rick, Glenn\n");
      List<string> names = new List<string>(new string[] {
      "Rick", "Glenn", "Rick", "Carl", "Michonne", "Rick", "Glenn" });
      Console.WriteLine("Categorized List:");
      foreach (KeyValuePair<string, int> scan in names.Categorize())
        Console.WriteLine($"{scan.Key} x {scan.Value:d5}");
      Console.WriteLine();

      //test code for Categorize on LinkedList<char>
      Console.WriteLine("Test code for Categorize on LinkedList<char>");
      Console.WriteLine("Original List: \nRick, Glenn, Rick, Carl, Michonne, Rick, Glenn\n");
      LinkedList<char> llfloats = new LinkedList<char>();
      while (llfloats.Count < 1000)
        llfloats.AddLast((char)_rnd.Next('A', 'Z' + 1));
      foreach (KeyValuePair<char, int> scan in llfloats.Categorize())
        Console.WriteLine($"{scan.Key} x {scan.Value:d5}");
      string TestString = "This is the test string, do not panic!";
      foreach (KeyValuePair<char, int> scan in TestString.Categorize())
        Console.WriteLine($"{scan.Key} x {scan.Value:d5}");

      List<int> testdataA = new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
      for (int i = 0; i < 10; ++i)
        Console.WriteLine($"Rando from list : {testdataA.Rando()}");
      Dictionary<string, int> testdataB = new Dictionary<string, int>();
      testdataB.Add("First", 1);
      testdataB.Add("Second", 2);
      testdataB.Add("Third", 3);
      testdataB.Add("Forth", 4);
      testdataB.Add("Fifth", 5);
      for (int i = 0; i < 10; ++i)
        Console.WriteLine($"Rando from dictionary : {testdataB.Rando()}");
      Console.WriteLine($"AdjacentDuplicate with no duplicate :{ testdataA.AdjacentDuplicate()}");
      testdataA.Add(5);
            testdataA.Add(7);
            Console.WriteLine($"AdjacentDuplicate with duplicate (5):{ testdataA.AdjacentDuplicate()}");
      List<float> testdataC = new List<float>();
      while (testdataC.Count < 10)
        testdataC.Add((float)(_rnd.NextDouble() * 10));
      foreach (float f in testdataC.ToOrderedLinkedList())
        Console.WriteLine($"OrderedLL from List : {f}");

      CatStack<string> myStack = new CatStack<string>();
      myStack.Push("this");
      myStack.Push("is");
      myStack.Push("what");
      myStack.Push("this");
      myStack.Push("is");
      Console.WriteLine($"Cat element 1 : {myStack[1]}");
      Console.WriteLine($"Cat count 'is' : {myStack["is"]}");
    }

  }

  /*  Create a generic class derived from stack. Provide two indexer overloads:
         Take an int, return the key that is the nth categorized element (throw an
        IndexOutOfRangeException if the index is invalid with respect to the Categorize return count)
         Take a key, return the count for that categorized element (throw an ArgumentException if the
        key does not exist in the Categorize return collection) 
   */
  internal class CatStack<T>:Stack<T>
  {
    public T this[int iIndex]
    {
      get 
      {
        if (iIndex >= this.Count) 
          throw new IndexOutOfRangeException("Index out of range!");
        else
          return this[iIndex];
      }
    }

    public T this[string key ]
    {
      get 
      {
        for(int i=0; i< Count; i++)
          if (this[i].ToString() == key)
            return this[i];

        throw new ArgumentException("Key does not exist!");
      }
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
      if (source.Count() == 0)
        throw new ArgumentException($"{nameof(source)} is empty");
      return source.ElementAt(rand.Next(0, source.Count()));
    }

    public static (key, val) Rando<key, val>(this Dictionary<key, val> source)
    {
      if (source.Count() == 0)
        throw new ArgumentException($"{nameof(source)} is empty");
      KeyValuePair<key, val> kvp = source.ElementAt(rand.Next(0, source.Count()));
      return (kvp.Key, kvp.Value);
    }

    public static T AdjacentDuplicate<T>(this IEnumerable<T> source)
    {
      if (source.Count() == 0)
        throw new ArgumentException($"{nameof(source)} is empty");
      for (int i = 0; i < source.Count() - 1; i++)
      {
        if (source.ElementAt(i).Equals(source.ElementAt(i+1)))
        {
          return source.ElementAt(i);
        }
      }
      return default(T);
    }

    public static LinkedList<T> ToOrderedLinkedList<T>(this IEnumerable<T> source) where T : IComparable<T>
    {
      LinkedList<T> list = new LinkedList<T>();
      foreach (T item in source)
      {
        if (list.Count == 0)
        {
          list.AddFirst(item);
        }
        else
        {
          LinkedListNode<T> current = list.First;
          while (current != null)
          {
            if (current.Value.CompareTo(item) < 0)
            {
              list.AddBefore(current, item); break;
            }
            else
            { current = current.Next; }
            current = current.Next;
          }
        }
      }
      return list;
    }

  }
}
