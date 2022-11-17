using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nandish_ICA11
{
  public partial class Form1 : Form
  {
    private RectDrawer _rectcan = null; // Rectangle derived CDrawer
    private PosDrawer _poscan = null; // Positionable derived CDrawer
    private PicDrawer _piccan = null; // Grayscale Picture double derived CDrawer
    public Form1()
    {
      InitializeComponent();
      StartPosition = FormStartPosition.Manual;
      Location = new Point(0, 0);
      KeyDown += Form1_KeyDown;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      _poscan?.Close();
      _rectcan?.Close();
      _piccan?.Close();
      _poscan = null;
      _rectcan = null;
      _piccan = null;
      switch (e.KeyCode)
      {
        case Keys.E:
          _poscan = new PosDrawer(400, 200, this, PosDrawer.EPosition.eRight);
          break;
        case Keys.S:
          _poscan = new PosDrawer(200, 400, this, PosDrawer.EPosition.eBelow);
          break;
        case Keys.D:
          _poscan = new PosDrawer(400, 400, this, PosDrawer.EPosition.eBelowRight);
          break;
        case Keys.R:
          _rectcan = new RectDrawer();
          Activate(); // Steal focus back so keys continue to work
          break;
        case Keys.P:
          _piccan = new PicDrawer(this);
          break;
      }
    }
  }
}
