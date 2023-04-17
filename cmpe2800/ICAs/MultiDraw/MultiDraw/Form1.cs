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
//using JSONSuperSockect;
using SocketICA;
using Newtonsoft.Json;
using static System.Diagnostics.Trace;

namespace MultiDraw
{
	public partial class Form1 : Form
	{
		Point lastPosition = new Point(0, 0);
		SuperSocket _sock = null;
		
		public Form1()
		{
			InitializeComponent();
			Shown += Form1_Shown;
			MouseMove += Form1_MouseMove;
			MouseDown += Form1_MouseDown;
		}
		private void Form1_Load(object sender, EventArgs e)
		{

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
				LineSegment seg = new LineSegment();
				seg.SX = (Int16)lastPosition.X;
				seg.SY = (Int16)lastPosition.Y;
				seg.EX = (Int16)mPosition.X;
				seg.EY = (Int16)mPosition.Y;
				seg.C = Color.Red;
				seg.T = 10;
				_sock.SendData(JsonConvert.SerializeObject(seg));

				using(Graphics gr = CreateGraphics())
				{
					//	Pen RedPen = new Pen(Color.Red, 10);
					//	RedPen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
					//	gr.DrawLine(RedPen, lastPosition, mPosition);
					//seg.Render(gr);
				}
					

			}
			lastPosition = mPosition;
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			/*
			using (Graphics gr = CreateGraphics())
			{
				Pen BluePen = new Pen(Color.Blue);
				for (int y = 0; y < ClientRectangle.Height; y += 10)
				{
					gr.DrawLine(BluePen, new Point(0, y), new Point(y, ClientRectangle.Height));
				}
				for (int y = 0; y < ClientRectangle.Height; y += 10)
				{
					gr.DrawLine(BluePen, new Point(y, 0), new Point(ClientRectangle.Height, y));
				}
			}
			*/
		}
		private void StatusUpdate(string str)
		{
			try
			{
				Invoke(new Action(() =>
				{
					Text = str;
				}));
			}
			catch
			{
				WriteLine("Error updating status text");
			}
		}

		private void DrawSegment(string json)
		{
			LineSegment seg = LineSegment.JSONToLineSegment(json);
			if(LineSegment.IsSane(seg))
			{
				using (Graphics gr = CreateGraphics())
				{
					seg.Render(gr);
				}
			}

		}

		private void UI_btn_Connect_Click(object sender, EventArgs e)
		{
			ConnectDialog connectDialog = new ConnectDialog();
			if (connectDialog.ShowDialog() == DialogResult.OK)
			{
				_sock = new SuperSocket(connectDialog.Socket, StatusUpdate, DrawSegment);
			}
		}
	}
}
