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

namespace ICA14
{
    delegate void delvoidvoid();
    delegate void delvoidstring(string s);
    public partial class Form1 : Form
    {
        //delvoidvoid _delColorAnalyzer = null;
        //Thread th1 = null;
        List<Thread> thList = new List<Thread>();
        List<string> pictures = null;
        struct PictureBM
        {
            public Bitmap bitmap;
            public string file;

            public PictureBM(Bitmap bm, string fname)
            {
                bitmap = bm;
                file = fname;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_btn_Go_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                timer1.Enabled=true;
                Invoke(new delvoidstring(PushItemToTextBox),"Starting...");
                pictures = new List<string>(openFileDialog1.FileNames);
                foreach (string fname in pictures)
                {
                    Bitmap bm = (Bitmap)Bitmap.FromFile(fname);
                    thList.Add(new Thread(new ParameterizedThreadStart(AnalyzeColour)));
                    thList.Last().IsBackground = true;
                    thList.Last().Start(new PictureBM(bm,fname));
                }
            }
        }
        private bool CheckThreadDone()
        {
            bool threadDone = true;
            foreach(Thread th in thList)
            {
                if(th.ThreadState==ThreadState.Background)
                    threadDone = false;
            }
            return threadDone;
        }
        private void AnalyzeAllPictures()
        {
            foreach (string fname in pictures)
            {
                Bitmap bm = (Bitmap)Bitmap.FromFile(fname);
                AnalyzeColour(bm);
            }
        }

        public void AnalyzeColour(object objData)
        {
            int red=0;
            int green=0;
            int blue=0;
            string fname = "";
            if(objData is PictureBM)
            {
                PictureBM bm = (PictureBM)objData;
                fname = bm.file;
                for (int i = 0; i < bm.bitmap.Width; i++)
                {
                    for (int j = 0; j < bm.bitmap.Height; j++)
                    {
                        red += bm.bitmap.GetPixel(i, j).R;
                        green += bm.bitmap.GetPixel(i, j).G;
                        blue += bm.bitmap.GetPixel(i, j).B;
                    }
                }
            }
            int sum = red + green + blue;
            float rpercent = (float)red / sum;
            float gpercent = (float)green / sum;
            float bpercent = (float)blue / sum;
            Invoke(new delvoidstring(PushItemToTextBox), $"(R:{100 * rpercent:F1}%, G:{100 * gpercent:F1}%, B:{100 * bpercent:F1}%):{fname}");
        }
        private void PushItemToTextBox(string s)
        {
            UI_lb_Text.Items.Add(s);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckThreadDone())
            {
                Invoke(new delvoidstring(PushItemToTextBox), "Done!");
                timer1.Stop();
            }
        }
    }
}
