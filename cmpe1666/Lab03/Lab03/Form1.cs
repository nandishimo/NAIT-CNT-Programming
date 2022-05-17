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
using System.IO;

namespace Lab03
{
    public partial class Form1 : Form
    {
        //create form instances
        ScoreForm scoreDialog = null;
        AnimationSpeedDialog animationDialog = null;
        HighScoreDialog highScoreDlg = null;
        //create instances of global vars
        Random randColor = new Random();
        const int width = 800;
        const int height = 800;
        const int size = 40;
        const int rowCount = width / size;
        const int colCount = height / size;
        string difficulty = "";
        int animationSpeed = 10;
        int tScore = 0;
        enum Active
        {   //enum for alive or dead ball
            Alive,Dead
        }
        struct Balls
        { //struct for balls.
            public int color;
            public Point pos;
            public Active active;
        }
        Balls[,] array = new Balls[rowCount,colCount]; //create 2d array of balls
        CDrawer game = null; //create variable for gdidrawer
        ModalDialog difficultyDialog = new ModalDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_btn_Play_Click(object sender, EventArgs e)
        {
            tScore = 0; //initial score of 0
            difficultyDialog.ShowDialog(); //show difficulty selection
            if(difficultyDialog.DialogResult==DialogResult.OK)
            {   //start game if okay
                difficulty = difficultyDialog.difficulty;
                StartGame(difficulty);
                UI_btn_Play.Enabled = false;
            }
        }

        private void StartGame(string diff)
        {   //randomize color of each ball in grid. more colors for higher difficulties
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
            //render initial board state and start timer
            renderAllBallz();
            timer1.Enabled=true;
        }

        private void renderBallz(Balls ball, ref CDrawer window)
        {   //given a ball struct and gdidrawer window, render a ball
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
        {   //clear window and render all balls
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
        {   //check for gameover condition (ball count is 0)
            if (ballCount() == 0)
            {
                timer1.Enabled = false;
                gameOver();
            }
            else
            { //else call pick and add score to total score
                tScore += Pick();
                if(scoreDialog!=null)
                {
                    scoreDialog.score = tScore;
                }
                
            }


        }
        private int Pick()
        {   //kill clicked ball and adjacent balls of same color. return score based on # of balls killed
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
        {   //add game over text to window
            game.AddText("GAME OVER",100);
            string path="";
            switch (difficulty)
            {
                case ("Easy"):
                    path = "easyScore.txt";
                    break;
                case ("Medium"):
                    path = "mediumScore.txt";
                    break;
                case ("Hard"):
                    path = "hardScore.txt";
                    break;
            }
            //record highscore if one doesnt exist or if its higher than previous
            highScoreDlg = new HighScoreDialog();
            if (File.Exists(path))
            {
                StreamReader readScore = new StreamReader(path);
                int.TryParse(readScore.ReadLine(), out int hScore);
                readScore.Close();
                if (tScore > hScore)
                {
                    highScoreDlg.ShowDialog();
                    if (highScoreDlg.DialogResult == DialogResult.OK)
                    {
                        StreamWriter scoreRecord = new StreamWriter(path);
                        scoreRecord.WriteLine(tScore.ToString());
                        scoreRecord.WriteLine(highScoreDlg.name);
                        scoreRecord.Close();
                    }
                }
            }
            else
            {
                highScoreDlg.ShowDialog();
                if (highScoreDlg.DialogResult == DialogResult.OK)
                {
                    StreamWriter scoreRecord = new StreamWriter(path);
                    scoreRecord.WriteLine(tScore.ToString());
                    scoreRecord.WriteLine(highScoreDlg.name);
                    scoreRecord.Close();
                }
            }
            UI_btn_Play.Enabled = true; //re-enable play button
        }
        private int killBallz(int x, int y, int ballColor)
        {   //check if in valid row or coloum and kill ball if color matches
            int killedBallz = 0;
            if (x < 0 || y < 0 || x > array.GetLength(0)-1 || y > array.GetLength(1)-1)
                return 0;
            if (array[x, y].active == Active.Dead)
                return 0;
            if (array[x, y].color != ballColor)
                return 0;
            killedBallz++;
            array[x, y].active = Active.Dead;
            killedBallz += killBallz(x + 1, y, ballColor);//recursively kill adjacent balls
            killedBallz += killBallz(x - 1, y, ballColor);
            killedBallz += killBallz(x, y + 1, ballColor);
            killedBallz += killBallz(x, y - 1, ballColor);
            return killedBallz; //return number fo killed balls
        }
        private int ballCount()
        { //count remaining balls
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
                { //lower any ball if there is an empty space below
                    numSteps++;
                    array[x, y].active = Active.Alive;
                    array[x, y].color = array[x, y - 1].color;
                    array[x, y - 1].active = Active.Dead;
                    return numSteps;
                }
                else
                {   //check next ball up in coloum
                    numSteps+=stepDown(x, y - 1);
                }
            }
            return numSteps; //return number of balls moved
        }
        private int fallDown()
        { //drop all balls and try again until no balls are dropped.
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
        {// show or hide current score
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
        { //show or hide animation speed selector
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
        { //update animation speed 
            animationSpeed = x;
        }
    }
}
