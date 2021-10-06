/* *************************************

    * NANDISH PATEL

    * LAB EXAM 1 Q2

    * Question Code: 775

    *************************************/
using System;

namespace Exam_1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Title and variables

            //discount constant variables
            const double s = 0.05;
            const double q = 0.12;
            const double v = 0.17;

            int nDrinks; //for user entry
            int packs;//for calcs
            int singles;//for calcs

            //for calcs of cost of packs, singles, total, discount
            double cPacks;
            double cSingles;
            double cTotal;
            double cDisc=0;//default discount will be zero

            string coupon;//for user coupon entry
            string title = "Exam 1, Question 2 - Nandish Patel";
            Console.SetCursorPosition(Console.WindowWidth / 2 - title.Length / 2, 0);
            Console.WriteLine(title);

            //Ask user for # of energy drinks to purchase. Detect invalid inputs
            Console.Write("\nEnter the number of energy drinks to purchase: ");
            int.TryParse(Console.ReadLine(), out nDrinks);
            if(nDrinks <=0)//invalid input handling for number of drinks
            {
                Console.WriteLine("\nEnter a integer number greater than zero. Press any key to exit . . . ");
                Console.Read();
                System.Environment.Exit(1);
            }

            //Ask user for discount coupon. Invalid or no code means no discount.
            Console.Write("\nEnter your coupon code. Enter 'n' if no coupon: ");
            coupon = Console.ReadLine();//assign user input to string 'coupon'

            //Calculate number of 8-packs and singles required.
            packs = nDrinks / 8;//integer division for 8-packs
            singles = nDrinks % 8;//remainder of division for singles

            //Calculate total cost and apply discount
            cPacks = packs * 7.95; //calc cost of packs
            cSingles = singles * 1.49; //calc cost of singles
            cTotal = cPacks + cSingles; //calc total cost
            if (coupon == "s") { cDisc = cTotal*s; }//determine which discount to apply based on the user input
            else if (coupon == "q") { cDisc = cTotal * q; }
            else if (coupon == "v") { cDisc = cTotal * v; }
            cTotal = cTotal-cDisc;//calc total cost after discount

            //Display number of packs and singles to purchase, and the total cost
            Console.WriteLine($"\nTo buy {nDrinks} Energy Drinks, you need {packs} pack(s) and {singles} bottle(s).");
            Console.WriteLine($"\nThe total price is {cTotal:C} for the drinks.");

            //If a valid coupon was entered, display savings.
            if (cDisc != 0)//check if non-zero discount was applied and display.
            {
                Console.WriteLine($"\nYou saved {cDisc:C} with your coupon!");
            }

            //End program
            Console.Write("\nPress the <ENTER> key to exit . . . ");
            Console.Read();


        }
    }
}
