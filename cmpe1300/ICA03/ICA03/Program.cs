using System;

namespace ICA03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string title = "Nandish Patel - Assignment 3";
            double rad = 0;
            string type = "";
            double calc = 0;

            Console.SetCursorPosition(Console.WindowWidth / 2 - title.Length / 2, 0);
            Console.WriteLine(title);

            Console.Write("\nEnter the radius of a circle or sphere: ");
            double.TryParse(Console.ReadLine(), out rad); //parses input as double and assigns it to variable. input will be zero if not a valid 'double'
            if (rad<=0) //checks if rad is less than or equal to zero. if so, exits program.
            {
                Console.Write("\n\nThe number you have entered is invalid. Expecting a real number greater than 0. Press any key to exit: ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.Write("\n\nPlease enter the desire calculation [area] or [volume]: "); //user selection
            type = Console.ReadLine();
            type = type.ToLower(); //convert to lower case

            if (type == "area") //checks which calculation the user wants and executes it.
            {
                calc = Math.PI * rad * rad; //formula for area of circle
                Console.WriteLine($"\nThe area of a circle with a radius of {rad} is {calc:F3}");
            }
            else if (type == "volume")
            {
                calc = Math.PI * rad * rad * rad * 4 / 3; //formula for volume of sphere
                Console.WriteLine($"\nThe volume of a sphere with a radius of {rad} is {calc:F3}");
            }
            else //invalid entry handling
            {
                Console.WriteLine("\nYou have not entered a valid calculation type. Expecting either [area] or [volume]. The program will now exit.");
            }


            //End program
            Console.Write("\nPress any key to exit: ");

            Console.ReadKey();
        }
    }
}
