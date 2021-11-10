using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            bool again = true;
            int xBall;
            int yBall;
            int xVel;
            int yVel;
            int score;
            int bbX;
            int bbY;
            Point clickPos;
            Point mPos;
            bool selection=false;

            //use gdidrawer with continuous update mode off and scale of 5. windows size of 160x120
            CDrawer game = new CDrawer(800, 600, false);
            game.Scale = 5;
            //three table edges drawn on background

            for (bbX = 0; bbX < 160; bbX++)
            {
                game.SetBBScaledPixel(bbX, 0, Color.Aqua);
                game.SetBBScaledPixel(bbX, 119, Color.Aqua);
            }
            for (bbY = 0; bbY < 120; bbY++)
            {
                game.SetBBScaledPixel(159, bbY, Color.Aqua);
            }
            do
            {

                //balls starts on left side and moves right
                xBall = 2;
                yBall = 59;
                xVel = 1;
                yVel = 1;
                score = 0;//score starts at zero
                
                //loop to animate ball and move the paddle with time delay of 20ms
                //game ends when ball exits left side of game board
                while (xBall > 0)
                {
                    System.Threading.Thread.Sleep(10); //time delay
                    game.Clear();
                    //ball as rectangle with size 2, paddle is line with thickness 10
                    //y position of mouse will determine paddle position, read every animation loop to move the paddle
                    game.GetLastMousePositionScaled(out mPos);
                    game.AddLine(0, mPos.Y - 5, 0, mPos.Y + 5, Color.Blue, 10);
                    //create ball with position x,y and velocty xVel and yVel
                    game.AddRectangle(xBall, yBall, 2, 2, Color.Red);
                    game.AddText($"Score: {score}", 100, Color.DarkSlateGray);
                    game.Render();
                    

                    //ball bounces off the paddle and walls in opposite directionby 90deg
                    if (xBall > 158)//flip x velocity at right wall
                        xVel = -xVel;

                    if (xBall < 2 && yBall < mPos.Y + 6 && yBall > mPos.Y - 8)
                    {
                        xVel = -xVel;//flip x velocity at paddle
                        //paddle bounces increase score by 1
                        score++;
                    }

                    if (yBall > 118 || yBall < 1)//flip y velocity at top and bottom walls
                        yVel = -yVel;

                    xBall += xVel;//update ball position
                    yBall += yVel;//update ball position
                }


                //display two buttons "play again" and "quit" buttons to be clicked
                game.AddRectangle(50, 100, 20, 10, Color.Green, 1, Color.Green);
                game.AddText("Play Again", 10, 50, 100, 20, 10, Color.White);
                game.AddRectangle(90, 100, 20, 10);
                game.AddText("Quit", 10, 90, 100, 20, 10, Color.White);
                game.Render();
                selection = false;
                while (!selection)//loop to check if a button is clicked and which one
                {
                    clickPos = new Point(0,0);
                    if(game.GetLastMouseLeftClickScaled(out clickPos))//if mouse is clicked enter the nest
                    {
                        if (clickPos.Y > 99 && clickPos.Y < 111)//if click is matching vertical location of buttons continue into nest
                        {
                            if (clickPos.X > 49 && clickPos.X < 71)//if click is overlapping play again button
                            {
                                selection = true;
                                again = true;
                            }
                            if (clickPos.X > 89 && clickPos.X < 101)//if click is overlapping quit button
                            {
                                selection = true;
                                again = false;
                            }
                        }
                    }
                }

            } while (again);//play again if play again button was clicked

            game.Close();//close window when loop exits (quit is clicked)
        }
    }
}
