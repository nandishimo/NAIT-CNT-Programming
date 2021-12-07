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
                DrawGraph(a, b, c, up, down, ref window);

                //receive prompt to be displayed. return a bool based on user response
                again = YesNo("Run again?");

            } while (again);
        }

        private static void GetRange(out double upper, out double lower)
        {
            //pass user input to getvalue. return upper and lower range values as doubles
            bool valid1 = false;
            bool valid2 = false;
            bool valid3 = false;

            do//main getrange loop
            {
                do//lower range validation loop
                {
                    lower = GetValue("Please enter a lower range: ");
                    if (lower < -40)//limit of -40 for range
                    {
                        Console.WriteLine("Values this low cannot be displayed.");
                        valid2 = false;
                    }
                    else
                        valid2 = true;
                } while (!valid2);

                do//upper range validation loop
                {
                    upper = GetValue("Please enter an upper range: ");
                    if (upper > 40)//limit of 40 for range
                    {
                        Console.WriteLine("Values this high cannot be displayed.");
                        valid3 = false;
                    }
                    else
                        valid3 = true;
                } while (!valid3);
                if (lower > upper)//lower less than upper validation loop
                {
                    Console.WriteLine("Lower must be less than Upper range.");
                    valid1 = false;
                }
                else
                    valid1 = true;
                

            } while (!valid1||!valid2||!valid3);//all validation loops must check out for main loop to pass

        }

        private static bool YesNo(string prompt)
        {
            bool valid = false;//checks for valid response
            bool again = false;//checks for yes to return true
            do//main bool loop
            {
                Console.Write(prompt + " yes or no: ");//grabs prompt and adds yes or no for options

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


            } while (!valid);//needs valid response(yes or no) to exit loop
            return again;

        }

        private static void DrawGraph(double a, double b, double c, double U, double L, ref CDrawer window)
        {
            //pass coefficients and current value of x. calculate f(x)
            int h = window.ScaledHeight;
            int w = window.ScaledWidth;
            //inital values at lower range
            double x1 = L-1;
            double f1 = Quadratic(a, b, c, x1);
            for (int x = 0; x < 800; x++)//draw horizontal axis 
            {
                window.SetBBPixel(x, 300, Color.Green);
            }
            for (int y = 0; y < 600; y++)//draw vertical axis
            {
                window.SetBBPixel(400, y, Color.Green);
            }
            for (int x = 0; x < 800; x += 50)//Draw ticks on horizontal axis
            {
                for (int y = 300; y > 295; y--)
                {
                    window.SetBBPixel(x, y, Color.Green);
                }
            }
            for (int y = 0; y < 600; y += 50)//draw ticks on vertical axis
            {
                for (int x = 400; x < 405; x++)
                {
                    window.SetBBPixel(x, y, Color.Green);
                }
            }
            for (double x2 = L; x2 < U; x2 += 0.02)//function drawing loop
            {
                double f2 = Quadratic(a, b, c, x2);
                window.AddLine((int)(10*x1 + w / 2), (int)((h / 2) - 10*f1), (int)(10*x2 + w / 2), (int)((h / 2) - 10*f2));//scale up by factor of 10
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
                Console.Write(prompt);//display prompt
                valid = double.TryParse(Console.ReadLine(), out output);//checks if input is valid, loops if not
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
