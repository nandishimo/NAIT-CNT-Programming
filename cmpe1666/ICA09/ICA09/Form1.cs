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


namespace ICA09
{
    public partial class Form1 : Form
    {
        struct SLine
        {
            public Point start;
            public Point end;
            public Color color;
            public Byte thick;
        }
        public CDrawer window = new CDrawer(800, 800, false);
        public Form1()
        {
            InitializeComponent();
            
    }
        private void Render(SLine line)
        {
           window.AddLine(line.start.X, line.start.Y, line.end.X, line.end.Y, line.color, line.thick);
        }
        private void Render(List<SLine> lines)
        {
            foreach (SLine line in lines)
            {
                window.AddLine(line.start.X, line.start.Y, line.end.X, line.end.Y, line.color, line.thick);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state == eState.State_Idle)
            {
                window.GetLastMouseLeftClick(out Point asdas);
                state = eState.State_Armed;
            }
            else
            {
                window.GetLastMouseLeftClick(out Point end);
                state = eState.State_Idle;
            }
            
        }

        private enum eState { State_Idle, State_Armed};
        eState state = eState.State_Idle;
    }
}
