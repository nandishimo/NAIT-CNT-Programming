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
            bool again = false;

            do
            {
                Console.Clear();
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
                Console.WriteLine(title);//clear console and write centered title

                int size = GetValue("Enter the size of the array: ", 4, 10);//get size between 4 and 10
                int[] array = MakeArray(size); //create array of desired size

                Show(array); //list array contents
                ShowReverse(array); //llist array contents in reverse

                Console.WriteLine($"\nThe average is {Average(array, size)}");//dispaly average array value
                Largest(array, size, out double largest, out int location);
                Console.WriteLine($"\nThe largest value is {largest} at location {location}");//display largest array valur and location

                again = RunAgain();//check to run program again
            } while (again);
        }

        static private int GetValue(string request, int min, int max)//get value method returns ints
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

        static private int[] MakeArray(int size)//make array method
        {
            Random random = new Random();
            int[] array;
            array = new int[size];
            for (int i = 0; i < size; i++)//fills array with random ints
            {
                array[i] = random.Next(0, 100);
            }

            return array;
        }

        static private void Show(int[] array)//show array method
        {
            Console.WriteLine("\nThe array contents...");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = "+array[i]);//loop through array indices and display contents
            }

        }
        static private void ShowReverse(int[] array)//show reverse method
        {
            Console.WriteLine("\nThe array in reverse...");//loop through array in reverse and display contents
            for (int i = array.Length; i > 0; i--)
            {
                Console.WriteLine($"array[{i}] = " + array[i-1]);
            }

        }
        static private double Average(int[] array, int size)//average array method
        {
            double total = 0;
            for (int i = 0; i < size; i++)//llop through array indices and add all values
            {
                total+=array[i];
            }
            return (total/size);//return total of array values divided by size for average
        }
        static private void Largest(int[] array, int size, out double largest, out int location)//largest array method, pass array and size from main
        {
            largest = array[0];
            location = 0;
            for(int i=0; i<size; i++)
            {
                if (array[i] > largest)//loops through array and check if larger than current "largest" value
                {
                    largest = array[i];//replace largest value in this variable with current array value if the latter is larger
                    location = i;//save location if array value is larger
                }
            }
        }
        static private bool RunAgain()
        {
            bool again=false;
            Console.WriteLine("Would you like to run the program again? Yes or No");//prompt
            string input = Console.ReadLine();
            if (input == "Yes" || input == "yes")// if input is yes ot Yes, again is true, or else, its false and program exits
                again = true;
            return again;

        }


    }
}
