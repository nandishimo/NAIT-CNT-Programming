using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace nandish_LAB01
{
  public partial class Form1 : Form
  {
    const int _ciBlockSize = 50;
    //const int _ciBlocksX = 10;
    //const int _ciBlocksY = 10;
    const int _ciWindowXSize = 500;
    const int _ciWindowYSize = 500;
    CDrawer _drawer = null;
    GridManager _gridManager = null;

    Timer _ticker = new Timer();

    public Form1()
    {
      InitializeComponent();
      _drawer = new CDrawer(_ciWindowXSize, _ciWindowYSize, false);
      _gridManager = new GridManager(_ciWindowXSize, _ciWindowYSize);
      KeyPreview = true;
      _ticker.Tick += _ticker_Tick;
      _drawer.MouseLeftClick += _drawer_MouseLeftClick;
      _drawer.MouseRightClick += _drawer_MouseRightClick;
    }

    private void _drawer_MouseRightClick(Point pos, CDrawer dr)
    {
      //check if shift is pressed

      //if so, try to add a solid block(non-falling)

      //if not, try to kill a block in the clicked cell
    }

    private void _drawer_MouseLeftClick(Point pos, CDrawer dr)
    {
      //try to add a falling block in the clicked cell
      _gridManager.AddFreeBlock(pos);
    }

    private void _ticker_Tick(object sender, EventArgs e)
    {
      //tick the gridmanager's logic

      //render blocks where the grtidmanager says they are and based on each block's properties/state


    }
    private void Render()
    {
      //render blocks where the grtidmanager says they are and based on each block's properties/state
      //_drawer.AddRectangle(block.Location.X, block.Location.Y, 50, 50);

    }
  }
}
