using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA10
{
    public partial class FontSelection : Form
    {
        public FontSelection()
        {
            InitializeComponent();
        }
        public Font font1
        {
            get
            {
                return fontDialog1.Font;
            }
            set
            {
                fontDialog1.Font = value;
                UI_font_tbx.Text = value.ToString();
            }
        }
        public Color color1
        {
            get
            {
                return colorDialog1.Color;
            }
            set
            {
                colorDialog1.Color = value;
                UI_colour_tbx.Text = value.ToString();
            }
        }
        private void UI_btn_font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            UI_font_tbx.Text = fontDialog1.Font.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_btn_colour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            UI_colour_tbx.Text = colorDialog1.Color.ToString();
        }
    }
}
