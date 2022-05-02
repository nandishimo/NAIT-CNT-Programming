using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//made by Nandish Patel
//2022-05-02
namespace ICA10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_lbl_displayfont_Click(object sender, EventArgs e)
        {
            FontSelection dlg = new FontSelection();
            dlg.font1 = UI_lbl_displayfont.Font;
            dlg.color1 = UI_lbl_displayfont.ForeColor;
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                UI_lbl_displayfont.Font = dlg.font1;
                UI_lbl_displayfont.ForeColor = dlg.color1;
            }


        }
    }
}
