using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//made by Nandish Patel 2022
//CMPE1666
namespace ICA11
{
    public partial class Form1 : Form
    {
        ModelessColourForm dlg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (dlg==null)
            {
                dlg = new ModelessColourForm();
                dlg._dTrackChanged = new delChangeColour(callbackTrackChanged);
                dlg.initialColour = this.BackColor;
                dlg.intialOpacity = this.Opacity;
                
            }
            dlg.ShowDialog();
            
        }
        private void callbackTrackChanged(Color color1, double alpha1)
        {
            this.BackColor = color1;
            this.Opacity = alpha1;
        }
    }
}
