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
        Random randColor = new Random();
        const int width = 800;
        const int height = 800;
        const int size = 40;
        const int rowCount = width / size;
        const int colCount = height / size;
        enum Active
        {
            Alive,Dead
        }
        struct Balls
        {
            public int color;
            public Point pos;
            public Active active;
        }
        Balls[,] array = new Balls[rowCount,colCount];
        CDrawer game = null;

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
            int numColors;
            if (diff == "Medium") { numColors = 4; }
            else if (diff == "Hard") { numColors = 3; }
            else { numColors = 3; }
            game = new CDrawer(width,height);
            for (int i = 0; i < colCount; i++)
            {
                for(int j=0; j<rowCount; j++)
                {
                    array[i, j].active = Active.Alive;
                    array[i, j].pos.X = i;
                    array[i, j].pos.Y = j;
                    array[i, j].color = randColor.Next(numColors);
                    //renderBallz(array[i, j], ref game);
                }
            }
            renderAllBallz();
            timer1.Enabled=true;

        }

        private void renderBallz(Balls ball, ref CDrawer window)
        {
            Color colour;
            switch (ball.color)
            {
                case 0:
                    colour = Color.Red;
                    break;
                case 1:
                    colour = Color.Green;
                    break;
                case 2:
                    colour = Color.Blue;
                    break;
                case 3:
                    colour = Color.Yellow;
                    break;
                case 4:
                    colour = Color.Purple;
                    break;
                default:
                    colour = Color.White;
                    break;
            }
            window.AddEllipse(ball.pos.X * size, ball.pos.Y * size, size, size, colour);
        }
        private void renderAllBallz()
        {
            for (int i = 0; i < colCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    if (array[i, j].active == Active.Alive)
                        renderBallz(array[i, j], ref game);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point click = new Point();
            if(game.GetLastMouseLeftClick(out click))
            {
                int x = click.X /= size;
                int y = click.Y /= size;
                killBallz(x, y, array[x, y].color);
            }
            game.Clear();
            renderAllBallz();
        }
        private void killBallz(int x, int y, int ballColor)
        {
            if (x < 0 || y < 0 || x > array.GetLength(0)-1 || y > array.GetLength(1)-1)
                return;
            if (array[x, y].active == Active.Dead)
                return;
            if (array[x, y].color != ballColor)
                return;
            array[x, y].active = Active.Dead;
            killBallz(x + 1, y, ballColor);
            killBallz(x - 1, y, ballColor);
            killBallz(x, y + 1, ballColor);
            killBallz(x, y - 1, ballColor);
        }
        private void stepDown(int x, int y)
        {
            if (y == array.GetLength(1) - 1)
                return;
            if (array[x, y].active == Active.Alive && array[x, y + 1].active == Active.Dead)
            {
                array[x, y + 1] = array[x, y];
                array[x, y].active = Active.Dead;
            }
        }
    }
}
