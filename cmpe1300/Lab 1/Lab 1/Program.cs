using System;

namespace Lab_1
{
    class Program
    {
        static void Main()
        {
            //Declare variables including given values
            string title = "Nandish Patel - Lab 1 - Cell Phone Data Calculator";
            //Number of Bytes per Unit
            int bPerG = 1073741824;
            int bPerM = 1048576;
            int bPerK = 1024;
            //Cost per Unit
            double cPerG = 12.00;
            double cPerM = 0.25;
            double cPerK = 0.02;
            double cPerB = 0.01;
            double nineOneOne = 0.95;
            double sAccess = 6.95;
            double sTotal;
            double sTotal2;
            //#of bytes for calcs
            long gTotal;
            long mTotal;
            long kTotal;
            long bTotal;
            //cost of each byte type
            double gCost;
            double mCost;
            double kCost;
            double bCost;

            //Set title
            Console.SetCursorPosition(Console.WindowWidth / 2 - title.Length / 2,0); //positions cursor for centered title
            Console.WriteLine(title);


            //Ask for user input (# of bytes)
            Console.Write("\nEnter the number of Bytes used: ");
            long.TryParse(Console.ReadLine(), out long bInput); //parse user input as long
            
            //Calculate number of GB, MB, kB, and Bytes used
            gTotal = bInput / bPerG;            //integer division for GB
            mTotal = bInput % bPerG / bPerM;    //integer remainder division for MB
            kTotal = bInput % bPerM / bPerK;    //integer remainder division for kB
            bTotal = bInput % bPerK;            //integer remainder for Bytes

            //Calculate cost for each category
            gCost = gTotal * cPerG; //GB cost
            mCost = mTotal * cPerM; //MB cost
            kCost = kTotal * cPerK; //kB cost
            bCost = bTotal * cPerB; //Byte cost

            //Display qty and cost, organized into coloumns including color change and lines
            Console.ForegroundColor = ConsoleColor.Yellow;                                      //Change text color to yellow
            Console.WriteLine("\nAmount\tUnit\tCost/Unit\tTotal");                            //write table header
            Console.ForegroundColor = ConsoleColor.White;                                       //change text color to white
            Console.WriteLine($"\n{gTotal}" + $"\tGB" + $"\t{cPerG:C}" + $"\t\t{gCost:C}");   //display values for GB
            Console.WriteLine($"{mTotal}" + $"\tGB" + $"\t{cPerM:C}" + $"\t\t{mCost:C}");     //display values for MB
            Console.WriteLine($"{kTotal}" + $"\tGB" + $"\t{cPerK:C}" + $"\t\t{kCost:C}");     //display values for kB
            Console.WriteLine($"{bTotal}" + $"\tGB" + $"\t{cPerB:C}" + $"\t\t{bCost:C}");     //display values for Bytes
            Console.WriteLine("\t\t\t\t-------------");

            //Was going to use something like the following for displaying data but I wasnt sure if we covered it in class
            //Console.WriteLine(string.Format("{0,-15}{1,-10}{2,-15}{3,-15}", "Amount", "Unit", "Cost/Unit", "Total"));
            //Console.WriteLine(string.Format("{0,-15}{1,-10}{2,-15}{3,-15}", $"\n{gTotal}", "GB", $"{cPerG:C}", $"{gCost:C}"));
            //Console.WriteLine(string.Format("{0,-15}{1,-10}{2,-15}{3,-15}", "Amount", "Unit", "Cost/Unit", "Total"));
            //Console.WriteLine(string.Format("{0,-15}{1,-10}{2,-15}{3,-15}", "Amount", "Unit", "Cost/Unit", "Total"));

            //Display additional fees and taxes and calculate final total

            sTotal = gCost + mCost + kCost + bCost; //subtotal calculation
            Console.WriteLine($"SubTotal:\t\t\t{sTotal:C}");
            Console.WriteLine($"\n911 Access Fee:\t\t\t{nineOneOne:C}");
            Console.WriteLine($"\nSystem Access Fee:\t\t{sAccess:C}");
            sTotal2 = sTotal + nineOneOne + sAccess; //subtotal plus fees
            Console.WriteLine($"\nTotal before GST:\t\t{sTotal2*0.05:C}");
            Console.WriteLine("\t\t\t\t-------------");
            Console.WriteLine($"Total for Data:\t\t\t{sTotal2 * 1.05:C}");

            //End program
            Console.Write("\nPress any key to exit:");
            Console.ReadKey();

        }
    }
}
