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
                Console.Clear();
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
            app.AddText($"{rounded:C}", 20, 300, 50, 200, 25, Color.White);


            //draw bills and coins
            /*count based 5x5 grid
             *      count       position        coordinates                     equ'n 
             *      0           1,1             100,100             x=100+count*400/2000 , y=100+count*100
             *      1           1,2             100,200             x=100+count*400/2000 , y=100+count*100
             *      2           1,3             100,300             x=100+count*400/2000 , y=100+count*100
             *      3           1,4             100,400             x=100+count*400/2000 , y=100+count*100
             *      4           1,5             100,500             x=100+count*400/2000 , y=100+count*100
             *      5           2,1             500,100             x=100+count*400/2000 , y=100+count*100
             *      6           2,2             500,200             x=100+count*400/2000 , y=100+count*100
             *      7           2,3             500,300             x=100+count*400/2000 , y=100+count*100
             *      8           2,4             500,400             x=100+count*400/2000 , y=100+count*100
             *      9           2,5             500,500             x=100+count*400/2000 , y=100+count*100
             *      if(count<5)
             *          x=100
             *          y=(count*100)+100
             *      else
             *          x=500
             *          y=(count-4)*100
            */ 
            int count = 0;
            if (fifty > 0)
            {
                drawBill(ref app, Color.FromArgb(235,158,153), count, "$50", fifty);
                count++;
            }
            if (twenty > 0)
            {
                drawBill(ref app, Color.FromArgb(166, 215, 170), count, "$20", twenty);
                count++;
            }
            if (ten > 0)
            {
                drawBill(ref app, Color.FromArgb(187, 170, 230), count, "$10", ten);
                count++;
            }
            if (five > 0)
            {
                drawBill(ref app, Color.FromArgb(153, 163, 206), count, "$5", five);
                count++;
            }
            if (toon > 0)
            {
                drawCoin(ref app, Color.Silver, count, "$2", toon,100);
                drawCoin(ref app, Color.Gold, count, "$2", toon,60);
                count++;
            }
            if (loon > 0)
            {
                drawCoin(ref app, Color.Gold, count, "$1", loon,100);
                count++;
            }
            if (quart > 0)
            {
                drawCoin(ref app, Color.Silver, count, "$0.25", quart,85);
                count++;
            }
            if (dime > 0)
            {
                drawCoin(ref app, Color.Silver, count, "0.10", dime,60);
                count++;
            }
            if (nick > 0)
            {
                drawCoin(ref app, Color.Gray, count, "0.05", nick,70);
            }

            //display value and quantity of each denomination
            Console.Read();
        }
        private static void drawBill(ref CDrawer window, Color colour, int count, string denom, int qty)
            //helper mthod to draw bills, pass bill denomination, qty and color
        {
            int x,y;
            //find coordinates based on count of denominations displayed so far
            if (count < 5)
            {
                x = 100;
                y = (count * 100) + 90;
            }
            else
            {
                x = 500;
                y = ((count - 5) * 100)+90;
            }
            //draw bills and add text based on passed information
            window.AddRectangle(new Rectangle(new Point(x, y), new Size(150, 75)), colour, 2, Color.Black);
            window.AddText($"{denom} x {qty}", 10, new Rectangle(new Point(x, y), new Size(150, 75)));
        }
        private static void drawCoin(ref CDrawer window, Color colour, int count, string denom, int qty, int size)
            //helper function to draw coins, pass coin denomination, qty, size and color
        {
            int x, y;
            //find coordinate to draw coin based on denominations drawn so far
            if (count < 5)
            {
                x = 100;
                y = (count * 100) + 90;
            }
            else
            {
                x = 500;
                y = ((count - 5) * 100) + 90;
            }
            //draw coin and add text based on passed information
            window.AddEllipse(x + 75-size/2, y + 50-size/2, size, size, colour, 2, Color.Black); 
            window.AddText($"{denom} x {qty}", 10, new Rectangle(new Point(x+75-size/2, y+50-size/2), new Size(size, size)));
        }
    }
}
