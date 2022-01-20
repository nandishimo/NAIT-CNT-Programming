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
        const double M2m = 0.44704; //constant for converting mph to MPS from google search feature
        const double k2m = 0.277778; //constant for converting kph to MPS from google search feature
        private void val_Changed(object sender, EventArgs e) //consolidate radio buttons and text change into one event
        {
            conversion();//helper method
        }

        private void conversion()
        {
            double value, rate;
            if (mphButton.Checked)
                rate = M2m;//if mph is the selected input (selected by default on form start)
            else
                rate = k2m;//if kph is the selected input
            if (!double.TryParse(textBox1.Text, out value))//if the entry in the input field is not a valid double, display an error message in the output
                textBox2.Text = "Please enter a valid Input Speed.";
            else
                textBox2.Text = $"{rate * value:F} metres per second";

        }
    }
}
