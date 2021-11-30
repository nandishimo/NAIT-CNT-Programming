/* *************************************

   * NANDISH PATEL

   * LAB EXAM 3 Q1

   * Question Code: 45,905

   *************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace _1211Exam3Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            CDrawer myCanvas = null;   //GDIDrawer window version 2021-11-30T10:01:22-07:00
            int side1, side2;   //two sides of a triangle
            double side3;       //calculated third side of right triangle

            CreateNewGDIDrawerWindow(ref myCanvas, 1000, 800);

            do
            {
                //Display question title 4465
                Console.WriteLine("\t\tExam 3 Question 1");

                AskForTriangleSides(out side1, out side2);

                side3 = CalculateThirdSide(side1, side2);
                //writing out the third side192.197.128.18
                Console.WriteLine("The third side is size {0:F2}", side3);

                DrawTriangle(myCanvas, side1, side2, side3);
            } while (RunAgain());

        }

        static private void CreateNewGDIDrawerWindow(ref CDrawer window, int h, int w)
        /* 
        * create GDIDrawer window of size corresponding to passed width and height
        * save back to main using ref
        * */
        {
            window = new CDrawer(h, w);
        }

        static private void AskForTriangleSides(out int a, out int b)
        /* Prompt user for two sides of a triangle (a, b)
        * assume inputs are valid ints (no error chcking)
        * return two integers to main program
        */
        {
            Console.Write("\nEnter a value for a: ");
            int.TryParse(Console.ReadLine(), out a);//parse input as int and send out
            Console.Write("\nEnter a value for b: ");
            int.TryParse(Console.ReadLine(), out b);//parse input as int and send out
        }

        static private double CalculateThirdSide(int a, int b)
        /* pass a and b, calculate hypotenuse c using pythag and return as double
        */
        {
            double c = Math.Sqrt(a * a + b * b);//pythagreum thereom
            return c;
        }
        static private void DrawTriangle(CDrawer canvas, int a, int b, double c)
        /* use GDIDrawer to draw triangle. use pink for all sides
        * top left of triangle starts at 10,10
        * side 1 goes down vertically
        * side 2 is horizontal
        * side 3 meets up with side 1 and 2
        */
        {
            canvas.AddLine(10, 10, 10, 10 + a, Color.Pink);//vertical line length a
            canvas.AddLine(10, 10 + a, 10 + b, 10 + a, Color.Pink); //horizontal line length b
            canvas.AddLine(10 + b, 10 + a, 10, 10, Color.Pink); //line from end of previous line, back to start
        }

        static private bool RunAgain()
        /* prompt user to run program again. Y to run again. anything else causes an exit
        */
        {
            bool again = false;//bool var
            Console.Write("\nRun program again ? ");//prompt for input
            string input = Console.ReadLine();//store string input
            if (input == "Y")//if input is "Y" bool is true, otherwise false
                again = true;
            return again;//return bool

        }
    }
}