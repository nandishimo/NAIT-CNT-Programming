using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA01
{
    class Program
    {
        static void Main(string[] args)
        {
            //display title
            string title = "CMPE 1666 - ICA01 - Winter 2022 - Nandish Patel";
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);
            GetValue(out int size, "Please enter the number of values to be generated: ", 10, 100);
            GetRange(out int upper, out int lower, 0, 100);
            int[] array = GenerateArray(size, lower, upper);
            ShowArray(array);
            Console.Read();
        }

        
        static private void GetValue(out int value, string request, int min, int max)
            //grabbed from previous assignment and modified
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = int.TryParse(input, out value);//validate user input 
                if (!valid)
                    Console.WriteLine(input + " is not a valid input.");
                if (value < min || value > max)//check against max and min
                    Console.WriteLine(input + " is outside the accepted range.");
            } while (!valid || value < min || value > max);//loop until valid output is created
        }

        private static void GetRange(out int upper, out int lower, int uBound, int lBound)
            //grabbedd from previous assignment and modified
        {
            //pass user input to getvalue. return upper and lower range values as doubles
            bool valid1 = false;
            bool valid2 = false;
            bool valid3 = false;

            do//main getrange loop
            {
                do//lower range validation loop
                {
                    GetValue(out lower, "Please enter a lower range: ", 0, 100);
                    if (lower < lBound)//limit of -40 for range
                    {
                        Console.WriteLine("Values this low cannot be displayed.");
                        valid2 = false;
                    }
                    else
                        valid2 = true;
                } while (!valid2);

                do//upper range validation loop
                {
                    GetValue(out upper, "Please enter an upper range: ", 0, 100);
                    if (upper > uBound)//limit of 40 for range
                    {
                        Console.WriteLine("Values this high cannot be displayed.");
                        valid3 = false;
                    }
                    else
                        valid3 = true;
                } while (!valid3);
                if (lower > upper)//lower less than upper validation loop
                {
                    Console.WriteLine("Lower must be less than Upper range.");
                    valid1 = false;
                }
                else
                    valid1 = true;


            } while (!valid1 || !valid2 || !valid3);//all validation loops must check out for main loop to pass

        }

        static private int[] GenerateArray(int size, int lower, int upper)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(lower, upper + 1);
            }
            return array;
        }
        static private void ShowArray(int[] array)//show array method
        {
            Console.WriteLine("\nThe array contents...");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = " + array[i]);//loop through array indices and display contents
            }

        }
    }



}
