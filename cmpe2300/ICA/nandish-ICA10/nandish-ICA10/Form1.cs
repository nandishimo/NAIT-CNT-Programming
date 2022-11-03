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
      _dgv.DataSource = null;// _bSource.DataSource;
      _lbl_FileName.AllowDrop = true;
      _lbl_FileName.DragEnter += _lbl_FileName_DragEnter;
      _lbl_FileName.DragDrop += _lbl_FileName_DragDrop;
      _btn_Average.Click += _btn_Average_Click;
      _dgv.ColumnHeaderMouseClick += _dgv_ColumnHeaderMouseClick;
      _dgv.CellFormatting += _dgv_CellFormatting;
    }

    private void _lbl_FileName_DragEnter(object sender, DragEventArgs e)
    {
      Text = "DragEnter";
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;  
    }

    private void _dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if(e.ColumnIndex == 1)
      {
        if ((int)e.Value < avgFrequency)
        {
          e.CellStyle.BackColor = Color.LightSalmon;
        }
        else
        {
          e.CellStyle.BackColor = Color.LightGreen;
        }
      }
    }

    private void _dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      throw new NotImplementedException();
    }

    private void _btn_Average_Click(object sender, EventArgs e)
    {
      throw new NotImplementedException();
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
      _lbl_FileName.Text = file.Name;
      values.Clear();
      byte[] contents = File.ReadAllBytes(file.ToString());
      WriteLine(file.ToString());
      foreach(byte b in contents)
      {
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
