﻿using System;
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
		public Form1()
		{
			InitializeComponent();
			Text = "Pointy Pixel Penetration";
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			using (Graphics gr = CreateGraphics())
			{
				gr.Clear(Color.Black);
			}
		}
	}
}
