using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA04
{
    public partial class Form1 : Form
    {
        int count = 0; //for counting splits
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); //system stopwatch to be called to get time

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = getTime();//get time whenever form timer ticks

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            sw.Start(); //starts stopwatch

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            sw.Stop(); //stops stopwatch
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //resets stopwatch,clears splits, and clears listbox
            sw.Reset(); 
            count = 0;
            listBox1.Items.Clear();
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            //adds new split to the item box unless its a duplicate, also increments the split counter
            if (listBox1.Items.Contains(getTime()))
                return;
            count++;
            listBox1.Items.Add(getTime());
        }

        private string getTime()
        {
            //grabs current split count and stopwatch time hrs,mins,secs,ms with string format
            return string.Format("{0:(0)} {1:00}:{2:00}:{3:00}.{4:00}", count, sw.Elapsed.Hours, sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds / 10);
        }
    }
}
