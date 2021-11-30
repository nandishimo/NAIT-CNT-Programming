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

        /* CreateNewGDIDrawerWindow
         * 
         * */

        /* AskForTriangleSides
         * */

        /* CalculateThirdSide
         * */

        /* DrawTriangle
         * */

        /* RunAgain
         * */

    }
}