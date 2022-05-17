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
    public partial class HighScoreDialog : Form
    {
        //query user for name and send to main form if required
        public HighScoreDialog()
        {
            InitializeComponent();
        }
        public string name
        {
            get
            {
                return UI_tb_Name.Text;
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
