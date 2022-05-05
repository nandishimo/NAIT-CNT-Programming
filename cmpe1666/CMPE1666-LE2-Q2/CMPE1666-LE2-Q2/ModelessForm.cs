using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1666_LE2_Q2
{
    //declare delegate types
    public delegate void delVoidInt(int x);
    public delegate void delVoidVoid();
    public partial class ModelessForm : Form
    {
        public delVoidInt _delResult = null; //delegate to handle math operations
        public delVoidVoid _delFormClose = null; //delegate to handle form closing

        public ModelessForm()
        {
            InitializeComponent();
        }

        private void UI_rb_CheckedChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(UI_tb_Value1.Text, out int val1)||!int.TryParse(UI_tb_Value2.Text, out int val2))
            {
                _delResult(0);//return 0 if one of the textboxes is empty or invalid
            }
            else if (UI_rb_Addition.Checked)
            {
                _delResult(val1 + val2);//return values added
            }
            else if (UI_rb_Subtraction.Checked)
            {
                _delResult(val1 - val2); //return values subtracted
            }
            else if (UI_rb_Multiplication.Checked)
            {
                _delResult(val1 * val2); //return values mutiplied
            }
        }

        private void ModelessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_delFormClose != null)//check delegate is assigned 
            {
                _delFormClose();
            }
            e.Cancel = true;//cancel close event
            Hide();//hide the dialog
        }
    }
}
