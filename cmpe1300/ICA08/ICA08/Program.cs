using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA08
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string title = "Nandish Patel - ICA08";
            bool input;
            int i;
            int j;
            int k;
            int size;
            string shape;
            char cont = 'y';

            do
            {
                //display title
                Console.Clear();
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
                Console.WriteLine(title);

                //input the shape size as integer. check for valid input from 5 to 25.
                //if invalid use loop to display error messages and get new input
                Console.Write("Please enter a size from 5 to 25: ");
                
                //input the type of shape as "line" "square" or "triangle". use loop to force user to enter a correct shape
                Console.Write("Please enter a shape (line, square, or triangle): ");
                shape = Console.ReadLine();

                //draw the shape using for loops with the '*' character
                if (shape=="line")
                {
                    for (j = 0; j < size; j++)
                    {
                        Console.Write("\n");
                        for (k = 0; k < j; k++)
                            Console.Write(" ");
                        Console.Write("*");
                    }
                }
                else if (shape == "square")
                {
                    for (j = 0; j < size; j++)
                    {
                        Console.Write("\n");
                        for (k = 0; k < size; k++)
                            Console.Write("*");
                    }
                }
                else if (shape == "triangle")
                {
                    for (j = 0; j < size; j++)
                    {
                        Console.Write("\n");
                        for (k = 0; k < j; k++)
                            Console.Write("*");
                        Console.Write("*");
                    }
                }

                //user to run program again
                Console.Write("\nRun program again? (y/n): ");
                cont = Console.ReadKey().KeyChar;
            } while (cont == 'y' || cont == 'Y');


        }
    }
}
