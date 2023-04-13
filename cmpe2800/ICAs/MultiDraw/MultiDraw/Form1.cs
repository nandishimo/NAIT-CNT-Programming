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
using JSONSuperSockect;
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
			LineSegment seg = new LineSegment();
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
					//	Pen RedPen = new Pen(Color.Red, 10);
					//	RedPen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
					//	gr.DrawLine(RedPen, lastPosition, mPosition);
					LineSegment seg = new LineSegment();
					seg.SX = (Int16)lastPosition.X;
					seg.SY = (Int16)lastPosition.Y;
					seg.EX = (Int16)mPosition.X;
					seg.EY = (Int16)mPosition.X;
					seg.C = Color.Red;
					seg.T = 10;
					seg.Render(gr);


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

		private void Form1_Load(object sender, EventArgs e)
		{
			ConnectDialog connectDialog = new ConnectDialog();
			if(connectDialog.ShowDialog() == DialogResult.OK)
			{
				_sock = new SuperSocket(connectDialog.Socket, StatusUpdate, DrawSegment);
			}
		}
		// the JSON serialized version of this type must *not* contain any additional curly braces.
		public class LineSegment
		{
			// start position
			public Int16 SX { get; set; }
			public Int16 SY { get; set; }
			// end position
			public Int16 EX { get; set; }
			public Int16 EY { get; set; }
			// colour
			public Color C { get; set; }
			// line thickness
			public byte T { get; set; }

			public void Render(Graphics gr)
			{
				using (Pen p = new Pen(C, T))
				{
					p.SetLineCap(
					System.Drawing.Drawing2D.LineCap.Round,
				   System.Drawing.Drawing2D.LineCap.Round,
				   System.Drawing.Drawing2D.DashCap.Round);
					gr.DrawLine(p, new PointF(SX, SY), new PointF(EX, EY));
				}
			}
			// turn me (this) into a byte array via JSON
			 public byte[] ToBytes()
			{
				try
				{
					string s = JsonConvert.SerializeObject(this);
					//Console.WriteLine (s);
					return Encoding.UTF8.GetBytes(s);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
				return null;
			}
			// turn a JSON string into a LineSegment, with sanity test
			public static LineSegment JSONToLineSegment(string json)
			{
				try
				{
					LineSegment seg = JsonConvert.DeserializeObject<LineSegment>(json);
					if (seg != null)
						if (IsSane(seg))
							return seg;
				}
				catch (Exception err)
				{
					Console.WriteLine(err.Message);
				}
				return null;
			}
			// approximate sanity checking to ensure that what was
			// JSON decoded has valid(ish) data
			public static bool IsSane(LineSegment ls)
			{
				if (ls == null)
					return false;
				if (ls.SX > 10000)
					return false;
				if (ls.SY > 10000)
					return false;
				if (ls.EX > 10000)
					return false;
				if (ls.EY > 10000)
					return false;
				if (ls.SX < -10000)
					return false;
				if (ls.SY < -10000)
					return false;
				if (ls.EX < -10000)
					return false;
				if (ls.EY < -10000)
					return false;
				if (ls.T == 0)
					return false;
				return true;
			}
		}
	}
}
