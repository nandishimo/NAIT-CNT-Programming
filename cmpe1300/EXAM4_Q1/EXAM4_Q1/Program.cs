/* *************************************

   * NANDISH PATEL

   * LAB EXAM 4 Q1

   * Question Code: 51,997

   *************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM4_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Nandish Patel - Exam 4 Q1";
            int number;
            bool again = true;
            bool valid = false;
            int i = 0;
            int j = 0;
            //display centered title
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length;
            Console.WriteLine(title);

            //prompt user to enter an integer. use loop to force user to enter valid integer from 2 to 10.
            //handle exceptions
            do
            {
                valid = false;//intial validity is false
                Console.Write("\nPlease enter number of strings to enter (2-10): ");//prompt user
                valid = int.TryParse(Console.ReadLine(), out number);//check if integer is valid
                if (!valid)
                    Console.WriteLine("\nThat is not a valid integer.");//error message if not a valid integer
                if (number < 2 || number > 10)
                    Console.WriteLine("\nThat value is out of range.");//error messgae if not between 2 and 10
            } while (!valid||number<2||number>10);

            string[] words = new string[number];//create new string of size specificied

            //prompt user to input the strings into an array.
            for (i = 0; i < number; i++)//loop through indices of array and assign strings as prmpted 
            {
                Console.Write($"\nEnter string#{i+1}: ");
                words[i] = Console.ReadLine();
            }

            //find and display the longest string stored.

            foreach(string word in words)//loop through array to find longest word by comparing lengths and saving the index of longest word
            {
                if (word.Length > j)
                {
                    j = word.Length;
                    i = Array.IndexOf(words, word);
                }
            }

            Console.WriteLine($"\nThe longest string is \"{words[i]}\"");//display longest word

            //display the strings stored in reverse order.
            for (i=number-1; i>-1; i--)//loop starting at end of array and moving back/ display each string
            {
                Console.WriteLine();
                Console.WriteLine(words[i]);

            }
            Console.Read();
            

        }
    }
}
