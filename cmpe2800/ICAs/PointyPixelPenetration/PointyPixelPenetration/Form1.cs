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

namespace PointyPixelPenetration
{
	public partial class Form1 : Form
	{
		List<ShapeBase> shapes = new List<ShapeBase>();
		List<Region> intersections = new List<Region>();
		public Form1()
		{
			InitializeComponent();
			Text = "Pointy Pixel Penetration";
			BackColor = Color.Black;
			MouseDown += Form1_MouseDown;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				//check if shift is pressed
				if(Control.ModifierKeys==Keys.Shift)
				{
					//draw a triangle at mouse location

				}
				else if(Control.ModifierKeys==Keys.Control)
				{
					//clear all collections

				}
				else
				{
					//add 1000 triangles at random locations

				}
			}
			if (e.Button == MouseButtons.Right)
			{
				//check if shift is pressed
				if (Control.ModifierKeys == Keys.Shift)
				{
					//draw a rock at mouse location

				}
				else
				{
					//add 1000 rocks at random locations

				}
			}
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			using (Graphics gr = CreateGraphics())
			{
				gr.Clear(Color.Black);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//clear back buffer
			using (Graphics g = CreateGraphics())
				g.Clear(BackColor);
			//render all previous intersections

			//tick and render the shapes
			foreach(var shape in shapes)
			{
				shape.Tick(new Point(Width, Height));
				shape.Render();
			}
			//check for intersections, mark intersection shapes for removal

			//removeall shapes that have been marked (use lambda)

			//display current number of shapes and shape 'size'


		}
	}
}
