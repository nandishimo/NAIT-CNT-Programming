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
            //declare variable
            //balls starts on left side and moves right
            int xBall = 2;
            int yBall = 59;
            int xVel = 1;
            int yVel = 1;
            int score = 0;
            int bbX;
            int bbY;

            Point mPos;

            //use gdidrawer with continuous update mode off and scale of 5. windows size of 160x120
            //ball as rectangle with size 2, paddle is line with thickness 10
            //three table edgesdrawn on background
            CDrawer game = new CDrawer(800, 600, false);
            game.Scale = 5;

            for(bbX=0; bbX<160; bbX++)
            {
                game.SetBBScaledPixel(bbX, 0, Color.Aqua);
                game.SetBBScaledPixel(bbX, 119, Color.Aqua);
            }
            for (bbY = 0; bbY < 120; bbY++)
            {
                game.SetBBScaledPixel(159, bbY, Color.Aqua);
            }

            //loop to animate ball and move the paddle with time delay of 20ms
            //game ends when ball exits left side of game board
            while (xBall > 0)
            {
                //y position of mouse will determine paddle position, read every animation loop to move the paddle
                game.GetLastMousePositionScaled(out mPos);
                game.AddLine(0, mPos.Y-5, 0, mPos.Y + 5, Color.Blue, 10);
                //create ball with position x,y and velocty xVel and yVel
                game.AddRectangle(xBall, yBall, 2, 2, Color.Red);
                game.Render();
                System.Threading.Thread.Sleep(10); //time delay of 10ms
                game.Clear();
                game.AddText($"Score: {score}", 100, Color.DarkSlateGray);
                //ball bounces off the paddle and walls in opposite directionby 90deg
                if (xBall > 158)
                    xVel = -xVel;
                
                if (xBall < 2 && yBall < mPos.Y + 6 && yBall > mPos.Y - 8)
                {
                    xVel = -xVel;
                    //paddle bounces increase score by 1
                    score++;
                }
                    
                if (yBall > 118 || yBall < 1)
                    yVel = -yVel;

                xBall += xVel;//update ball position
                yBall += yVel;//update ball position
            }

            

            //display two buttons "play again" and "quit". buttons to be clicked


            Console.Read();
        }
    }
}
