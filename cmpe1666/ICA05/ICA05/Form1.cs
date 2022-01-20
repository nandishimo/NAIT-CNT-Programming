using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double m2k = 1.60934;
        const double k2m = 0.621371;
        private void val_Changed(object sender, EventArgs e)
        {
            conversion();
        }

        private void conversion()
        {
            double value, rate;
            if (mphButton.Checked)
                rate = m2k;
            else
                rate = k2m;
            if (!double.TryParse(textBox1.Text, out value))
                textBox2.Text = "Please enter a valid Input Speed.";
            //if (textbox1.text != "")
            //    messagebox.show("please enter a valid number.", "error: invalid input");
            else
                textBox2.Text = $"{rate * value:F}";

        }
    }
}
