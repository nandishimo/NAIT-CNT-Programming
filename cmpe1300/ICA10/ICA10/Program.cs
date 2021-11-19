using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA10
{
    class Program
    {
        //main method
        //input line length, angle increment as doubles
        //input spacing as int
        //run DrawStars() method in a loop
        static void Main(string[] args)
        {
            //declare variables
            string title = "Nandish Patel - ICA10";//title
            int spacing;//center to center spacing for stars
            double length;//length of lines (radius) of stars
            double angle;//angle icrement in degrees
            double X;//x-axis coordinate
            double Y;//y-axis coordinate
            char again;//input to run program again
            bool run = false;//boolean to run program again
            
            do {
                Console.Clear();//clear console at start of each loop
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;//center title
                //title
                Console.WriteLine(title);

                Console.Write("Enter line length in pixels: ");//ask for line length (radius)
                length = GetDouble(Console.ReadLine(), 5, 300);//convert input to double limit radius from 5 pixels 300/window size (800x600)

                Console.Write("Enter angle imcrement in degrees: ");//ask for angle increment in degrees
                angle = Deg2Rad(GetDouble(Console.ReadLine(), 0, 360));//convert input to double and convert that result to radians

                Console.Write("Enter spacing for the stars in pixels: ");//asl for star input
                spacing = GetInt(Console.ReadLine(), 5, 600);//convert input to integer and limit from 5 pixels to window size

                CDrawer window = new CDrawer();//create drawing window

                for (X = length; X <= window.ScaledWidth - length; X += spacing)//loop to increment x-asis position by user specified spacing
                    for (Y = length; Y <= window.ScaledHeight - length; Y += spacing) //loop to increment y-axis position by user specified spacing
                    {
                        DrawStar(window, (int)X, (int)Y, length, angle);//draw star each loop when position increments with use specified length and angle increments
                    }
                Console.Write("Would you like to run the program again? (Y/N): ");//ask user to run program again
                again = Console.ReadKey().KeyChar;//store next key press
                if (again == 'y')
                    run = true;//bool run again if y is pressed
                else
                    run = false;//dont run if another key is pressed
                window.Close();// close drawing window at end of loop

            } while (run);//loop if run is true
        }

        //GetInt() method iwth 3 parameters (input, minimum value, maximum value
        static private int GetInt(string input, int min, int max)// grab input and limits from main method
        {
            //prompt user for a value to return to calling code
            //force user to input a valid integer within range
            //use loop
            int integer = 0;//declare var for this loop
            do//input loop
            {
                int.TryParse(input, out integer);
                if (integer<min || integer>max)//check if parsed input is in range
                {
                    Console.Write($"The input is invalid, please enter a value from {min} to {max}: ");//display error and grab new input if inpujt from main method is invalid
                    input = Console.ReadLine();
                }
            } while (integer < min || integer > max); //continue loop if input is invalid int or not in range
            return integer;//return valid integer
        }


        //GetDouble() method with 3 parameters (input, min value, max value)
        static private double GetDouble(string input, double min, double max)
        {
            //prompt user for a value to return to calling code
            //force user to input a valid double within range
            //use loop
            double Dub = 0;//declare var for this loop
            do//input loop
            {
                double.TryParse(input, out Dub);
                if (Dub < min || Dub > max)//check if parsed input is in range
                {
                    Console.Write($"The input is invalid, please enter a value from {min} to {max}: ");//display error and grab new input if invalid or out of range
                    input = Console.ReadLine();
                }
            } while (Dub < min || Dub > max);//continue loop if input is invalid or not in range
            return Dub;//return valid double
        }


        //Deg2Rad() method
        static private double Deg2Rad(double input)
        {
            //passed a double value from main
            //performs calculation and returns angle in radians to main
            double Rad = input * Math.PI / 180;//new variable for this method.
            return Rad;//return rad double
        }


        //DrawStar method
        static private void DrawStar(CDrawer window,int X, int Y, double length, double angle)//grab xoordinates from main, and legnth and angle increment
        {
            //pass from main: GDIDrawer window as CDrawer, center point x-axis and y-axis for star,
            //double line length for lines in star, double increment value in degrees
            Point center = new Point(X, Y);//convert integer coordinates to point variable
            Random rand = new Random();//generate random number
            double i;
            for (i = 0; i < 2*Math.PI; i+=angle)//loop line until full rotation is complete
            {
                window.AddLine(center, length, i, Color.FromArgb(rand.Next()));//adds line with incrementing angle and random colors
            }
        }

    }

}
