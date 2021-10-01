using System;

namespace ICA02
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables for title, drink name, drink cost, drink qty
            string title = "Nandish Patel - Assignment 2";
            string drink = "";
            double ctwelve = 0;
            double csix = 0;
            double csingle = 0;
            int twelve = 0;
            int six = 0;
            int single = 0;
            int cans = 0;

            //write centered title to console
            Console.SetCursorPosition(Console.WindowWidth / 2 - title.Length / 2, 0);
            Console.WriteLine(title);

            //name of energy drink input
            Console.Write("\nEnter the name of your energy drink: ");
            drink = Console.ReadLine();

            //input cost of 12pack, 6pack and single drinks
            Console.Write($"Enter the cost for a 12-pack of {drink}: ");
            double.TryParse(Console.ReadLine(), out ctwelve);

            Console.Write($"Enter the cost for a 6-pack of {drink}: ");
            double.TryParse(Console.ReadLine(), out csix);

            Console.Write($"Enter the cost for a single can of {drink}: ");
            double.TryParse(Console.ReadLine(), out csingle);

            //input number of cans to purchase
            Console.Write($"Enter number of desired cans of {drink}: ");
            int.TryParse(Console.ReadLine(), out cans);

            //insert dash line
            Console.WriteLine("\n-----------------------------------------------------------------");

            //calculate and display number of 12-packs, 6-packs, and single cans
            twelve = cans / 12;
            six = cans % 12 / 6;
            single = cans % 12 % 6;
            Console.WriteLine($"\n12-packs to purchase: {twelve} @ {ctwelve:C} = {(ctwelve * twelve):C}");
            Console.WriteLine($"6-packs to purchase: {six} @ {csix:C} = {(csix * six):C}");
            Console.WriteLine($"Single cans to purchase: {single} @ {csingle:C} = {(csingle * single):C}");

            //display total cost
            Console.WriteLine($"\nYour total cost is {(ctwelve * twelve + csix * six + csingle * single):C}!");

            //end program
            Console.WriteLine("\nPress <enter> to exit...");
            Console.Read();

        }
    }
}
