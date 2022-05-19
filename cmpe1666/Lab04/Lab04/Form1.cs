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

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Status
        {
            active,
            inactive
        }
        struct LineSeg
        {   //lineseg struct with constructor for start, end, thickness, color
            public Point Start;
            public Point End;
            public byte Thickness;
            public Color Color;
            public LineSeg(Point s, Point e, byte t, Color c)
            {
                Start = s;
                End = e;
                Thickness = t;
                Color = c; ;
            }
        }
        //class vars
        Status drawingStatus = Status.inactive;
        CDrawer window = new CDrawer(1024,768);
        Point lastMousePos = new Point();
        Stack<LinkedList<LineSeg>> lineStack = new Stack<LinkedList<LineSeg>>();
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //grab left and right clicks to start and stop drawing. push new linked list to stack if new drawing started
            if(window.GetLastMouseLeftClick(out Point click))
            {
                if (drawingStatus == Status.inactive) 
                {
                    drawingStatus = Status.active;
                    lastMousePos = click;
                    lineStack.Push(new LinkedList<LineSeg>());
                }
            }
            if (drawingStatus == Status.active)
            {
                DrawLine();
            }
            if(window.GetLastMouseRightClick(out click))
            {
                drawingStatus = Status.inactive;
            }
            UI_TBox_Lines.Text = $"{lineStack.Count} Lines, {CountSegments()} Total Segments";
        }
        private int CountSegments()
        { //count total segments for all lines
            int count = 0;
            foreach (LinkedList<LineSeg> list in lineStack)
            {
                count += list.Count;
            }
            return count;
        }

        private void DrawLine()
        {//build lineseg and push to linkedlist on top of stack
            //lineStack.Push()
            window.GetLastMousePosition(out Point pos);
            if (lastMousePos != pos)
            {
                LineSeg newSeg = new LineSeg(lastMousePos, pos, (byte)UI_TBar_Thickness.Value, Color.FromArgb(UI_TBar_Alpha.Value, colorDialog1.Color));
                window.AddLine(newSeg.Start.X, newSeg.Start.Y, newSeg.End.X, newSeg.End.Y, newSeg.Color, newSeg.Thickness);
                lineStack.Peek().AddLast(newSeg);
            }
            lastMousePos = pos;
        }
        private void RenderAllLines()
        { //clear drawer window and iterate through stack and draw lines
            window.Clear();
            foreach(LinkedList<LineSeg> list in lineStack)
            {
                foreach(LineSeg line in list)
                {
                    window.AddLine(line.Start.X, line.Start.Y, line.End.X, line.End.Y, line.Color, line.Thickness);
                }
            }
        }

        private void UI_BTN_Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void UI_TBar_Thickness_Scroll(object sender, EventArgs e)
        {
            UI_LBL_Thickness.Text = $"Thickness: {UI_TBar_Thickness.Value}";
        }

        private void UI_TBar_Alpha_Scroll(object sender, EventArgs e)
        {
            UI_LBL_Alpha.Text = $"Alpha: {UI_TBar_Alpha.Value}";
        }

        private void UI_BTN_UndoLine_Click(object sender, EventArgs e)
        { //pops last list off stack and redraws remaining lines
            if (lineStack.Count > 0)
            {
                lineStack.Pop();
                RenderAllLines();
            }
        }

        private void UI_BTN_UndoSegment_Click(object sender, EventArgs e)
        { //removes last segment or pops last linkedlist off stack if no segments remain
            if (lineStack.Count > 0)
            {
                lineStack.Peek().RemoveLast();
                if (lineStack.Peek().Count == 0)
                {
                    lineStack.Pop();
                }
                RenderAllLines();
            }
        }

        private void ReduceComplexity()
        {
            if (lineStack.Count == 0) { return; }
            LinkedList<LineSeg> list = lineStack.Peek();
            if (list.Count < 2) { return; }
            LinkedList<LineSeg> tempList = new LinkedList<LineSeg>();
            while(list.Count>1)
            {
                Point tempPoint = list.First.Value.Start; //saves start point from first segment
                list.RemoveFirst(); //removes first segment
                //build new segment with start of first seg and end of second seg
                //(new first is second seg after removing first segment from linkedlist
                LineSeg tempLine = new LineSeg(tempPoint, list.First.Value.End, list.First.Value.Thickness, list.First.Value.Color);
                //adds segment to temp linked list
                tempList.AddLast(tempLine);
                list.RemoveFirst(); //removes next line from linked list
                if (list.Count == 1) //adds last segment again if removed because odd number of segments
                {
                    tempList.AddLast(list.First.Value);
                }
            }
            lineStack.Pop(); //remove last line
            lineStack.Push(tempList); //pushes reduced complexity line to replace previous
            RenderAllLines(); 
        }

        private void UI_BTN_Complex_Click(object sender, EventArgs e)
        {
            ReduceComplexity();
        }
    }
}
