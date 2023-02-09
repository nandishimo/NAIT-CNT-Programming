using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA03
{
  internal static class ExtensionMethods
  {
    static Random rand = new Random(); //create random member
    public static Dictionary<T, int> Categorize<T>(this IEnumerable<T> sourcelist) //where T is IComparable
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
      return default; //return new T() instead. compiler can give warning for ctor
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
