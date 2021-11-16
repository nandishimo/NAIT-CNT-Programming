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
            string title = "Nandish Patel - ICA10";
            //title
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);
            //
        }

        //GetInt() method iwth 3 parameters (input, minimum value, maximum value
        static private int GetInt(int input, int min, int max)
        {
            //prompt user for a value to return to calling code
            //force user to input a valid integer within range
            //use loop
            bool valid = false;
            do
            {
                Console.Write("Please enter an integer value between  a and b: ");
                valid = int.TryParse(Console.ReadLine(), out input);
                if(!valid)
                {
                    Console.WriteLine("The input is invalid");
                }
            } while(!valid);
        }


        //GetDouble() method with 3 parameters (input, min value, max value)
        static private double GetDouble()
        {
        //prompt user for a value to return to calling code
        //force user to input a valid double within range
        //use loop
        }


        //Deg2Rad() method
        static private double Deg2Rad()
        {
        //passed a double value from main
        //performs calculation and returns angle in radians to main
        }


        //DrawStars method
        static private void DrawStars()
        {
        //pass from main: GDIDrawer window as CDrawer, center point x-axis and y-axis for star,
        //double line length for lines in star, double increment value in degrees
        }

    }

}
