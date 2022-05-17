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
using GDIDrawer;

namespace CMPE1666_LE3_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread drawThead = null;
        CDrawer window = new CDrawer();
        Random rand = new Random();
        List<Thread> thList = new List<Thread>();
        const int size = 20;
        bool threadStop = false;
        struct Shape
        {
            public int type;
            public Color color;
            public Shape(int Type, Color colour)
            {
                type = Type;
                color = colour;
            }
        }
        private void UI_BTN_Start_Click(object sender, EventArgs e)
        {
            threadStop = false;
            colorDialog1.ShowDialog();
            Shape newShape = new Shape(rand.Next(2), colorDialog1.Color);
            thList.Add(new Thread(new ParameterizedThreadStart(DrawShape)));
            thList.Last().IsBackground = true;
            thList.Last().Start(newShape);
        }
        private void DrawShape(object objData)
        {
            if (objData is Shape)
            {
                Shape shape = (Shape)objData;
                if (shape.type == 0)
                {
                    window.AddCenteredEllipse(rand.Next(800), rand.Next(600), size, size, shape.color);
                }
                else
                {
                    window.AddCenteredRectangle(rand.Next(800), rand.Next(600), size, size, shape.color);
                }
            }
            Thread.Sleep(200);
            DrawShape(objData);
        }

        private void UI_BTN_Stop_Click(object sender, EventArgs e)
        {
            foreach(Thread th in thList)
            {
                th.Abort();
            }
        }
    }
}
