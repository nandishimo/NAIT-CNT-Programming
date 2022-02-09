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
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//create system stopwatch
        public Form1()
        {
            InitializeComponent();
            sw.Start();//initialise stopwatch
        }

        
        
        private void valueChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(value1Box.Text, out int value1) || !int.TryParse(value2Box.Text, out int value2))//check if textboxes have valid ints
            {
                resultsBox.Text = "0";//dispaly 0 if invalid entries
            }
            //if values are valid integers, check which radiobutton is checked and perform the correct math function
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
            this.Text = $"No of Milliseconds Elapsed: {sw.ElapsedMilliseconds}";//update form text when timer ticks
        }
    }
}
