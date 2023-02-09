/*************************************
 * Submission Code: 1222_2800_A02_A03
 * Nandish Patel
 * 2023/02/09
 *************************************/
using System;
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
      var fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First(); //get the first file incase multiple files are dropped at once 
      //read the contents of the file and create a list of words. filter out spaces and empty strings
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
      //count instances of each word to find duplicates. display dupes in output file
      var dict =  strings.Categorize();
      foreach(var kvp in dict)
      {
        if(kvp.Value>1)
          sw.WriteLine($"Duplicate found : {kvp.Key}");
      }
      
      //create a new dictionary and populate keys with lowercase of first letter of each word
      //add each word to the dictionary value under a linkedlist
      var newDict = new Dictionary<char,LinkedList<string>>();
      foreach (var kvp in dict)
      {
        var letter = kvp.Key.ToLower().First();//grabs first letter of word after converting to lowercase
        LinkedList<string> newList = null;
        if (!newDict.ContainsKey(letter)) //adds letter to dictionary if it doesnt exits. and creates a new linkedlist entry with the word
        {
          newList = new LinkedList<string>();
          newList.AddLast(kvp.Key);
          newDict.Add(letter, newList);
        }
        else //if the key exists, just add the word to the linkedlist
          newDict[letter].AddLast(kvp.Key);   
      }
      //order the dictionary by number of words for each letter descending and output to file
      newDict = newDict.OrderByDescending(kvp => kvp.Value.Count).ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value);
      
      foreach (var kvp in newDict)
      {
          sw.WriteLine($"Words starting with {kvp.Key} : {kvp.Value.Count}");
      }
      //count number of words and categories and output to file
      sw.WriteLine($"There are a total of {newDict.Sum(kvp=>kvp.Value.Count)} words and {newDict.Count} categories.");
      //find length of longest word(s) and output to file
      int max = newDict.Max(kvp => kvp.Value.Max(x => x.Length));
      sw.WriteLine($"The longest word is {max} characters");
      //find all words in dictionary that have length equal to longest words and display in output file
      foreach (var word in newDict.Values.SelectMany(l => l.Where(w => w.Length == max)))
        sw.WriteLine($"Longest Words (tie for length): {word}");
      
      //close streamreader and open output file
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
