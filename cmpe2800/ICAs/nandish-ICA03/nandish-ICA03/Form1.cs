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
      /*
      var newDict = new Dictionary<char,int>();
      foreach(var str in strings)
      {
        newDict[str.First()]++;
      }
      newDict = newDict.OrderBy(kvp => kvp.Value).ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value);
      
      foreach (var kvp in newDict)
      {
          //sw.WriteLine($"Words starting with {kvp.Key} : {kvp.Value}");
      }

      */
      sw.Close();

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
