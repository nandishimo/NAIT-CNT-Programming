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

namespace ICA16
{
    public partial class Form1 : Form
    {
        Queue<Point> pointQueue = new Queue<Point>();
        CDrawer window = new CDrawer();
        Thread renderThread = null;
        public Form1()
        {
            InitializeComponent();
            window.MouseMove += new GDIDrawerMouseEvent(MouseMove);
            
        }

        private void MouseMove(Point pos, CDrawer window)
        {
            pointQueue.Enqueue(pos);
            if (renderThread == null)
            {
                Thread renderThread = new Thread(RenderLines);
                renderThread.IsBackground = true;
                renderThread.Start();
            }
        }
        private void RenderLines()
        {
            Point prev = new Point(-1, -1);
            Point next = new Point(-1, -1);
            while(pointQueue.Count > 2)
            {
                if (next.X == -1)
                {
                    prev = pointQueue.Dequeue();
                    next = pointQueue.Dequeue();
                }
                else
                {
                    prev = next;
                    next = pointQueue.Dequeue();
                }
                window.AddLine(prev.X, prev.Y, next.X, next.Y, Color.White);
                Thread.Sleep(50);
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UI_TB_Queue.Text = $"{pointQueue.Count} segs in queue. Estimated time to draw: ";
        }
    }
}
