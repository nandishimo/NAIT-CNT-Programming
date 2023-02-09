﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace nandish_ICA03
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      Text = "ICA03";
      AllowDrop = true;
      DragEnter += Form1_DragEnter;
      DragDrop += Form1_DragDrop;
    }

    //handle a .txt file being dropped on the form
    private void Form1_DragDrop(object sender, DragEventArgs e)
    {
      var fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
      var sr = new StreamReader(fname);
      var contents = sr.ReadToEnd();
      sr.Close();
      var sw = new StreamWriter("output.txt", false);
      var strings = contents.Split('\n').ToList();
      for (int i = 0; i < strings.Count(); i++)
      {
        strings[i] = strings[i].Trim();
      }
      strings.RemoveAll(s => s == "");
      var dict =  strings.Categorize();
      foreach(var kvp in dict)
      {
        if(kvp.Value>1)
          sw.WriteLine($"Duplicate found : {kvp.Key}");
      }
      
      var newDict = new Dictionary<char,LinkedList<string>>();
      foreach (var kvp in dict)
      {
        var letter = kvp.Key.ToLower().First();
        LinkedList<string> newList = null;
        if (!newDict.ContainsKey(letter))
        {
          newList = new LinkedList<string>();
          newList.AddLast(kvp.Key);
          newDict.Add(letter, newList);
        }
        else
          newDict[letter].AddLast(kvp.Key);   
      }
      newDict = newDict.OrderByDescending(kvp => kvp.Value.Count).ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value);
      
      foreach (var kvp in newDict)
      {
          sw.WriteLine($"Words starting with {kvp.Key} : {kvp.Value.Count}");
      }
      sw.WriteLine($"There are a total of {newDict.Sum(kvp=>kvp.Value.Count)} words and {newDict.Count} categories.");
      int max = newDict.Max(kvp => kvp.Value.Max(x => x.Length));
      sw.WriteLine($"The longest word is {max} characters");
      /*
      foreach (var word in newDict.Values.Where(l=>l.max)
        sw.WriteLine($"Longest Words (tie for length): {word}");*/
      
      
      sw.Close();
      Process.Start("notepad.exe", "output.txt");
    }

    //change cursor when hovering over form while draggina an item
    private void Form1_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy;
      else
        e.Effect = DragDropEffects.None;
    }

  }
}
