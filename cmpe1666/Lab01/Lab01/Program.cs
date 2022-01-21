/*
 LAB01 - CMPE1666 - NANDISH PATEL
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {

            
            bool bueno = false;
            double raw;

            //prompt user for currency to convert
            do
            {
                Console.WriteLine("How much money would you like to convert ?");
                //parse and display error message and check for invalid entry
                bueno = double.TryParse(Console.ReadLine(), out raw);
                if (!bueno)
                {
                    Console.WriteLine("Your entry is invalid. Press <enter> to try again... ");
                    Console.ReadKey(true);
                }
            } while (!bueno);
            //round value to nearest nickel and display
            double rounded = Math.Round(raw*20)/20;
            Console.WriteLine($"User entry of {raw:C} interpreted and rounded to {rounded:C}");
            //calculate required amount of each denomination and display
            //use modulus to get remainder
            double remain;
            int fifty = (int)(rounded / 50);
            remain = rounded % 50;
            int twenty = (int)(remain / 20);
            remain %= 20;
            int ten = (int)(remain / 10);
            remain %= 10;
            int five = (int)(remain / 5);
            remain %= 5;
            int toon = (int)(remain / 2);
            remain %= 2;
            int loon = (int)remain;
            remain %= 1;
            int quart = (int)(remain / 0.25);
            remain %= 0.25;
            int dime = (int)(remain / 0.1);
            remain %= 0.1;
            int nick = (int)(remain / 0.05);

            //display results in console
            Console.WriteLine($"Fifty x {fifty}\nTwenty x {twenty}\nTen x {ten}\nFive x {five}\nToonie x {toon}\nLoonie x {loon}\nQuarter x {quart}\nDime x {dime}\nNickel x {nick}");

            //create new drawer window
            CDrawer app = new CDrawer();


            //draw bills and coins
            int count = 0;
            if (fifty > 0)
            {
                app.AddRectangle(50, 100 + 150 * count, 200, 100, Color.Red, 2, Color.Black);
                count++;
            }
            if (twenty > 0)
            {
                app.AddRectangle(50, 100 + 150 * count, 200, 100, Color.Green, 2, Color.Black);
                count++;
            }
            if (ten > 0)
            {
                app.AddRectangle(50, 100 + 150 * count, 200, 100, Color.Purple, 2, Color.Black);
                count++;
            }
            if (five > 0)
            {
                app.AddRectangle(50, 100 + 150 * count, 200, 100, Color.Blue, 2, Color.Black);
            }
            count = 0;
            if (toon > 0)
            {
                app.AddEllipse(500, 100 * count, 100, 100, Color.Silver, 2, Color.Black);
                app.AddEllipse(525, 25+100 * count, 50, 50, Color.Gold, 1, Color.Black);
                count++;
            }
            if (loon > 0)
            {
                app.AddEllipse(500, 100 * count, 100, 100, Color.Gold, 2, Color.Black);
                count++;
            }
            if (quart > 0)
            {
                app.AddEllipse(500, 100 * count, 100, 100, Color.Silver, 2, Color.Black);
                count++;
            }
            if (dime > 0)
            {
                app.AddEllipse(525, 25+100 * count, 50, 50, Color.Silver, 2, Color.Black);
                count++;
            }
            if (nick > 0)
            {
                app.AddEllipse(525, 25 + 100 * count, 50, 50, Color.Gray, 2, Color.Black);
            }



            //display value and quantity of each denomination


            Console.Read();
        }
        private static void drawBill(ref CDrawer window, string denom, int qty)
        {
            Point start = new Point(5, 5);
            Size sBill = new Size(30, 15);
            Rectangle bill = new Rectangle(start, sBill);
            window.AddRectangle(bill, Color.Red, 2, Color.Black);
        }
    }
}
