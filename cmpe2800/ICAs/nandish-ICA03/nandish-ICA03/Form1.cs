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

    private void Form1_DragDrop(object sender, DragEventArgs e)
    {
      var fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
      var sr = new StreamReader(fname);
      var contents = sr.ReadToEnd();
      sr.Close();
      var sw = new StreamWriter("output.txt");
      var strings = contents.Split('\n').ToList();
      strings.RemoveAll(s => s == " ");

    }

    private void Form1_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy;
      else
        e.Effect = DragDropEffects.None;
    }

  }
}
