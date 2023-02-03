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
    const int _ciBlockSize = 200; //size in pixels
    //const int _ciBlocksX = 10;
    //const int _ciBlocksY = 10;
    const int _ciWindowXSize = 1000; //width of drawer window in pixels
    const int _ciWindowYSize = 1000; //height of drawer window in pixels
    CDrawer _drawer = null; //drawer field
    GridManager _gridManager = null; //gridmanager field

    Timer _ticker = new Timer(); //create timer instance

    public Form1()
    {
      InitializeComponent();
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0); //move form to top left
      _drawer = new CDrawer(_ciWindowXSize, _ciWindowYSize, false); //instantiate drawer with specified size
      _drawer.Position = new Point(Location.X + Width, Location.Y); //move drawer next to form
      _gridManager = new GridManager(_ciWindowYSize, _ciBlockSize); //instantiate gridmanager with window size and block size

      //create timer tick event and start timer with 10ms interval
      _ticker.Tick += _ticker_Tick; 
      _ticker.Interval = 5;
      _ticker.Start();
      //subscribe to drawer click events
      _drawer.MouseLeftClick += _drawer_MouseLeftClick;
      _drawer.MouseRightClick += _drawer_MouseRightClick;
    }

    private void _drawer_MouseRightClick(Point pos, CDrawer dr)
    {
      //check if shift is pressed
      if (Control.ModifierKeys == Keys.Shift)
      {
        _gridManager.AddSolidBlock(pos); //if so, try to add a solid block(non-falling)
      }
      else
      {
        _gridManager.KillBlock(pos); //if not, try to kill a block in the clicked cell
      }
    }

    private void _drawer_MouseLeftClick(Point pos, CDrawer dr)
    {
      //try to add a falling block in the clicked cell
      _gridManager.AddFreeBlock(pos);
    }

    private void _ticker_Tick(object sender, EventArgs e)
    {
      //tick the gridmanager's logic
      _gridManager.Tick();
      //render grid
      Render();
    }
    private void Render()
    {
      //render blocks where the grtidmanager says they are and based on each block's properties/state
      _gridManager.Render(_drawer); //pass drawer to gridmanger for rendering
    }
  }
}
