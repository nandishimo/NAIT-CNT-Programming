using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA12
{
    public partial class Form1 : Form
    {
        Color[,] array = new Color[80,60];
        Random rand = new Random();
        CDrawer window = new CDrawer();

        public Form1()
        {
            InitializeComponent();
            window.Scale = 10;
        }

        private void UI_btn_FillColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            UI_lbl_displayColor.BackColor = colorDialog1.Color;
        }

        private void UI_btn_Generate_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    array[i, j] = Color.Black;
                }
            }
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if(i==0 || i==79 ||j==0||j==59)
                        array[i, j] = Color.Red;
                }
            }
            for (int i = 0; i < UI_TBar_NumBlocks.Value; i++)
            {
                array[rand.Next(1,79), rand.Next(1,59)] = Color.Red;
            }
            RenderArray();


        }
        private void RenderArray()
        {

            for(int i = 0; i < 80; i++)
            {
                for(int j = 0; j < 60; j++)
                {
                    window.SetBBScaledPixel(i, j, array[i,j]);
                }
            }
            
        }

        private void UI_btn_Fill_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void FloodFill(int x, int y, Color oldColor, Color newColor)
        {
            if (array[x, y] != oldColor)
                return;
            array[x, y] = newColor;
            FloodFill(x + 1, y, oldColor, newColor);
            FloodFill(x - 1, y, oldColor, newColor);
            FloodFill(x, y+1, oldColor, newColor);
            FloodFill(x, y-1, oldColor, newColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point click = new Point();
            if (window.GetLastMouseLeftClickScaled(out click))
            {
                FloodFill(click.X, click.Y, Color.Black, colorDialog1.Color);
                RenderArray();
                timer1.Enabled = false;
            }
        }

        private void Window_MouseLeftClickScaled(Point pos, CDrawer dr)
        {
            throw new NotImplementedException();
        }
    }
}
