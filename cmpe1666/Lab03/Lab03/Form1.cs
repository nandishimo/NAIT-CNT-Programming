using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace Lab03
{
    public partial class Form1 : Form
    {
        ModalDialog difficultyDialog = new ModalDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_btn_Play_Click(object sender, EventArgs e)
        {
            difficultyDialog.ShowDialog();
            if(difficultyDialog.DialogResult==DialogResult.OK)
            {

                StartGame(difficultyDialog.difficulty);
            }
        }

        private void StartGame(string diff)
        {
            CDrawer game = new CDrawer();

            this.Text = diff;
        }
    }
}
