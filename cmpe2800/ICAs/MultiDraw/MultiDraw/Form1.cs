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
		byte _thick = 5; //pen thickness
		string address = "bits.cnt.sast.ca"; //defaukt address
		int port = 1666; //default port
		Color penColor;
		
		public Form1()
		{
			InitializeComponent();
			Shown += Form1_Shown;
			MouseMove += Form1_MouseMove; //click events
			MouseDown += Form1_MouseDown; //mouse move events
			penColor = UI_lbl_Color.ForeColor; //set pen 
			Text = "Multi Draw";
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			UI_lbl_Thickness.MouseWheel += UI_lbl_Thickness_MouseWheel; //scroll event
		}

		private void UI_lbl_Thickness_MouseWheel(object sender, MouseEventArgs e)
		{
			//if scroll up, increase thickness. if scroll down, decrease thickness
			if (e.Delta > 0)
				_thick = (byte)Math.Min(_thick + 1, 100); //limit to 100
			else if(e.Delta < 0)
				_thick=(byte)Math.Max(_thick-1, 1); //limit to 1
			UI_lbl_Thickness.Text = $"Thickness: {_thick}";
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				using (Graphics gr = CreateGraphics())
					gr.Clear(BackColor); //clear form to default backcolor
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if(_sock == null) return; //check if we have a socket
			Point mPosition = new Point(e.X, e.Y); //grab mouse coordinates
			//if left mouse button is clicked, create line segment and have socket send it out
			if (e.Button == MouseButtons.Left)
			{
				LineSegment seg = new LineSegment();
				seg.SX = (Int16)lastPosition.X; //set starting x
				seg.SY = (Int16)lastPosition.Y; //set starting y
				seg.EX = (Int16)mPosition.X; //set ending x
				seg.EY = (Int16)mPosition.Y; //set ending y
				seg.C = penColor; //set pen color
				seg.T = _thick; //set pen thickness
				_sock.SendData(JsonConvert.SerializeObject(seg));

				//local rendering
				//using(Graphics gr = CreateGraphics())
				//{
				//	Pen RedPen = new Pen(Color.Red, 10);
				//	RedPen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
				//	gr.DrawLine(RedPen, lastPosition, mPosition);
				//	seg.Render(gr);
				//}
					

			}
			lastPosition = mPosition; //save mouse position 
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			UI_lbl_Color.Text = $"Color: {UI_lbl_Color.ForeColor.Name}"; //display starting color (color label text color)
		}
		private void StatusUpdate(string str)
		{
			//shove string into form text
			try
			{
				Invoke(new Action(() =>{ Text = str; }));
			}
			catch (Exception ex)
			{
				WriteLine("StatusUpdate method - "+ex);
			}
		}

		private void DrawSegment(string json)
		{
			//try to create line segment from json
			LineSegment seg = LineSegment.JSONToLineSegment(json);
			//if the linesegment is valid, render it
			if(LineSegment.IsSane(seg))
			{
				using (Graphics gr = CreateGraphics())
				{
					seg.Render(gr);
				}
			}
			try
			{
				//update the stats in the UI
				Invoke(new Action(() => { UI_lbl_Frames.Text = $"Frames RXed:{_sock.framesRX}"; }));
				Invoke(new Action(() => { UI_lbl_Fragments.Text = $"Fragments:{_sock.fragments}"; }));
				Invoke(new Action(() => { UI_lbl_Destack.Text = $"Destack Avg.:"+ string.Format("{0:##.##}",_sock.destackAVG); }));
				Invoke(new Action(() => { UI_lbl_Bytes.Text = "Bytes RXed:" + SINotation(_sock.bytesRX); }));
			}
			catch (Exception ex)
			{
				WriteLine("DrawSegment - Updating UI - "+ex);
			}
		}

		private string SINotation(double number)
		{
			if (number < 0.000001)
			{
				return string.Format("{0:#.###n}", number * 1000000000); //if less than 10^-6 its in the nano domain (10^-9)
			}
			else if (number < 0.001)
			{
				return string.Format("{0:#.###u}", number * 1000000); //if less than 10^-3 its in the micro domain (10^-6)
			}
			else if (number < 1)
			{
				return string.Format("{0:#.###m}", number * 1000); //if less than 1 its in the milli domain (10^-3)
			}
			else if (number >= 1000000000)
			{
				return string.Format("{0:#.###G}", number / 1000000000); //if greater than 1000000000 its in the Giga domain (10^9)
			}
			else if (number >=1000000)
			{
				return string.Format("{0:#.###M}", number / 1000000); //if greater than 1000000 its in the Mega domain (10^6)
			}
			else if (number >= 1000)
			{
				return string.Format("{0:#.###k}", number / 1000); //if greater than 1000 its in the kilo domain (10^3)
			}
			else
			{
				return string.Format("{0:#.###}", number);
			}
		}

		private void UI_btn_Connect_Click(object sender, EventArgs e)
		{
			if(_sock == null || !_sock.Connected) //if we dont have a connected socket, open the connection dialog and create a socket
			{
				ConnectDialog connectDialog = new ConnectDialog(address,port); //create dialog with specified default address and port
				try
				{
					if (connectDialog.ShowDialog() == DialogResult.OK)
					{
						_sock = new SuperSocket(connectDialog.Socket, 1024, StatusUpdate, DrawSegment);
						address = connectDialog.Address;
						port = connectDialog.Port;
					}
				}
				catch (Exception ex)
				{

					WriteLine($"Connection dialog - {ex}");
				}

			}
			else //if we are already connected, disconnect
			{
				_sock.SocketDisconnect();
			}

		}

		private void UI_lbl_Color_Click(object sender, EventArgs e)
		{
			//open the color dialog with current color already selected
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = UI_lbl_Color.ForeColor;
			if(colorDialog.ShowDialog() == DialogResult.OK)
			{
				// set the color label forcolor and disaply the color name.
				UI_lbl_Color.ForeColor = colorDialog.Color;
				UI_lbl_Color.Text = $"Color: {colorDialog.Color.Name}";
				penColor = UI_lbl_Color.ForeColor;
			}
		}

	}
}
