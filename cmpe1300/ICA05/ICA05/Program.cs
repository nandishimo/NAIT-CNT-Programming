using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA05
{
    class Program
    {
        static void Main(string[] args)
        {
            //prgram title
            string title = "Nandish Patel - ICA05\n";
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);

            //create 300x300 drawer window
            CDrawer window = new CDrawer(300, 300);

            //user input a circle diameter. check for valid integer value. exit if not
            Console.Write("Enter a integer circle diameter: ");
            if (!int.TryParse(Console.ReadLine(), out int D))//grabs user input and parses as integer, exit program if not integer
            {
                Console.WriteLine("\nYou must enter a valid integer value. The program will now exit... ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            //user input x center value as integer. check if valid, exit if not.
            Console.Write("Enter a integer value for x-center: ");
            if (!int.TryParse(Console.ReadLine(), out int X))//grabs user input and parses as integer, exit program if not integer
            {
                Console.WriteLine("\nYou must enter a valid integer value. The program will now exit... ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            //user input y center value as integer. check if valid, exit if not.
            Console.Write("Enter a integer value for y-center: ");
            if (!int.TryParse(Console.ReadLine(), out int Y))//grabs user input and parses as integer, exit program if not integer
            {
                Console.WriteLine("\nYou must enter a valid integer value. The program will now exit... ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            //limit diameter from 10to 100, modify if required
            D = D < 10 ? 10 : D; //if diameter less than 10, set diameter to 10
            D = D > 100 ? 100 : D; //if diameter greater than 100, set diameter to 100

            //limit x so circle is in window, modify if required
            X = (X + (D / 2)) > 300 ? (300 - (D / 2)) : X; //if right edge is further than 300, adjust X so its at 300
            X = (X - (D / 2)) < 0 ? (0 + (D / 2)) : X; //if left edge is further than 0, adjust X so its at 0

            //limit y so circle is in window, modify if required
            Y = (Y + (D / 2)) > 300 ? (300 - (D / 2)) : Y; //if bottom edge is lower than 300, adjust Y so its at 300
            Y = (Y - (D / 2)) < 0 ? (0 + (D / 2)) : Y; //if upper edge is higher than 0, adjust Y so its at 0

            //use final values to display red circle to the window
            Console.WriteLine($"\nFinal diameter is {D}.");//display final diamter b/c why not
            Console.WriteLine($"\nFinal center coordinate is ({X},{Y})."); //display final x,y b/c why not
            window.AddEllipse(X-D/2, Y-D/2, D, D, Color.Red); //draw elipse with final values

            //pause program then exit

            Console.WriteLine("\nPress any key to exit...");

            Console.ReadKey();





        }
    }
}
