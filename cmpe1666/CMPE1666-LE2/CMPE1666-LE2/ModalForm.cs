using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1666_LE2
{
    public partial class ModalForm : Form
    {
        public ModalForm()
        {
            InitializeComponent();
        }

        private void ModalForm_Load(object sender, EventArgs e)
        {
            
        }
        public string string1
        {
            get
            {
                return UI_tb_NameEntry.Text; //return value entered in modal form textbox
            }
            set
            {
                UI_tb_NameEntry.Text = value; //display string passed from main form
            }
        }

        private void UI_btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
