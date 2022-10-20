/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A07
***********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nandish_ICA07
{
  public partial class Form1 : Form
  {
    List<Block> blocks = new List<Block>();
    
    
    public Form1()
    {
      InitializeComponent();
      Text = "ICA07";
      _btnLong.Text = $"Longer than {_tBar.Value}";
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
      Block.Drawer.Position = new Point(Location.X + Width,Location.Y);
      Block.Drawer.MouseMove += Drawer_MouseMove;
    }

    private void Drawer_MouseMove(Point pos, GDIDrawer.CDrawer dr)
    {
      int HighLightWidth = pos.X;
      blocks.ForEach(block => block.HighLight = false);
      blocks.FindAll(block => Math.Abs(HighLightWidth-block.Width)<=10).ForEach(block => block.HighLight = true);
      ShowBlocks();
    }

    public void ShowBlocks()
    {
      Point blockPoint = new Point(0, 0);
      Block.Drawer.Clear();
      foreach (Block block in blocks)
      {
        if(blockPoint.X+block.Width > Block.Drawer.ScaledWidth-10)
        {
          blockPoint.Y += Block.Height;
          blockPoint.X = 0;
        }
        block.ShowBlock(blockPoint);
        blockPoint.X += block.Width;
        
      }
      Block.Drawer.Render();
    }
    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      _btnLong.Text = $"Longer than {_tBar.Value}";
    }

    private void _btnLong_Click(object sender, EventArgs e)
    {
      blocks.RemoveAll(block=>block.Width>_tBar.Value);
      ShowBlocks();
      UpdateTrackBar();
    }

    private void _btnBright_Click(object sender, EventArgs e)
    {
      blocks.RemoveAll(Block.IsBright);
      ShowBlocks();
      UpdateTrackBar();
    }

    private void _btnWColor_Click(object sender, EventArgs e)
    {
      blocks.Sort(Block.CompareColorWithinWidth);
      ShowBlocks();
    }

    private void _btnWDesc_Click(object sender, EventArgs e)
    {
      blocks.Sort((left, right) => left.Width.CompareTo(right.Width)*-1);
      ShowBlocks();
    }

    private void _btnWidth_Click(object sender, EventArgs e)
    {
      blocks.Sort((left, right)=>left.Width.CompareTo(right.Width));
      ShowBlocks();
    }

    private void _btnColor_Click(object sender, EventArgs e)
    {
      blocks.Sort();
      ShowBlocks();
    }

    private void _btnPopulate_Click(object sender, EventArgs e)
    {
      blocks.Clear();
      int areaSum = 0;
      while (areaSum < 0.85*Block.Drawer.ScaledWidth * Block.Drawer.ScaledHeight)
      {
        Block newblock = new Block();
        if (!blocks.Contains(newblock))
        {
          blocks.Add(newblock);
          areaSum += newblock.Width * Block.Height;
          ShowBlocks();
        }
      }
      UpdateTrackBar();
      
    }
    private void UpdateTrackBar()
    {
      _tBar.Minimum = blocks.Min(block => block.Width);
      _tBar.Maximum = blocks.Max(block => block.Width);
    }
  }
}
