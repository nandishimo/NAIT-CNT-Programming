using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();
        private void generateButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numValBox.Text, out int num);
            int.TryParse(minValBox.Text, out int min);
            int.TryParse(min)
            generateList(out list, num, min, max);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {

        }
    }
}
