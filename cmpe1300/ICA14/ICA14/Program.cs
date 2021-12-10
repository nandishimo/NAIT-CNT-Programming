using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA14
{
    class Program
    {
        static void Main(string[] args)
        {
            //1create an array called iArray to contain 20 int values. vary from 1 to 29 inclusive
            Random rand = new Random();
            int[] iArray1 = new int[20] { rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29), rand.Next(1, 29) };
            //display contents as bar graph with method Draw(), with centered text "iArray1 Original Contents"
            Draw("iArray1 Original Contents", iArray1);
            Console.Read();
            //2create int array iArray2. assign iArray 2 a clone of iArray1. assign iArray2[1]=0.
            int[] iArray2 = (int[])iArray1.Clone();
            iArray2[1] = 0;
            //display iArray2 as bar graph with Draw() with centered text "iArray2".
            Draw("iArray2", iArray2);
            Console.Read();
            //3display iArray 1 again using Draw() to allow comparison to iArray2, with centered text "iArray1"
            Draw("iArray1", iArray1);
            Console.Read();
            //4create new array of 40 integers for iArray2
            iArray2 = new int[40];
            //5copy contents of iArray1 to start at index position 10 of iArray2. Display contents of iArray2 using the Draw() method, with the message"iArray2"
            iArray1.CopyTo(iArray2, 10);
            Draw("iArray2", iArray2);
            Console.Read();
            //6clear 10 locations of iArray2 starting at index 10. display contents
            Array.Clear(iArray2, 10, 10);
            Draw("iArray2 Cleared", iArray2);
            Console.Read();
            //7sort iArray1 and display the results using Draw() with the message "Sorted iArray1".
            Array.Sort(iArray1);
            Draw("Sorted iArray1", iArray1);
            Console.Read();
            //8use GetInt() to input a value(from 1 to 29) to search for in iArray1. use the binary search method to find the index of the value
            int found;
            found = Array.BinarySearch(iArray1, GetInt("Enter an integer from 1 to 29 to search for: ", 1, 29));
            if(found < 0)
            {
                Draw("The value could not be found",iArray1);
            }
            else
            {
                Draw("iArray1", iArray1,found);
            }
            Console.Read();
            //if the value could not be found, use AddText() to display a message on the bar graph. If it could be found, change the color of that bar in the graph to red.

            //reverse the contents of iArray1 and display the results on the bar graph display.
            Array.Reverse(iArray1);
            Draw("Reversed iArray1", iArray1);

            Console.Read();
        }

        static void Draw(string text, int[] array, int index=-1)
        {
            CDrawer window = new CDrawer();
            window.Scale = 15;
            window.AddText(text, 50, Color.Gray);
            int i = 1;
            foreach (int j in array)
            {
                if (i == index)
                {
                    window.AddLine(i, 0, i, j, Color.Red, 5);
                }
                window.AddLine(i, 0, i, j, Color.Yellow, 5);
                i += 2;
            }
        }
        static private int GetInt(string prompt, int min, int max)
        {
            bool valid = false;
            int number = 0;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out number);
                if (number < min || number > max)
                    Console.WriteLine("That value is out of range.");
                if (!valid)
                    Console.WriteLine("That entry is not a valid number.");
            } while (!valid || number < min || number > max);
            return number;


        }
    }
}
