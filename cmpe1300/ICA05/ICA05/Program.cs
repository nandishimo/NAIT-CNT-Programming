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
            if (!int.TryParse(Console.ReadLine(), out int D))
            {
                Console.WriteLine("\nYou must enter a valid integer value. The program will now exit... ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            //user input x center value as integer. check if valid, exit if not.
            Console.Write("Enter a integer value for x-center: ");
            if (!int.TryParse(Console.ReadLine(), out int X))
            {
                Console.WriteLine("\nYou must enter a valid integer value. The program will now exit... ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            //user input y center value as integer. check if valid, exit if not.
            Console.Write("Enter a integer value for y-center: ");
            if (!int.TryParse(Console.ReadLine(), out int Y))
            {
                Console.WriteLine("\nYou must enter a valid integer value. The program will now exit... ");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            //limit diameter from 10to 100, modify if required
            D = D < 10 ? 10 : D;
            D = D > 100 ? 100 : D;

            //limit x so circle is in window, modify if required
            X = (X + D / 2) > 300 ? 300 - D / 2 : X;
            X = (X - D / 2) < 0 ? 0 + D / 2 : X;

            //limit y so circle is in window, modify if required
            Y = (Y + D / 2) > 300 ? 300 - D / 2 : Y;
            Y = (Y - D / 2) < 0 ? 0 + D / 2 : Y;

            //use final values to display red circle to the window
            window.AddEllipse(X, Y, D, D, Color.Red);

            //pause program then exit

            Console.ReadKey();





        }
    }
}
