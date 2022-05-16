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
using System.Threading;

namespace Lab03
{
    public partial class Form1 : Form
    {
        ScoreForm scoreDialog = null;
        AnimationSpeedDialog animationDialog = null;
        Random randColor = new Random();
        const int width = 800;
        const int height = 800;
        const int size = 40;
        const int rowCount = width / size;
        const int colCount = height / size;
        int animationSpeed = 10;
        int tScore = 0;
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
            tScore = 0;
            difficultyDialog.ShowDialog();
            if(difficultyDialog.DialogResult==DialogResult.OK)
            {
                StartGame(difficultyDialog.difficulty);
                UI_btn_Play.Enabled = false;
            }
        }

        private void StartGame(string diff)
        {
            int numColors;
            if (diff == "Medium") { numColors = 4; }
            else if (diff == "Hard") { numColors = 5; }
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
            game.Clear();
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
            if (ballCount() == 0)
            {
                timer1.Enabled = false;
                gameOver();
            }
            else
            {
                tScore += Pick();
                if(scoreDialog!=null)
                {
                    scoreDialog.score = tScore;
                }
                
            }


        }
        private int Pick()
        {
            int score = 0;
            int killedBallz=0;
            Point click = new Point();
            if (game.GetLastMouseLeftClick(out click))
            {
                int x = click.X /= size;
                int y = click.Y /= size;
                killedBallz = killBallz(x, y, array[x, y].color);
                fallDown();
                renderAllBallz();
                this.Text = $"Ball Count:{ballCount()}";
            }
            score = killedBallz * 25+(int)Math.Pow((double)killedBallz*5,2);
            return score;
        }
        private void gameOver()
        {
            game.AddText("GAME OVER",100);
            UI_btn_Play.Enabled = true;
        }
        private int killBallz(int x, int y, int ballColor)
        {
            int killedBallz = 0;
            if (x < 0 || y < 0 || x > array.GetLength(0)-1 || y > array.GetLength(1)-1)
                return 0;
            if (array[x, y].active == Active.Dead)
                return 0;
            if (array[x, y].color != ballColor)
                return 0;
            killedBallz++;
            array[x, y].active = Active.Dead;
            killedBallz += killBallz(x + 1, y, ballColor);
            killedBallz += killBallz(x - 1, y, ballColor);
            killedBallz += killBallz(x, y + 1, ballColor);
            killedBallz += killBallz(x, y - 1, ballColor);
            return killedBallz;
        }
        private int ballCount()
        {
            int count = 0;
            foreach(Balls ball in array)
            {
                if (ball.active == Active.Alive)
                {
                    count++;
                }
            }
            return count;
        }
        private int stepDown(int x, int y)
        {
            
            int numSteps = 0;
            if (y == 0)
                return numSteps;
            if (array[x, y].active == Active.Dead)
            {
                if (array[x, y - 1].active == Active.Alive)
                {
                    numSteps++;
                    array[x, y].active = Active.Alive;
                    array[x, y].color = array[x, y - 1].color;
                    array[x, y - 1].active = Active.Dead;
                    return numSteps;
                }
                else
                {
                    numSteps+=stepDown(x, y - 1);
                }
            }
            return numSteps;
        }
        private int fallDown()
        {
            int dropcount = 0;
            for (int i = 0; i < colCount; i++)
            {
                for (int j = rowCount-1; j > 0; j--)
                {
                    dropcount+=stepDown(i, j);
                }
            }
            if (dropcount != 0)
            {
                renderAllBallz();
                Thread.Sleep(animationSpeed);
                dropcount+=fallDown();
            }
            return dropcount;

        }

        private void UI_cb_ShowScore_CheckedChanged(object sender, EventArgs e)
        {
            if(UI_cb_ShowScore.Checked)
            {
                if (scoreDialog == null)
                {
                    scoreDialog = new ScoreForm();
                    scoreDialog.score = tScore;
                }
                scoreDialog.Show();
            }
            else
            {
                scoreDialog.Hide();
            }
        }

        private void UI_cb_ShowSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_cb_ShowSpeed.Checked)
            {
                if(animationDialog==null)
                {
                    animationDialog = new AnimationSpeedDialog();
                    animationDialog.speed = animationSpeed;
                    animationDialog._dSpeedChange = new delvoidint(callBackSpeedChange);
                }
                animationDialog.Show();
            }
            else
            {
                animationDialog.Hide();
            }
        }
        private void callBackSpeedChange(int x)
        {
            animationSpeed = x;
        }
    }
}
