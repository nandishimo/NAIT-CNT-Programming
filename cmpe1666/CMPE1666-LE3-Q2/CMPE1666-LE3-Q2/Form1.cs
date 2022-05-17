using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CMPE1666_LE3_Q2
{
    delegate void delvoidint(int x);
    delegate void delvoidvoid();
    public partial class Form1 : Form
    {
        Thread th1 = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_BTN_Start_Click(object sender, EventArgs e)
        {
            UI_BTN_Start.Enabled = false;
            th1 = new Thread(new ParameterizedThreadStart(Count));
            th1.Start(UI_Track_MaxCount.Value);
        }
        private void Count(object objData)
        {
            int max = 0;
            if (objData is int)
            {
                int i = 0;
                max = (int)objData;
                for (i = 1; i < max; i++)
                {
                    Invoke(new delvoidint(PushCountToLabel), i);
                    Thread.Sleep(500);
                }
                Invoke(new delvoidint(PushCountToLabel), i);
            }
            Invoke(new delvoidvoid(EnableStart));

        }
        private void PushCountToLabel(int count)
        {
            UI_LBL_Count.Text = count.ToString();
        }
        private void EnableStart()
        {
            UI_BTN_Start.Enabled = true;
        }

        private void UI_BTN_Stop_Click(object sender, EventArgs e)
        {
            if (th1.IsAlive)
            {
                th1.Abort();
                Invoke(new delvoidvoid(EnableStart));

            }
        }
    }
}
