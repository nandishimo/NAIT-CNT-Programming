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
            int spacing;
            double length;
            double angle;
            int X;
            int Y;
            //title
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);
            Console.Write("Enter spacing: ");
            spacing = GetInt(Console.ReadLine(), 5, 100);
            Console.Write("Enter length: ");
            length = GetDouble(Console.ReadLine(), 5, 100);
            Console.Write("Enter angle in degrees: ");
            angle = Deg2Rad(GetDouble(Console.ReadLine(), 0, 360));
            CDrawer window = new CDrawer();

            for(X=0;X<window.ScaledWidth; X+=spacing)
                for(Y=0;Y<window.ScaledHeight;Y+=spacing)
                {
                    DrawStar(window, X, Y, length, angle);
                }


            Console.Read();
        }

        //GetInt() method iwth 3 parameters (input, minimum value, maximum value
        static private int GetInt(string input, int min, int max)
        {
            //prompt user for a value to return to calling code
            //force user to input a valid integer within range
            //use loop
            int integer = 0;
            do
            {
                int.TryParse(input, out integer);
                if (integer<min || integer>max)
                {
                    Console.Write($"The input is invalid, please enter a value from {min} to {max}: ");
                    input = Console.ReadLine();
                }
            } while (integer < min || integer > max);
            return integer;
        }


        //GetDouble() method with 3 parameters (input, min value, max value)
        static private double GetDouble(string input, double min, double max)
        {
            //prompt user for a value to return to calling code
            //force user to input a valid double within range
            //use loop
            double Dub = 0;
            do
            {
                double.TryParse(input, out Dub);
                if (Dub < min || Dub > max)
                {
                    Console.Write($"The input is invalid, please enter a value from {min} to {max}: ");
                    input = Console.ReadLine();
                }
            } while (Dub < min || Dub > max);
            return Dub;
        }


        //Deg2Rad() method
        static private double Deg2Rad(double input)
        {
            double Rad = input * Math.PI / 180;
            //passed a double value from main
            //performs calculation and returns angle in radians to main
            return Rad;
        }


        //DrawStar method
        static private void DrawStar(CDrawer window,int X, int Y, double length, double angle)
        {
            //pass from main: GDIDrawer window as CDrawer, center point x-axis and y-axis for star,
            //double line length for lines in star, double increment value in degrees
            Point center = new Point(X, Y);
            Random rand = new Random();
            int i;
            for (i = 0; i < 100; i++)
            {
                window.AddLine(center, length, angle, Color.FromArgb(rand.Next()));
                angle += angle;
            }
        }

    }

}
