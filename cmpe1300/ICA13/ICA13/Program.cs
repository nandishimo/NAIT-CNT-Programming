using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ICA13
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Nandish Patel - ICA13";//title variable

            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);

            int size = GetValue("Enter the size of the array: ", 4, 10);
            int[] array = MakeArray(size);

            Show(array);
            ShowReverse(array);

            Console.WriteLine($"The avaerage is {Average(array)}");
            Console.WriteLine($"The largest value is {Largest(array)}");

            Console.Read();
        }

        static private int GetValue(string request, int min, int max)
        {
            bool valid = false;
            int output = 0;
            do//error handling loop
            {
                Console.Write(request);
                string input = Console.ReadLine();//read user input
                valid = int.TryParse(input, out output); //parse as integer
                if (!valid) //invalid error message
                    Console.WriteLine(input + " is not a valid input.");
                if (output < min || output > max) //invalid range message
                    Console.WriteLine(input + " is outside the accepted range.");
            } while (!valid || output < min || output > max);
            return output;
        }

        static private int[] MakeArray(int size)
        {
            Random random = new Random();
            int[] array;
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 100);
            }

            return array;
        }

        static private void Show(int[] array)
        {
            Console.WriteLine("\nThe array contents...");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = "+array[i]);
            }

        }
        static private void ShowReverse(int[] array)
        {
            Console.WriteLine("\nThe array in reverse...");
            for (int i = array.Length; i > 0; i--)
            {
                Console.WriteLine($"array[{i}] = " + array[i-1]);
            }

        }
        static private double Average(int[] array)
        {
            return Average(array);
        }
        static private double Largest(int[] array)
        {
            return Largest(array);
        }


    }
}
