﻿/*************************************
 * Submission Code: 1222_2800_A02_A02
 * Nandish Patel
 * 2023/01/19
 * Main program and test code
 *************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      {
        Console.WriteLine("Corner test : \r\n");
        CGrid myTestGrid = new CGrid(10, 8);
        foreach ((int x, int y) q in myTestGrid)
          if (q.x != -1 && q.y != -1)
            Console.WriteLine($"Adjacent : {q.x}, {q.y}");
        Console.WriteLine("\r\nCorner test done\r\n\r\n");
      }
      {
        Console.WriteLine("Edge test : \r\n");
        CGrid myTestGrid = new CGrid(10, 8);
        myTestGrid.SetCursorPos(0, 4);
        foreach ((int x, int y) q in myTestGrid)
          if (q.x != -1 && q.y != -1)
            Console.WriteLine($"Adjacent : {q.x}, {q.y}");
        Console.WriteLine("\r\nEdge test done\r\n\r\n");
      }
      {
        Console.WriteLine("Open test : \r\n");
        CGrid myTestGrid = new CGrid(10, 8);
        myTestGrid.SetCursorPos(3, 5);
        foreach ((int x, int y) q in myTestGrid)
          if (q.x != -1 && q.y != -1)
            Console.WriteLine($"Adjacent : {q.x}, {q.y}");
        Console.WriteLine("\r\nOpen test done\r\n\r\n");
      }
      */

      Console.WriteLine("Test for shuffle.\nOriginal collection:");
      List<string> testCollection = new List<string>{ "Alice", "Bob", "Nando", "Stanley", "Yelnats" };
      foreach (var item in testCollection)
      { Console.Write(item.ToString() + ","); }
      Console.WriteLine("\n");

      List<string> shuffledCollection = testCollection.Shuffle().ToList();
      Console.WriteLine("Test for shuffle.\nShuffled collection:");
      foreach (var item in shuffledCollection)
      { Console.Write(item.ToString() + ","); }
      Console.WriteLine("\n");

      Console.WriteLine("Test for pullMin:");
      List<string> minCollection = shuffledCollection.PullMin().ToList();
      foreach (var item in minCollection)
      { Console.Write(item.ToString() + ","); }
      Console.WriteLine("\n");

      Console.WriteLine("Test for InRange (3 - 7) :");
      List<int> intCollection = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      foreach (var item in intCollection)
      { Console.Write(item.ToString() + ","); }
      Console.WriteLine("\n");
      foreach (int item in intCollection.InRange((3, 7)))
      {
        Console.Write(item.ToString() + ",");
      }
      Console.WriteLine("\n");

      Console.WriteLine("Test for Factors (482648264 :");
      ulong num = 482648264;
      foreach ( ulong factor in num.Factors())
      {
        Console.Write(factor.ToString() + ", ");
      }
      Console.WriteLine("\n");


      Console.WriteLine("Test for PasswordGenerator (30 passwords) :");
      foreach (string pw in PartB.Password().Take(30))
      {
        Console.Write(pw + " | ");
      }
      Console.WriteLine("\n");

    }
  }
}
