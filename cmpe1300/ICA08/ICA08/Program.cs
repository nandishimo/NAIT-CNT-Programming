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
                Console.Write("Please enter a shape size from 5 to 25: ");
                do
                {
                    input = int.TryParse(Console.ReadLine(), out size);
                    if (!input)
                        Console.Write("You must enter a valid integer. Try again: ");
                    else if (size < 5)
                        Console.Write("The shape size is too small. Try again: ");
                    else if (size > 25)
                        Console.Write("The shape size is too large. Try again: ");
                    
                } while (!input || size < 5 || size > 25); ;

                //input the type of shape as "line" "square" or "triangle". use loop to force user to enter a correct shape
                do
                {
                    Console.Write("\nPlease enter a shape (line, square, or triangle): ");
                    shape = Console.ReadLine();
                    if (shape != "line")
                        if(shape != "square")
                            if(shape != "triangle")
                                Console.Write("You have entered an invalid shape.");
                } while (shape!="line"&& shape != "square"&& shape != "triangle");

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
