/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A02
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
using GDIDrawer;

namespace nandish_ica02
{
  public partial class Form1 : Form
  {
    CDrawer window = null;
    public Form1()
    {
      InitializeComponent();
      this.Text = "ICA02 - Bouncing Balls";
      window = new CDrawer();
    }


  }
}
