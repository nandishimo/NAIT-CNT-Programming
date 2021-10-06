/* *************************************

    * NANDISH PATEL

    * LAB EXAM 1 Q1

    * Exam Code: 85,352

    *************************************/
using System;

namespace Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write title and Declare variables
            string title = "Exam 1, Question 1 - Nandish Patel";
            Console.SetCursorPosition(Console.WindowWidth / 2 - title.Length / 2, 0);
            Console.WriteLine(title);

            double Rout;
            double Rin;
            double Vout;
            double Vin;
            double Vliq;

            //Ask user for outer and inner ball radii
            //Validate inputs and exit program if invalid
            Console.Write("\nInput radius of outer ball (cm): ");
            double.TryParse(Console.ReadLine(), out Rout);//parsing user input as double and assigning to outer radius
            if (Rout <= 0)//invalid entry handling for outer radius
            {
                Console.Write("\nPlease enter a real number greater than zero for the radius. Press any key to exit: ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.Write("\nInput radius of inner ball (cm): ");
            double.TryParse(Console.ReadLine(), out Rin);//parsing user input as double and assigning to inner radius
            if (Rin <= 0)//invalid entry handling for inner radius
            {
                Console.Write("\nPlease enter a real number greater than zero for the radius. Press any key to exit: ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            if (Rout <= Rin)//invalid entry handling so we dont calculate a zero or negative volume
            {
                Console.Write("\nRadius of outer ball must be greater than radius of inner ball! Press any key to exit: ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }


            //Display outer and inner radii 
            Console.WriteLine("\n\n-------------------------------------------\n");//formatting
            Console.WriteLine($"Radius of Outer Ball:\t{Rout:F2} cm");//display outer radius
            Console.WriteLine($"Radius of Inner Ball:\t{Rin:F2} cm");//display inner radius

            //calculate and display volume of outer and inner ball and the liquid (the difference)
            Vout = Math.Pow(Rout, 3) * 4 / 3 * Math.PI;//calculate volume of outer ball
            Vin = Math.Pow(Rin, 3) * 4 / 3 * Math.PI;//calculate volume of inner ball
            Vliq = Vout - Vin; //calculate volume of liquid ball
            Console.WriteLine($"Volume of Outer Ball:\t{Vout:F2} cubic cm");//display volume of outer ball
            Console.WriteLine($"Volume of Inner Ball:\t{Vin:F2} cubic cm");//display volume of inner ball
            Console.WriteLine($"Volume of Liquid:\t{Vliq:F2} cubic cm ");//display volume of liquid
            
            //End program 
            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey();


        }
    }
}
