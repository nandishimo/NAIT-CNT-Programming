using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MultiDraw
{
	public partial class Form1 : Form
	{
		Point lastPosition = new Point(0, 0);
		public Form1()
		{
			InitializeComponent();
			Shown += Form1_Shown;
			MouseMove += Form1_MouseMove;
			MouseDown += Form1_MouseDown;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			using (Graphics gr = CreateGraphics())
			{
				Brush pBrush = Brushes.Red;
				gr.FillRectangle(pBrush, e.X, e.Y, 1, 1);
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			Point mPosition = new Point(e.X, e.Y);
			if (e.Button == MouseButtons.Left)
			{
				using (Graphics gr = CreateGraphics())
				{
					Pen RedPen = new Pen(Color.Red, 10);
					RedPen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
					gr.DrawLine(RedPen, lastPosition, mPosition);
				}
			}
			lastPosition = mPosition;
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			
			using (Graphics gr = CreateGraphics())
			{
				Pen BluePen = new Pen(Color.Blue);
				/*
				for(int i = 255; i>=0; --i)
				{
					BluePen.Color = Color.FromArgb(0, 0, i);
					gr.DrawLine(BluePen, new Point(20 + i, 20), new Point(20 + i, 250));
				}
				*/
				for (int y = 0; y < ClientRectangle.Height; y += 10)
				{
					gr.DrawLine(BluePen, new Point(0, y), new Point(y, ClientRectangle.Height));
				}
				for (int y = 0; y < ClientRectangle.Height; y += 10)
				{
					gr.DrawLine(BluePen, new Point(y, 0), new Point(ClientRectangle.Height, y));
				}
			}
		}
	}
}
