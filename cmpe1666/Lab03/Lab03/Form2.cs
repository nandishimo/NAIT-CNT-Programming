using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class ModalDialog : Form
    {
        public ModalDialog()
        {
            InitializeComponent();
        }
        public string checkedButton;

        public string difficulty
        {
            get 
            {
                return checkedButton;
            }
            set
            {
                checkedButton = value;
            }
        }

        private void UI_btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void UI_btn_OK_Click(object sender, EventArgs e)
        {
            if (UI_rb_Easy.Checked)
                checkedButton = "Easy";
            else if (UI_rb_Medium.Checked)
                checkedButton = "Medium";
            else
                checkedButton = "Hard";
            DialogResult = DialogResult.OK;
        }
    }
}
