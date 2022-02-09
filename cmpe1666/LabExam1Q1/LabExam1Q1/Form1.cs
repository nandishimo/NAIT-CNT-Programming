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
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public Form1()
        {
            InitializeComponent();
            sw.Start();
        }

        
        
        private void valueChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(value1Box.Text, out int value1) || !int.TryParse(value2Box.Text, out int value2))
            {
                resultsBox.Text = "0";
            }
            else if (multiplyRB.Checked)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            resultsBox.Text = $"No of Milliseconds Elapsed: {sw.ElapsedMilliseconds}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw.Start();
        }
    }
}
