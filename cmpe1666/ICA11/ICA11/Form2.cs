using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA11
{
    public delegate void delChangeColour(Color color1, double alpha1);

    public partial class ModelessColourForm : Form
    {
        public delChangeColour _dTrackChanged = null;
        public Color initialColour
        {
            set
            {
                UI_TBar_RED.Value = value.R;
                UI_TBar_GREEN.Value = value.G;
                UI_TBar_BLUE.Value = value.B;
            }
        }
        public double intialOpacity
        {
            set
            {
                UI_TBar_OPACITY.Value = 100;
            }
        }

        public ModelessColourForm()
        {
            InitializeComponent();
        }

        private void ModelessColourForm_Load(object sender, EventArgs e)
        {

        }

        private void UI_TBar_ValueChanged(object sender, EventArgs e)
        {
            Color color1 = new Color();
            double alpha1 = (double)UI_TBar_OPACITY.Value / 100;
            color1 = Color.FromArgb(UI_TBar_RED.Value, UI_TBar_GREEN.Value, UI_TBar_BLUE.Value);

            _dTrackChanged.Invoke(color1, alpha1);
        }
    }
}
