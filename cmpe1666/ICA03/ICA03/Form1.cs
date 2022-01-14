using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA03
{
    public partial class Form1 : Form
    {
        public Form1() //constructor for class Form1
        {
            InitializeComponent();
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} Constructor");
            //write message to output on event
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} Activated");
            //write message to output on event
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} Shown");
            //write message to output on event
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} Closing");
            //write message to output on event
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} Closed");
            //write message to output on event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} Load");
            //write message to output on event
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} Paint");
            //write message to output on event
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine($"{DateTime.Now} Deactivated");
            //write message to output on event
        }
    }

    
}
