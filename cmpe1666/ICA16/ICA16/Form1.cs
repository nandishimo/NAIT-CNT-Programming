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
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            window.MouseMove += Window_MouseMove;
            window.MouseRightClick += Window_MouseRightClick;
            Thread renderThread = new Thread(RenderLines);
            renderThread.IsBackground = true;
            renderThread.Start();
        }

        private void Window_MouseRightClick(Point pos, CDrawer dr)
        {
            for(int i = 0; i < 250; i++)
            {
                pointQueue.Enqueue(pos);
                pointQueue.Enqueue(RandomRadial(pos));
            }
        }
        private Point RandomRadial(Point pos)
        {
            double angle = 2*Math.PI*rand.NextDouble();
            return new Point(pos.X + (int)(50 * Math.Cos(angle)), pos.Y+(int)(50 * Math.Sin(angle)));
        }

        private void Window_MouseMove(Point pos, CDrawer dr)
        {
            pointQueue.Enqueue(pos);
        }
        private void RenderLines()
        {
            
            Point prev = new Point(-1, -1);
            Point next = new Point(-1,-1);
            int count=0;
            try
            {
                count = (int)Invoke(new Func<int>(() => { return pointQueue.Count; }));
            }
            catch(Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.ToString());
            }
            while (count > 0)
            {
                sw.Restart();
                if (next == new Point(-1, -1))
                {
                    try 
                    {
                    prev = next = (Point)Invoke(new Func<Point>(() => { return pointQueue.Dequeue(); }));
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Trace.WriteLine(e.ToString());
                    }
                }
                else
                {
                    prev = next;
                    try
                    {
                        next = (Point)Invoke(new Func<Point>(() => { return pointQueue.Dequeue(); }));
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Trace.WriteLine(e.ToString());
                    }
                }
                window.AddLine(prev.X, prev.Y, next.X, next.Y, Color.White);
                try
                {
                    Invoke(new Action(() => { UI_TB_Queue.Text = $"{pointQueue.Count} segs in queue. Estimated time to draw: {(.05 * pointQueue.Count):F} seconds"; }));
                }
                catch (Exception e)
                {
                    System.Diagnostics.Trace.WriteLine(e.ToString());
                }
                
                while (sw.ElapsedMilliseconds < 50)
                {
                    Thread.Sleep(1);
                }

            }
            if (pointQueue.Count == 0)
            {
                Thread.Sleep(50);
                RenderLines();
            }
            
            
        }


    }
}
