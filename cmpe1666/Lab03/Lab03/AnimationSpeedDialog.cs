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
    public delegate void delvoidint(int x);
    public partial class AnimationSpeedDialog : Form
    {
        public delvoidint _dSpeedChange = null;

        public AnimationSpeedDialog()
        {
            InitializeComponent();
        }
        public int speed
        {
            get
            {
                return UI_tbar_Speed.Value;
            }
            set
            {
                UI_tbar_Speed.Value = value;
            }
        }

        private void UI_tbar_Speed_Scroll(object sender, EventArgs e)
        {
            if (_dSpeedChange != null)
            {
                _dSpeedChange.Invoke(UI_tbar_Speed.Value);
            }
        }
    }
}
