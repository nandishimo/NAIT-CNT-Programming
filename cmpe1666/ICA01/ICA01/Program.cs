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
            //declare variables
            string title = "CMPE 1666 - ICA01 - Winter 2022 - Nandish Patel";
            int size;
            int upper;
            int lower;
            int search;

            //display title
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);
            GetValue(out size, "Please enter the number of values to be generated", 10, 100);//prompt user for size and set limit of 10-100
            GetRange(out upper, out lower, 100, 0); //prompt user for range of values to be generated with 0 andd 100 as bounds
            int[] array = GenerateArray(size, lower, upper); //Generate Array using previously prompted variables
            ShowArray(array); //display array
            do //loop to search for occurences of values in array
            {
                GetValue(out search, "\nPlease enter a value to search for: ", lower, upper);//prompt user for value to search for
                if (1 == CountOccurences(array, search))//checks if 1 occurence is found and displayes grammatically appropriate message
                    Console.WriteLine($"\nThere is 1 instance of {search} in the array.\n");
                else
                    Console.WriteLine($"\nThere are {CountOccurences(array, search)} instances of {search} in the array.\n");//displays number of occurences found in the array

            } while (GetAnswer("Would you like to search again? (y/n): "));//loops as long as user wants to search for more occurences
            Console.Write("\nPress any key to exit...");//exit message
            Console.ReadKey();
        }

        private static bool GetAnswer(string request)
        {
            bool valid = false;
            do
            {
                Console.Write(request);//display prompt
                char answer = Console.ReadKey().KeyChar;
                if (answer == 'y' || answer == 'Y')
                    return true;//y for positive return
                if (answer == 'n' || answer == 'N')
                    return false;//n for negative return
                Console.WriteLine("\nThat is not a valid answer.");//if y or n were not pressed, error message displayed and user is looped
            } while (!valid);
            return false;
        }

        static private void GetValue(out int value, string request, int min, int max)
            //grabbed from previous assignment and modified
        {
            bool valid = false;
            do
            {
                Console.Write(request+$" ({min}, {max}): ");//displays request with acceptable range.
                string input = Console.ReadLine();
                valid = int.TryParse(input, out value);//validate user input 
                if (!valid)
                    Console.WriteLine(input + " is not a valid input.");
                else if (value < min || value > max)//check against max and min
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
                    if (lower < lBound)//check lower limit
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
                    if (upper > uBound)//check upper limit
                    {
                        Console.WriteLine("Values this high cannot be displayed.");
                        valid3 = false;
                    }
                    else
                        valid3 = true;
                } while (!valid3);
                if (lower > upper)//checks if lower value is less than upper value
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
            int[] array = new int[size];//generate array of defined size
            Random rand = new Random();//create random variable
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(lower, upper + 1);//fill array with random numbers within upper and lower bounds
            }
            return array;
        }
        static private void ShowArray(int[] array)//show array method
        {
            Console.WriteLine("\nThe array contents are:");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write(array[i]+", ");//loop through array indices and display contents
            }
            Console.WriteLine(array[array.Length-1]);//display last element without comma
        }

        static private int CountOccurences(int[] array, int value)
        {
            int i = 0;
            foreach(int num in array)//simple iteration through array with counter
            {
                if (num == value)
                    i++;
            }
            return i;
        }
    }



}
