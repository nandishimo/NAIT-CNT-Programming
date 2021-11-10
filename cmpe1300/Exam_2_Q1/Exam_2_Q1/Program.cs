/* *************************************

   * NANDISH PATEL

   * LAB EXAM 2 Q1

   * Question Code: 83,678

   *************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Exam_2_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string title = "Nandish Patel Exam 2 Numbers";
            int runs;//number of runs
            int i;//counter
            int j;//stores number that the char digit represents
            int k;//counter
            string sentence;//stores the users sentence
            string display;//stores the number of each numbers from the users sentence
            bool valid = false;//sentence is valid? starts false
            const string star = "*";

            //display title
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);

            //ask user how many times to run program. must be a valid number between 3 and 9
            //do-while input validation loop
            do
            {
                Console.Write("How many times would you like to run the program? ");
            } while (!int.TryParse(Console.ReadLine(), out runs) || runs < 3 || runs > 9);



            //while program loop
            for(i=0; i<runs; i++)//loop until the counter reaches deserired number of runs
            {
                //ask user for a sentence and display the sentance number starting at 1
                //do-while sentence validation loop
                do
                {
                    Console.Write($"\nEnter sentence #{i+1}: ");
                    sentence = Console.ReadLine();
                    //user can enter *(constant) to use the default sentence 'I like to eat 3 pies'
                    if (sentence == star)//sub in the below sentence if user enters "*"
                        sentence = "I like to eat 3 pies";
                    foreach(char ch in sentence)//scan through each character in sentence for numbers
                    {
                        valid = false;//set sentence validity to be false initially
                        if (char.IsDigit(ch))//if digit is found, enter procedure to display numbers
                        {
                            //sentence must include a number to be valid
                            valid = true;//sentence is valid if number is found
                            display = "";//initial string is blank
                            j = ch-48;//convert ascii number of character to integer
                            //each number n found in the sentence must be displayed n number of times
                            //foreach loop
                            for (k = 0; k < j; k++)//concatenate number of numbers to string
                            {
                                display = (display + $"{ch}");
                            }
                            Console.Write($"{display}");//display string
                        }

                    }
                } while (!valid);//loop again if sentence is invalid

            }

            //exit program after specified runs and upon pressing a key
            Console.Write("\nPress any key to exit.");
            Console.ReadKey();
            



        }
    }
}
