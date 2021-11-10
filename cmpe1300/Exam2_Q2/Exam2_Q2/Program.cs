/* *************************************

   * NANDISH PATEL

   * LAB EXAM 2 Q2

   * Question Code: 342

   *************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Exam2_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string title = "Nandish Patel Exam 2 Q2";
            string shape;//stores shape type
            int number=0;//stores # of shapes to draw
            bool valid;//for valid check of shape
            const int size = 10;//size of circle or square
            Random position = new Random();//generates random numbers for shape location
            int i;//counter

            //display title
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);

            //ask user to input circle or square and validate
            //loop for validation
            do
            {
                Console.Write("Input Shape (circle or square): ");
                shape = Console.ReadLine();
                shape = shape.ToLower();//convert input to lowercase. allows combination of capital and lowercase characters to be accepted
                if (shape != "circle" && shape != "square")
                    Console.WriteLine($"\nWrong Shape- Please Input again.\n");//error message
            } while (shape != "circle" && shape != "square");//stuck in loop until cirle or square is entered

            //ask user for number of shapes n to be drawn
            //loop for valid integer between 5 and 10
            do
            {
                Console.Write($"\nInput the number of {shape}s to be drawn (5-10): ");
                valid = int.TryParse(Console.ReadLine(), out number);//check input if integer
                if (!valid)
                {
                    Console.Write("\nValue invalid- -You should enter an integer value\n");//error message
                }

            } while (!valid);//stuck in loop until integer is entered
            //set number to 5 if less than 5, set to 10 if greater than 10
            number = (number < 5) ? 5 : number;
            number = (number > 10) ? 10 : number;

            //create gdidrawer window 800x600, scale of 5
            CDrawer window = new CDrawer(800, 600);
            window.Scale = 5;

            //draw n shapes of specified type and size 10x10, color=seagreen
            if (shape == "circle")//if circle draw cricle
            {
                for (i = 0; i < number; i++)
                {
                    //draw circle at random positions 
                    window.AddEllipse(position.Next(0, 150), position.Next(0, 110), size, size, Color.SeaGreen);
                }
                
            }
            if (shape == "square")//if square draw square
            {
                for (i = 0; i < number; i++)
                {
                    //draw square at random positions
                    window.AddRectangle(position.Next(0, 150), position.Next(0, 110), size, size, Color.SeaGreen);
                }

            }
            Console.Write("\nPress Any Key to leave Program.");
            Console.ReadKey();
        }
    }
}
