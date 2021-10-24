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
            bool input; //holds parse checks
            int j; //counter
            int k; //counter
            int size; //holds input for size
            string shape; //holds input for shape
            char cont = 'y'; //holds choice to run prgram again

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
                    input = int.TryParse(Console.ReadLine(), out size);//parse input as int
                    if (!input)//integer check
                        Console.Write("You must enter a valid integer. Try again: ");
                    else if (size < 5)//too small check
                        Console.Write("The shape size is too small. Try again: ");
                    else if (size > 25)//too large check
                        Console.Write("The shape size is too large. Try again: ");
                    
                } while (!input || size < 5 || size > 25); ;//stay in loop if any condition fails

                //input the type of shape as "line" "square" or "triangle". use loop to force user to enter a correct shape
                do
                {
                    Console.Write("\nPlease enter a shape (line, square, or triangle): ");
                    shape = Console.ReadLine();
                    if (shape != "line")
                        if(shape != "square")
                            if(shape != "triangle")
                                Console.Write("You have entered an invalid shape."); //string input failed all nested conditions
                } while (shape!="line"&& shape != "square"&& shape != "triangle"); //stay in loop if all conditions fail

                //draw the shape using for loops with the '*' character
                if (shape=="line") //logic and output for displaying line
                {
                    for (j = 0; j < size; j++) //outer loop for adding lines and terminating with an asterick
                    {
                        Console.Write("\n"); 
                        for (k = 0; k < j; k++)//inner loop for adding spaces
                            Console.Write(" ");
                        Console.Write("*");
                    }
                }
                else if (shape == "square") //logic and output for displaying a square
                {
                    for (j = 0; j < size; j++) //outer loop for adding lines
                    {
                        Console.Write("\n"); 
                        for (k = 0; k < size; k++) //inner loop for writing astericks
                            Console.Write("*");
                    }
                }
                else if (shape == "triangle") //logic and output for displaying a triangle
                {
                    for (j = 0; j < size; j++)//outer loop for adding lines and writing final astericks
                    {
                        Console.Write("\n");
                        for (k = 0; k < j; k++) //inner loop for writing astericks
                            Console.Write("*");
                        Console.Write("*");
                    }
                }

                //user to run program again
                Console.Write("\nRun program again? (y/n): ");
                cont = Console.ReadKey().KeyChar; //stores next key press 
            } while (cont == 'y' || cont == 'Y'); //loops program if input was y or Y


        }
    }
}
