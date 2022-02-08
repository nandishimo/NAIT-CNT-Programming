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
        Bitmap bm; //bitmap variable for image manipulation
        int effectAmount = 50; //initial slider value
        Random rand = new Random(); //random number variable
        
        private void loadButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 5;
            DialogResult result = openFileDialog1.ShowDialog(); //open a dialog to select a picture to open
            if(DialogResult.OK == result) //if dialog is not closed or cancelled, load the selected image file
            {
                try
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                }
                catch(Exception exception)
                {
                    MessageBox.Show($"{exception.Message}"); //show message box with error
                }
                transformButton.Enabled = true;//transform button is disabled on start until a picture is loaded
                bm = new Bitmap(pictureBox1.Image);//load bitmap of image
            }
            progressBar1.Value = 100;

        }

        private void adjustSlider_Scroll(object sender, EventArgs e) //update label to show currently selected value
        {
            progressBar1.Value = 0;
            if (tintButton.Checked)//if tint button is selected, the slider goes from red 50 - green 50 instead of 0-100
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
            progressBar1.Value = 0;
            string labelLeft = "Less", labelRight = "More", labelValue = "50";//default values for labels
            adjustSlider.Value = 50;
            if (tintButton.Checked)//different labels if tint is selected
            {
                labelLeft = "Red";
                labelRight = "Green";
                labelValue = "0";
            }
            slideLeft.Text = labelLeft;
            slideRight.Text = labelRight;
            slideValue.Text = labelValue;
        }

        private void transformButton_Click(object sender, EventArgs e)//execute selected modification
        {
            progressBar1.Value = 5;//placebo progress
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
                        pixelColor = bm.GetPixel(x, y);//adjust pixels by 1/5th of the effect value away from the middle (128)
                        R = (int)(pixelColor.R + effectAmount * (pixelColor.R - 128) / Math.Max(Math.Abs(pixelColor.R - 128),1) / 5);
                        G = (int)(pixelColor.G + effectAmount * (pixelColor.G - 128) / Math.Max(Math.Abs(pixelColor.G - 128),1) / 5);
                        B = (int)(pixelColor.B + effectAmount * (pixelColor.B - 128) / Math.Max(Math.Abs(pixelColor.B - 128),1) / 5);
                        //cap values 0-255
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
                        if(effectAmount<50)//tint red if slider is less than 50
                        {
                            R = Math.Min((int)(pixelColor.R + 50 - effectAmount),255);//cap values 0-255
                            G = pixelColor.G;
                        }
                        else if (effectAmount > 50)//tint green if slider is less than 50
                        {
                            R = pixelColor.R;
                            G = Math.Min((int)(pixelColor.G + effectAmount-50),255);//cap values 0-255
                        }
                        else//do nothing if slider is in middle (50)
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
            else if (bwButton.Checked)//black & white
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    for (int y = 0; y < bm.Height; y++)
                    {
                        pixelColor = bm.GetPixel(x, y);
                        int pixelAverage = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;//move all rgb values closer to the average value
                        R = pixelColor.R + (pixelAverage - pixelColor.R) * effectAmount / 100;
                        G = pixelColor.G + (pixelAverage - pixelColor.G) * effectAmount / 100;
                        B = pixelColor.B + (pixelAverage - pixelColor.B) * effectAmount / 100;
                        pixelColor = Color.FromArgb(R, G, B);
                        bm.SetPixel(x, y, pixelColor);
                    }
                }

            }
            else//noise modification
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    for (int y = 0; y < bm.Height; y++)
                    {
                        pixelColor = bm.GetPixel(x, y);//add random noise in negative or positive direction
                        R = pixelColor.R + (rand.Next(0, effectAmount) - effectAmount / 2);
                        G = pixelColor.G + (rand.Next(0, effectAmount) - effectAmount / 2);
                        B = pixelColor.B + (rand.Next(0, effectAmount) - effectAmount / 2);
                        //cap values
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
            progressBar1.Value = 100;//placebo progress;
            pictureBox1.Image = bm;//display image with altered bitmap
        }
    }
}
