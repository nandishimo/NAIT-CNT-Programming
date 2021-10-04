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

            Console.WriteLine(title);

            Console.WriteLine("Enter the radius of a circle or sphere: ");
            double.TryParse(Console.ReadLine(), out rad); //parses input as double and assigns it to variable. input will be zero if not a valid 'double'
            if (rad<=0) //checks if rad is less than or equal to zero. if so, exits program.
            {
                Console.Write("\nThe number you have entered is invalid. Expecting a real number greater than 0. Press any key to exit: ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.Write("Please enter the desire calculation [A]rea or [V]olume: "); //user selection
            type = Console.ReadLine();

            if (type == "a"||type=="A") //checks which calculation the user wants and executes it.
            {
                calc = Math.PI * rad * rad; //formula for area of circle
                Console.WriteLine($"The area of a circle with a radius of {rad} is {calc:F3}");
            }
            else if (type == "v"||type=="V")
            {
                calc = Math.PI * rad * rad * rad * 4 / 3; //formula for volume of sphere
                Console.WriteLine($"The volume of a sphere with a radius of {rad} is {calc:F3}");
            }
            else
            {
                Console.WriteLine("You have not entered a valid calculation type. The program will now exit.");
            }


            //End program
            Console.Write("Press <enter> to exit: ");

            Console.Read();
        }
    }
}
