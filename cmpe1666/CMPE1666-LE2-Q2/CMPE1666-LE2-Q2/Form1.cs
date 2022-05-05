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
    public partial class Form1 : Form
    {
        private ModelessForm dlg = null; //create instance of dialog
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_cb_ShowModeless_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_cb_ShowModeless.Checked)
            {
                if (dlg == null)
                {   //create new dialog if it doesnt exist, assign delegates to callback methods
                    dlg = new ModelessForm();
                    dlg._delResult = CallBackResult;
                    dlg._delFormClose = CallBackFormClose;
                }
                dlg.Show();
            }
            else
            {
                dlg.Hide();
            }
        }

        private void CallBackResult(int z)
        {
            UI_tb_Result.Text = z.ToString();//show integer result in textbox
        }

        private void CallBackFormClose()
        {
            UI_cb_ShowModeless.Checked = false; //uncheck show dialog checkbox if modeless dialog closes
        }


    }
}
