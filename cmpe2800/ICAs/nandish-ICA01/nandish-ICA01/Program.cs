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
      //test for regular list
      Console.WriteLine("Test code for Categorize on ints");
      Console.WriteLine("Original List: \n4, 12, 4, 3, 5, 6, 7, 6, 12 \n");
      List<int> iNums = new List<int>(new int[] { 4, 12, 4, 3, 5, 6, 7, 6, 12 });
      Console.WriteLine("Categorized List:");
      foreach (KeyValuePair<int, int> scan in iNums.Categorize())
        Console.WriteLine($"{scan.Key:d3} x {scan.Value:d5}");
      Console.WriteLine();

      //test on empty list
      Console.WriteLine("Empty List:\n");
      iNums = new List<int>();
      Console.WriteLine("Categorized List:");
      foreach (KeyValuePair<int, int> scan in iNums.Categorize())
        Console.WriteLine($"{scan.Key:d3} x {scan.Value:d5}");
      Console.WriteLine();

      //test on list with one element
      Console.WriteLine("One Element List: \n4\n");
      iNums = new List<int>(new int[] { 4 });
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

      //test code for categorize on string
      Console.WriteLine("Test code for Categorize on string");
      string TestString = "This is the test string, do not panic!";
      Console.WriteLine(TestString);
      foreach (KeyValuePair<char, int> scan in TestString.Categorize())
        Console.WriteLine($"{scan.Key} x {scan.Value:d5}");

      //test code for Rando
      Console.WriteLine("Test code for Rando on List of int");
      List<int> testdataA = new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
      for (int i = 0; i < 10; ++i)
        Console.WriteLine($"Rando from list : {testdataA.Rando()}");

      //test code for Rando on empty list
      //Console.WriteLine("Test code for Rando on empty list");
      //testdataA = new List<int>();
      //Console.WriteLine($"Rando from list : {testdataA.Rando()}");

      //test code for Rando on single element list
      Console.WriteLine("Test code for Rando on single element list: 1");
      testdataA = new List<int>(new int[] { 1 });
      Console.WriteLine($"Rando from list : {testdataA.Rando()}");

      //test code for Rando H/T distribution
      testdataA = new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
      Dictionary<int, int> distribution = new Dictionary<int, int>();
      foreach (int item in testdataA)
      {
        distribution[item] = 0;
      }

      for (int i = 0; i < 1000; i++)
      {
        distribution[testdataA.Rando()]++;
      }
      Console.WriteLine("Distribution of Rando over 1000 runs");
      foreach (KeyValuePair<int, int> stuff in distribution)
        Console.WriteLine($"{stuff.Key} x {stuff.Value:d5}");
      Console.WriteLine();

      //test code for Rando on Dic
      Console.WriteLine("Test code for Rando on Dictionary<string,int>");
      Dictionary<string, int> testdataB = new Dictionary<string, int>();
      testdataB.Add("First", 1);
      testdataB.Add("Second", 2);
      testdataB.Add("Third", 3);
      testdataB.Add("Forth", 4);
      testdataB.Add("Fifth", 5);

      Dictionary<string, int> newDistribution = new Dictionary<string, int>();
      foreach (KeyValuePair<string, int> item in testdataB)
      {
        newDistribution[item.Key] = 0;
      }

      for (int i = 0; i < 1000; i++)
      {
        newDistribution[testdataB.Rando().Item1]++;
        
      }
      foreach (KeyValuePair<string, int> stuff in newDistribution)
        Console.WriteLine($"{stuff.Key} x {stuff.Value:d5}");
      Console.WriteLine();

      //test code for Rando on empty dic
      //Console.WriteLine("Test code for Rando on empty Dictionary");
      //testdataB = new Dictionary<string, int>();
      //Console.WriteLine($"Rando from list : {testdataB.Rando()}");

      //test code for Rando on single element list
      Console.WriteLine("Test code for Rando on single element Dictionary");
      testdataB = new Dictionary<string, int>();
      testdataB.Add("First", 1);
      Console.WriteLine($"Rando from list : {testdataA.Rando()}");

      //test code for AdjacentDuplicate
      Console.WriteLine("Test for AdjacentDuplicate on collection: 0,1,2,3,4,5,6,7 ");
      testdataA = new List<int>(new int[] { 0, 1, 2, 3, 4, 5 });
      Console.WriteLine($"AdjacentDuplicate with no duplicate :{testdataA.AdjacentDuplicate()}");
      testdataA.Add(5);
      testdataA.Add(7);
      testdataA.Add(7);
      Console.WriteLine("Test for AdjacentDuplicate on collection: 0,1,2,3,4,5,5,7,7 ");
      Console.WriteLine($"AdjacentDuplicate with duplicate (5):{testdataA.AdjacentDuplicate()}");

      //test code for AdjacentDuplicate on empty collection
      //testdataA = new List<int>();
      //Console.WriteLine($"AdjacentDuplicate on empty collection :{testdataD.AdjacentDuplicate()}");

      //test code for AdjacentDuplicate on single element collection
      testdataA = new List<int>(new int[] { 1 });
      Console.WriteLine($"AdjacentDuplicate on single element collection :{testdataA.AdjacentDuplicate()}");

      //test code for ToOrderedLinkedList
      List<float> testdataC = new List<float>();
      while (testdataC.Count < 10)
        testdataC.Add((float)(_rnd.NextDouble() * 10));
      foreach (float f in testdataC.ToOrderedLinkedList())
        Console.WriteLine($"OrderedLL from List : {f}");


      //test code for CatStack
      Console.WriteLine("Test Code for CatStack");
      CatStack<string> myStack = new CatStack<string>();
      myStack.Push("this");
      myStack.Push("is");
      myStack.Push("what");
      myStack.Push("this");
      myStack.Push("is");
      Console.WriteLine($"Cat element 1 : {myStack[1]}");
      Console.WriteLine($"Cat count 'is' : {myStack["is"]}");

      //test code for non existent key in Catstack
      Console.WriteLine("Test code for empty CatStack");
      Console.WriteLine($"Cat count 'where' : {myStack["where"]}");

      //test code for empty CatStack
      Console.WriteLine("Test code for empty CatStack");
      myStack = new CatStack<string>();
      Console.WriteLine($"Cat element 1 : {myStack[1]}");


    }

  }

  /*  Create a generic class derived from stack. Provide two indexer overloads:
         Take an int, return the key that is the nth categorized element (throw an
        IndexOutOfRangeException if the index is invalid with respect to the Categorize return count)
         Take a key, return the count for that categorized element (throw an ArgumentException if the
        key does not exist in the Categorize return collection) 
   */
  internal class CatStack<T> : Stack<T>
  {
    public T this[int iIndex]
    {
      get
      {
        Dictionary<T, int> dic = this.Categorize(); //categorize stack
        if (iIndex >= dic.Count) //check if index is in range of categorized stack
          throw new IndexOutOfRangeException("Index out of range!"); //throw exception if out of range
        else
          return dic.ElementAt(iIndex).Key; //return key at given index
      }
    }

    public int this[string key]
    {
      get
      {
        Dictionary<T, int> dic = this.Categorize();//categorize stack
        for (int i = 0; i < dic.Count; i++) //check each index for matching keys and return count
          if (dic.ElementAt(i).Key.Equals(key))
            return dic.ElementAt(i).Value;

        throw new ArgumentException("Key does not exist!"); //throw exepction if no matching keys
      }
    }
  }
  internal static class ExtentionMethods
  {
    static Random rand = new Random(); //create random member
    public static Dictionary<T, int> Categorize<T>(this IEnumerable<T> sourcelist)
    {
      Dictionary<T, int> result = new Dictionary<T, int>(); //create dictionary
      foreach (T i in sourcelist)
      {
        if (result.ContainsKey(i))
        {
          result[i]++; //increment value if key is found
        }
        else
          result.Add(i, 1); //add key to dictionary if it doesnt exist yet
      }
      //order dictionary by key and return
      return result.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

    }

    public static T Rando<T>(this IEnumerable<T> sourceCollection)
    {
      //check for empty collection and throw
      if (sourceCollection.Count() == 0)
        throw new ArgumentException($"Source: {nameof(sourceCollection)} is empty");
      //return random element from collection
      return sourceCollection.ElementAt(rand.Next(0, sourceCollection.Count()));
    }

    public static (key, val) Rando<key, val>(this Dictionary<key, val> sourceCollection)
    {
      //throw if dictionary is empty
      if (sourceCollection.Count() == 0)
        throw new ArgumentException($"Source: {nameof(sourceCollection)} is empty");
      //extract random key value pair from dictionary and return tuple
      KeyValuePair<key, val> kvp = sourceCollection.ElementAt(rand.Next(0, sourceCollection.Count()));
      return (kvp.Key, kvp.Value);
    }

    public static T AdjacentDuplicate<T>(this IEnumerable<T> sourceCollection)
    {
      //check for empty collection and throw
      if (sourceCollection.Count() == 0)
        throw new ArgumentException($"Source: {nameof(sourceCollection)} is empty");
      //iterate through collection and check if next element is Equal
      //return first element of adjacent pair if found
      for (int i = 0; i < sourceCollection.Count() - 1; i++)
      {
        if (sourceCollection.ElementAt(i).Equals(sourceCollection.ElementAt(i + 1)))
        {
          return sourceCollection.ElementAt(i);
        }
      }
      //return default of generic type if no adjacent pairs found
      return default;
    }

    public static LinkedList<T> ToOrderedLinkedList<T>(this IEnumerable<T> source) where T : IComparable<T>
    {
      //create new Linked List and populate with first item from collection
      LinkedList<T> list = new LinkedList<T>();
      foreach (T item in source)
      {
        if (list.Count == 0)
        {
          list.AddFirst(item);
        }
        else
        {
          //iterate through list for each item after first and insert before the first equal or larger value
          //if end of list is reached, add item to end
          LinkedListNode<T> current = list.First;
          while (current != null)
          {
            if (item.CompareTo(current.Value) <= 0)
            {
              list.AddBefore(current, item); break;
            }
            else if (current.Next != null)
            {
              current = current.Next;
            }
            else
            {
              list.AddLast(item); break;
            }
          }
        }
      }

      return list;
    }

  }
}
