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


            //use gdidrawer with continuous update mode off and scale of 5. windows size of 160x120
            //ball as rectangle with size 2, paddle is line with thickness 10
            //three table edgesdrawn on background
            CDrawer game = new CDrawer(800, 600/*, false*/);
            game.Scale = 5;

            game.AddLine(0, 55, 0, 65, Color.Blue, 10);

            //loop to animate ball and move the paddle with time delay of 20ms
            //create ball with position x,y and velocty xVel and yVel

            //ball bounces off the paddle and walls in opposite directionby 90deg
            //paddle bounces increase score by 1

            //y position of mouse will determine paddle position, read every animation loop to move the paddle

            //balls starts on left side and moves right

            //game ends when ball exits left side of game board

            //display two buttons "play again" and "quit". buttons to be clicked


            Console.Read();
        }
    }
}
