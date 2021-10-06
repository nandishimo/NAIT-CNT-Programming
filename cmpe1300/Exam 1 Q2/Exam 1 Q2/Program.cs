using System;

namespace Exam_1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* *************************************

                * NANDISH PATEL

                * LAB EXAM 1 Q2

                * Question Code: 775

                *************************************/

            //Title and variables
            const double s = 0.05;
            const double q = 0.12;
            const double v = 0.17;

            int nDrinks;
            int packs;
            int singles;

            double cPacks;
            double cSingles;
            double cTotal;
            double cDisc=0;

            string coupon;
            string title = "Exam 1, Question 2 - Nandish Patel";
            Console.SetCursorPosition(Console.WindowWidth / 2 - title.Length / 2, 0);
            Console.WriteLine(title);

            //Ask user for # of energy drinks to purchase. Detect invalid inputs
            Console.Write("Enter the number of energy drinks to purchase: ");
            int.TryParse(Console.ReadLine(), out nDrinks);

            //Ask user for discount coupon. Invalid or no code means no discount.
            Console.Write("\nEnter your coupon code. Enter 'n' if no coupon: ");
            coupon = Console.ReadLine();

            //Calculate number of 8-packs and singles required.
            packs = nDrinks / 8;
            singles = nDrinks % 8;

            //Calculate total cost and apply discount
            cPacks = packs * 7.95;
            cSingles = singles * 1.49;
            cTotal = cPacks + cSingles;
            if (coupon == "s") { cDisc = cTotal*s; }
            else if (coupon == "q") { cDisc = cTotal * q; }
            else if (coupon == "v") { cDisc = cTotal * v; }
            cTotal = cTotal-cDisc;

            //Display number of packs and singles to purchase, and the total cost
            Console.WriteLine($"\nTo buy {nDrinks} Energy Drinks, you need {packs} pack(s) and {singles} bottle(s).");
            Console.WriteLine($"\nThe total price is {cTotal:C} for the drinks.");
            if(cDisc!=0)
            {
                Console.WriteLine($"\nYou saved {cDisc:C} with your coupon!");
            }


            //If a valid coupon was entered, display savings.

            //End program
            Console.Write("\nPress the <ENTER> key to exit . . . ");
            Console.Read();


        }
    }
}
