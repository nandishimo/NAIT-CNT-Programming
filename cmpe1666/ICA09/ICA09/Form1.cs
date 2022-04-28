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

//made by Nandish Patel
//CMPE1666
namespace ICA09
{
    public partial class Form1 : Form
    {
        private struct SLine //struct for properties of lines to be rendered
        {
            public Point start;
            public Point end;
            public Color color;
            public Byte thick;
        }
        SLine tempLine;
        List<SLine> lines = new List<SLine>();

        private enum eState { State_Idle, State_Armed };
        eState state = eState.State_Idle;

        private Random rand = new Random();

        public CDrawer window = new CDrawer(800, 800, false);
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Render(SLine line)
        {
           //render line with specified properties (using line struct)
           window.AddLine(line.start.X, line.start.Y, line.end.X, line.end.Y, line.color, 5);
        }
        private void Render(List<SLine> lines)
        {
            foreach (SLine line in lines)
            {
                //render all lines in lines list
                window.AddLine(line.start.X, line.start.Y, line.end.X, line.end.Y, line.color, line.thick);
            }
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            if(window.GetLastMouseLeftClick(out Point click))
            {
                //change enum between idle and armed each left click
                if (state == eState.State_Idle)
                {
                    tempLine.start = click;//store start position of line
                    state = eState.State_Armed;
                }
                else
                {
                    tempLine.end = click; //store end position of line
                    state = eState.State_Idle;
                    tempLine.color = Color.Red; //make line red
                    tempLine.thick = 2; //line thickness
                    lines.Add(tempLine); //add line to line list
                    Render(lines[lines.Count-1]); //render line
                }
            }
            if(window.GetLastMouseRightClick(out Point rClick))
            {
                window.Clear(); //clear all lines
                SLine newLine = new SLine();
                for(int i=0; i<lines.Count; i++)
                {
                    //set line properties from lines structs in list
                    newLine.start = lines[i].start;
                    newLine.end = lines[i].end;
                    newLine.thick = (byte)rand.Next(1,11);
                    newLine.color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
                    lines[i] = newLine; //replace line in list with same position and random color and thickness
                }
                Render(lines);
            }

            eState_lbl.Text = state.ToString();
            window.Render(); //render changes to window
        }


    }
}
