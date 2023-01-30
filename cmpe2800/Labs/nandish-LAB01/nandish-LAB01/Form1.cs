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
    const int _ciBlockSize = 10;
    const int _ciBlocksX = 10;
    const int _ciBlocksY = 10;
    const int _ciWindowXSize = 500;
    const int _ciWindowYSize = 500;
    CDrawer _drawer = null;
    GridManager _gridManager = null;

    public Form1()
    {
      InitializeComponent();
    }
  }
}
