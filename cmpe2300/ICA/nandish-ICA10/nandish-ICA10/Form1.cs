using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nandish_ICA10
{
  public partial class Form1 : Form
  {
    Dictionary<byte, int> values = new Dictionary<byte, int>();
    int avgFrequency;
    public Form1()
    {
      InitializeComponent();
      bindingSource1 = new BindingSource(_dgv.DataSource, _dgv.);
    }
  }
}
