using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string title = "Nandish Patel - Lab 3";
            bool again = true;
            double a;
            double b;
            double c;
            double up;
            double down;
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);
            //main loop
            do
            {
                //get coefficients to ask for user input. return coefficients a,b,c
                GetCoefficients(out a, out b, out c);

                //getRange to ask user for input. return upper and lower range values
                GetRange(out up, out down);

                //Pass coefficients, range vlues, and CDrawer window reference
                CDrawer window = new CDrawer();
                window.Scale = 2;
                DrawGraph(a, b, c, up, down, ref window);

                //receive prompt to be displayed. return a bool based on user response
                again=YesNo("Run again?");

            } while (again);
        }

        private static void GetRange(out double upper, out double lower)
        {
            //pass user input to getvalue. return upper and lower range values as doubles
            upper = GetValue("Please enter an upper range: ");
            lower = GetValue("Please enter a lower range: ");
        }

        private static bool YesNo(string prompt)
        {
            bool valid = false;
            bool again = false;
            do
            {
                Console.Write(prompt + " yes or no: ");
                string input = Console.ReadLine();
                if (input != "yes" && input != "no")
                {
                    Console.WriteLine("You must repond with yes or no.");
                }
                if (input == "yes")
                {
                    valid = true;
                    again = true;
                }
                if (input == "no")
                {
                    valid = true;
                    again = false;
                }


            } while (!valid);
            return again;

        }

        private static void DrawGraph(double a, double b, double c, double U, double L, ref CDrawer window)
        {
            //pass coefficients and current value of x. calculate f(x)

            double x1 = L+200;
            double f1 = 150-Quadratic(a,b,c,x1-200);
            window.AddLine(0, 150, 400, 150);
            window.AddLine(400, 0, 400, 600);
            for (double x2 = L+200; x2 < U+200; x2 += 0.02)
            {
                double f2 = 150-Quadratic(a, b, c, x2-200);
                window.AddLine((int)x1, (int)f1, (int)x2, (int)f2);
                x1 = x2;
                f1 = f2;
            }
        }

        private static double Quadratic(double a, double b, double c, double x)
        {
            //quadtrativ equation
            double func = a*x*x+b*x+c;
            return func;
        }

        private static void GetCoefficients(out double a, out double b, out double c)
        {
            //pass prompt to get value for coefficient, get double values, return 3 coefficients to main
            a = GetValue("Please enter a value for a: ");
            b = GetValue("Please enter a value for b: ");
            c = GetValue("Please enter a value for c: ");
        }

        private static double GetValue(string prompt)
        {
            //display prompt
            bool valid = false;
            double output = 0;
            do
            {
                Console.Write(prompt);
                valid = double.TryParse(Console.ReadLine(), out output);
                if (!valid)
                {
                    Console.WriteLine("That input is invalid.");
                }
            } while (!valid);

            //return user input as double
            return output;
        }
    }
}
