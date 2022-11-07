using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Trace;
using System.IO;

namespace nandish_ICA10
{
  public partial class Form1 : Form
  {
    Dictionary<byte, int> values = new Dictionary<byte, int>();
    int avgFrequency;
    public Form1()
    {
      InitializeComponent();
      Text = "ICA10 - Dictionaries";
      _dgv.DataSource = null;// _bSource.DataSource;
      _lbl_FileName.AllowDrop = true;
      _lbl_FileName.DragEnter += _lbl_FileName_DragEnter;
      _lbl_FileName.DragDrop += _lbl_FileName_DragDrop;
      _btn_Average.Click += _btn_Average_Click;
      _dgv.ColumnHeaderMouseClick += _dgv_ColumnHeaderMouseClick;
      _dgv.CellFormatting += _dgv_CellFormatting;
      _dgv.RowHeadersVisible = false;
    }

    private void _lbl_FileName_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;  
    }

    private void _dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      
      if(e.ColumnIndex == 1)
      {
        if ((int)e.Value < avgFrequency)
        {
          e.CellStyle.BackColor = Color.LightSalmon; //low fequency cells are salmon
        }
        else
        {
          e.CellStyle.BackColor = Color.LightGreen; //high frequency cells are green
        }
      }
    }

    private void _dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if(e.ColumnIndex == 0)
      { //sort by byte key
        values = values.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
      }
      else
      { //sort keys within freq values
        List<KeyValuePair<byte, int>> kvp = values.ToList(); //create list and do 2-tier sort
        kvp.Sort((left, right) => 
        {
          int result = left.Value.CompareTo(right.Value); 
          if(result == 0)
          {
            result = left.Key.CompareTo(right.Key);
          }
          return result;
        });
        values = kvp.ToDictionary(x => x.Key, x => x.Value);
      }
      ShowDictionary();
    }

    private void _btn_Average_Click(object sender, EventArgs e)
    { //filter dictionay. keep only values greater than average
      values = values.Where(x => x.Value > avgFrequency).ToDictionary(x=>x.Key,x=>x.Value);
      ShowDictionary();
    }

    private void _lbl_FileName_DragDrop(object sender, DragEventArgs e)
    {
      //check if file has been dropped
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      //get list of files
      string[] files = (string[])e.Data.GetData(DataFormats.FileDrop,false);
      //only continue if single file dropped
      if (files.Length != 1)
        return;
      LoadFile(new FileInfo(files[0]));

    }
    private void ShowDictionary()
    {
      if(values.Count==0) return;
      avgFrequency = (int)values.Average(x=>x.Value);
      _btn_Average.Text = "Average : " + avgFrequency.ToString();
      //_bSource.DataSource = values.ToList();
      _dgv.DataSource = values.ToList();
      _dgv.Columns[0].HeaderText = "Key";
      _dgv.Columns[1].HeaderText = "Value";
      _dgv.Columns[0].DefaultCellStyle.Format = "X2";
    }
    private void LoadFile(FileInfo file)
    {
      _lbl_FileName.Text = file.Name; //display filename
      values.Clear(); //clear dictionary
      byte[] contents = null;
      try
      {
        contents = File.ReadAllBytes(file.ToString()); //new byte contents
      }
      catch (Exception ex)
      {
        WriteLine(ex.ToString());
      }
      
      foreach(byte b in contents)
      { //construct dictionary (shows frequency of byte values from file)
        if (values.ContainsKey(b))
        {
          values[b]++;
        }
        else
        {
          values.Add(b, 1);
        }
      }
      ShowDictionary();

    }
  }
}
