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
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }
        public int score
        {
            set
            {
                UI_lbl_Score.Text = $"Score: {value.ToString()}";
            }
        }
    }
}
