using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufferingDemo
{
	public partial class Form1 : Form
	{
		private int _FrameCount = 0;
		private int _Rotation = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Text = $"Frame Number : {++_FrameCount}";

			int radius = 100;
			int iVertexCount = 3;

			double dangle = 0;
			List<PointF> pts = new List<PointF>();

			for(int i=0; i < iVertexCount; i++, dangle += (Math.PI*2)/iVertexCount)
			{
				pts.Add(new PointF((float)Math.Cos(dangle) * radius, (float)Math.Sin(dangle) * radius));
			}
			GraphicsPath gp = new GraphicsPath();
			gp.AddPolygon(pts.ToArray());
			gp.CloseAllFigures();

			using (BufferedGraphicsContext bgc = new BufferedGraphicsContext())
			{
				// bind a back-buffer to the primary surface, spec size to create as client size
				using (BufferedGraphics bg = bgc.Allocate(CreateGraphics(), this.DisplayRectangle))
				{
					// clear the back-buffer
					bg.Graphics.Clear(Color.Goldenrod);
					// draw whatever you need to draw
					//DrawJunk(bg.Graphics);
					//bg.Graphics.DrawLine(new Pen(Color.Red, 10), new Point(20, 20), new Point(200, 200));

					Matrix mat = new Matrix();
					mat.Translate(200, 200);
					mat.Rotate(++_Rotation);
					gp.Transform(mat);


					bg.Graphics.DrawPath(new Pen(Color.Red, 10), gp);

					// flip the back-buffer to the primary surface
					bg.Render();
				}
			}
		}
	}
}
