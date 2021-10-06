using System;

namespace Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* *************************************

                * NANDISH PATEL

                * LAB EXAM 1 Q1

                * Exam Code: 85,352

                *************************************/
            //Declare variables
            double Rout;
            double Rin;
            double Vout;
            double Vin;
            double Vliq;

            //Ask user for outer and inner ball radii
            //Validate inputs and exit program if invalid
            Console.Write("Input radius of outer ball (cm): ");
            double.TryParse(Console.ReadLine(), out Rout);
            if (Rout <= 0)
            {
                Console.Write("\nPlease enter a real number greater than zero for the radius. Press any key to exit: ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.Write("\nInput radius of inner ball (cm): ");
            double.TryParse(Console.ReadLine(), out Rin);
            if (Rin <= 0)
            {
                Console.Write("\nPlease enter a real number greater than zero for the radius. Press any key to exit: ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            if (Rout <= Rin)
            {
                Console.Write("\nRadius of outer ball must be greater than radius of inner ball! Press any key to exit: ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }


            //Display outer and inner radii 
            Console.WriteLine("\n\n-------------------------------------------\n");
            Console.WriteLine($"Radius of Outer Ball:\t{Rout:F2} cm");
            Console.WriteLine($"Radius of Inner Ball:\t{Rin:F2} cm");

            //calculate and display volume of outer and inner ball and the liquid (the difference)
            Vout = Math.Pow(Rout, 3) * 4 / 3 * Math.PI;
            Vin = Math.Pow(Rin, 3) * 4 / 3 * Math.PI;
            Vliq = Vout - Vin;
            Console.WriteLine($"Volume of Outer Ball:\t{Vout:F2} cubic cm");
            Console.WriteLine($"Volume of Inner Ball:\t{Vin:F2} cubic cm");
            Console.WriteLine($"Volume of Liquid:\t{Vliq:F2} cubic cm ");
            //End program 
            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey();


        }
    }
}
