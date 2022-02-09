using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExam1Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void valueChanged(object sender, EventArgs e)
        {
            int.TryParse(value1Box.Text, out int value1);
            int.TryParse(value2Box.Text, out int value2);
            if (multiplyRB.Checked)
            {
                resultsBox.Text = $"{value1 * value2}";
            }
            else if (addRB.Checked)
            {
                resultsBox.Text = $"{value1 + value2}";
            }
            else
            {
                resultsBox.Text = $"{value1 - value2}";
            }
        }
    }
}
