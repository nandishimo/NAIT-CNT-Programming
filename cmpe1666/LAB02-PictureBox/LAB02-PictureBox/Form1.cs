using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bm;
        int effectAmount = 50;
        
        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(DialogResult.OK == result)
            {
                try
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                }
                catch(Exception exception)
                {
                    MessageBox.Show($"{exception.Message}");
                }
                transformButton.Enabled = true;
                bm = new Bitmap(pictureBox1.Image);
            }
                
        }

        private void adjustSlider_Scroll(object sender, EventArgs e)
        {
            effectAmount = adjustSlider.Value;
            slideValue.Text = effectAmount.ToString();
        }

        private void modificationChanged(object sender, EventArgs e)
        {
            string labelLeft="Less", labelRight="More", labelValue;
            if (contrastButton.Checked)
            {
                labelValue = "Contrast: ";
            }
            else if (tintButton.Checked)
            {
                labelLeft = "Red";
                labelRight = "Green";
                labelValue = "Tint: ";
            }
            else if (bwButton.Checked)
            {
                labelValue = "Grayscale: ";
            }
            else
            {
                labelValue = "Contrast: ";
            }
            slideLeft.Text = labelLeft;
            slideRight.Text = labelRight;

            if (contrastButton.Checked)
            {

            }
            else if (tintButton.Checked)
            {

            }
            else if (bwButton.Checked)
            {

            }
            else
            {

            }
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            Color pixelColor;
            int R;
            int G;
            int B;

            if (contrastButton.Checked)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    for (int y = 0; y < bm.Height; y++)
                    {
                        pixelColor = bm.GetPixel(x, y);
                        R = (int)(pixelColor.R - (pixelColor.R - 128) *effectAmount/20);
                        G = (int)(pixelColor.G - (pixelColor.G - 128) *effectAmount/20);
                        B = (int)(pixelColor.B - (pixelColor.B - 128) *effectAmount/20);
                        if (R > 255)
                            R = 255;
                        if (R < 0)
                            R = 0;
                        if (G > 255)
                            G = 255;
                        if (G < 0)
                            G = 0;
                        if (B > 255)
                            B = 255;
                        if (B < 0)
                            B = 0;
                        pixelColor = Color.FromArgb(255,R, G, B);
                        bm.SetPixel(x, y, pixelColor);
                    }
                }
            }
            pictureBox1.Image = bm;
        }
    }
}
