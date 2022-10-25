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
    List<Block> blocks = new List<Block>();//new list for blocks
    public Form1()
    {
      InitializeComponent();
      Text = "ICA07";
      _btnLong.Text = $"Longer than {_tBar.Value}";//set initial filter button text
      //set start position for form and window
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
      Block.Drawer.Position = new Point(Location.X + Width,Location.Y);
      Block.Drawer.MouseMove += Drawer_MouseMove;
    }

    private void Drawer_MouseMove(Point pos, GDIDrawer.CDrawer dr)
    { //choose width of blocks to highlight based on horiontal mouse position
      int HighLightWidth = pos.X/4-5; 
      blocks.ForEach(block => block.HighLight = false);
      blocks.FindAll(block => Math.Abs(HighLightWidth-block.Width)<=10).ForEach(block => block.HighLight = true);
      ShowBlocks();
    }

    public void ShowBlocks()
    { //render blocks in a row until the reach the end, then go to beginning of next line
      Point blockPoint = new Point(0, 0);
      Block.Drawer.Clear();
      foreach (Block block in blocks)
      {
        if(blockPoint.X+block.Width > Block.Drawer.ScaledWidth-10)
        {
          blockPoint.Y += Block.Height;
          blockPoint.X = 0;
        }
        block.ShowBlock(blockPoint); //add block to drawer
        blockPoint.X += block.Width; //set position of next block 
        
      }
      Block.Drawer.Render();
    }
    private void trackBar1_Scroll(object sender, EventArgs e)
    { //update button text
      _btnLong.Text = $"Longer than {_tBar.Value}";
    }

    private void _btnLong_Click(object sender, EventArgs e)
    { //remove blocks longer than selected trackbar value, count and display removed blocks
      int initialCount = blocks.Count;
      blocks.RemoveAll(block=>block.Width>_tBar.Value);
      ShowBlocks();
      UpdateTrackBar();
      Text = $"Removed {initialCount-blocks.Count} blocks";
    }

    private void _btnBright_Click(object sender, EventArgs e)
    { //remove blocks with brightness>0.7, count and display removed blocks
      int initialCount = blocks.Count;
      blocks.RemoveAll(Block.IsBright);
      ShowBlocks();
      UpdateTrackBar();
      Text = $"Removed {initialCount - blocks.Count} blocks";
    }

    private void _btnWColor_Click(object sender, EventArgs e)
    { //sort by color within width
      blocks.Sort(Block.CompareColorWithinWidth);
      ShowBlocks();
    }

    private void _btnWDesc_Click(object sender, EventArgs e)
    { //sort by width descending
      blocks.Sort((left, right) => left.Width.CompareTo(right.Width)*-1);
      ShowBlocks();
    }

    private void _btnWidth_Click(object sender, EventArgs e)
    { //sort by width ascending
      blocks.Sort((left, right)=>left.Width.CompareTo(right.Width));
      ShowBlocks();
    }

    private void _btnColor_Click(object sender, EventArgs e)
    { //sort by color
      blocks.Sort();
      ShowBlocks();
    }

    private void _btnPopulate_Click(object sender, EventArgs e)
    { //render blocks until 85% of drawer window is filled
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
    { //update minimum and maximum trackbar values to match min and max widths of blocks in list
      _tBar.Minimum = blocks.Min(block => block.Width);
      _tBar.Maximum = blocks.Max(block => block.Width);
    }
  }
}
