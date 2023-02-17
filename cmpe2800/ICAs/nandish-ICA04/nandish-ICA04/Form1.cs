﻿/* ICA04 - LINQ
 * Nandish Patel
 * 2023/02/13
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Trace;

namespace nandish_ICA04
{
	public partial class Form1 : Form
	{
		List<string> sourcestrings = new List<string>(new string[] { "Caballo", "Gato", "Perro", "Conejo", "Tortuga", "Cangrejo" });

		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (string s in from n in sourcestrings where n.Sum(c=>c) < 600 select n)
			{
				WriteLine(s);
			}
			foreach(var s in from n in sourcestrings where n.Sum(c=>c) < 600 select n)
			{
				WriteLine("Str = " + s.ToString() + ", Sum = " + s.Sum(c => c).ToString());
			}
			foreach (var s in from n in sourcestrings where n.Sum(c => c) < 600 select n)
			{
				WriteLine("Str = " + s.ToString() + ", Sum = " + s.Sum(c => c).ToString());
			}


		}
		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (string s in from n in sourcestrings where n.Sum(c=>c) < 600 select n)
			{
				WriteLine(s);
			}

		}
	}
}
