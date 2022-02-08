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
        Random rand = new Random();
        
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
            if (tintButton.Checked)
            {
                if (adjustSlider.Value < 50)
                    slideValue.Text = $"To Red: {50 - adjustSlider.Value}";
                else if (adjustSlider.Value > 50)
                    slideValue.Text = $"To Green: {adjustSlider.Value - 50}";
                else
                    slideValue.Text = "0";
            }  
            else
                slideValue.Text = $"{adjustSlider.Value}";
            effectAmount = adjustSlider.Value;
        }

        private void modificationChanged(object sender, EventArgs e)
        {
            string labelLeft = "Less", labelRight = "More", labelValue = "50";
            adjustSlider.Value = 50;
            if (tintButton.Checked)
            {
                labelLeft = "Red";
                labelRight = "Green";
                labelValue = "0";
            }
            else
            {

            }
            slideLeft.Text = labelLeft;
            slideRight.Text = labelRight;
            slideValue.Text = labelValue;
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
                        R = (int)(pixelColor.R + effectAmount * (pixelColor.R - 128) / Math.Max(Math.Abs(pixelColor.R - 128),1) / 5);
                        G = (int)(pixelColor.G + effectAmount * (pixelColor.G - 128) / Math.Max(Math.Abs(pixelColor.G - 128),1) / 5);
                        B = (int)(pixelColor.B + effectAmount * (pixelColor.B - 128) / Math.Max(Math.Abs(pixelColor.B - 128),1) / 5);
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
                        pixelColor = Color.FromArgb(R, G, B);
                        bm.SetPixel(x, y, pixelColor);
                    }
                }
            }
            else if (tintButton.Checked)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    for (int y = 0; y < bm.Height; y++)
                    {
                        pixelColor = bm.GetPixel(x, y);
                        if(effectAmount<50)
                        {
                            R = Math.Min((int)(pixelColor.R + 50 - effectAmount),255);
                            G = pixelColor.G;
                        }
                        else if (effectAmount > 50)
                        {
                            R = pixelColor.R;
                            G = Math.Min((int)(pixelColor.G + effectAmount-50),255);
                        }
                        else
                        {
                            R = pixelColor.R;
                            G = pixelColor.G;
                            B = pixelColor.B;
                        }
                        B = (int)(pixelColor.B);
                        pixelColor = Color.FromArgb(R, G, B);
                        bm.SetPixel(x, y, pixelColor);
                    }
                }
            }
            else if (bwButton.Checked)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    for (int y = 0; y < bm.Height; y++)
                    {
                        pixelColor = bm.GetPixel(x, y);
                        int pixelAverage = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        R = pixelColor.R + (pixelAverage - pixelColor.R) * effectAmount / 100;
                        G = pixelColor.G + (pixelAverage - pixelColor.G) * effectAmount / 100;
                        B = pixelColor.B + (pixelAverage - pixelColor.B) * effectAmount / 100;
                        pixelColor = Color.FromArgb(R, G, B);
                        bm.SetPixel(x, y, pixelColor);
                    }
                }

            }
            else
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    for (int y = 0; y < bm.Height; y++)
                    {
                        pixelColor = bm.GetPixel(x, y);
                        R = pixelColor.R + (rand.Next(0, 3) - 1) * effectAmount;
                        G = pixelColor.G + (rand.Next(0, 3) - 1) * effectAmount;
                        B = pixelColor.B + (rand.Next(0, 3) - 1) * effectAmount;
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
                        pixelColor = Color.FromArgb(R, G, B);
                        bm.SetPixel(x, y, pixelColor);
                    }
                }
            }
            pictureBox1.Image = bm;
        }
    }
}
