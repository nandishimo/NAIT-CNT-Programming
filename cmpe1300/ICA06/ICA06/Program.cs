using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA06
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables

            //Display title
            string title = "Nandish Patel - ICA06";
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);

            //Create GDIDrawer window of size 800x600

            //query square size from user from 10 to 200. validate as int. use a while loop with error message if invalid

            //query number of squares to draw as integer. check if valid and greater than zero. use a while loop with error message if invalid

            //draw squares of specified size and number in random colors at random locations in the GDIDrawer window

            //repeat program in a do-while loop if user enters 'y' or 'Y'. clear the console andd GDIDrawer window

        }
    }
}
