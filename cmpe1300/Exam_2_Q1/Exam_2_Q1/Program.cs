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
            int runs;
            int i;
            int j;
            int k;
            string sentence;
            string display;
            bool valid = false;

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
            for(i=0; i<runs; i++)
            {
                //ask user for a sentence and display the sentance number starting at 1
                //do-while sentence validation loop
                do
                {
                    Console.Write($"\nEnter sentence #{i+1}: ");
                    sentence = Console.ReadLine();
                    foreach(char ch in sentence)
                    {
                        if (char.IsDigit(ch))
                        {
                            valid = true;
                            display = "";
                            j = ch;
                            for (k = 0; k < j; k++)
                            {
                                display = (display + $"{ch}");
                            }
                            Console.Write($"{display}");
                        }

                    }
                } while (!valid);
                

                //sentence must include a number to be valid
                //user can enter *(constant) to use the default sentence 'I like to eat 3 pies'
                //each number n found in the sentence must be displayed n number of times
                //foreach loop
                //each digit character stored as int and displayed that many times



            }



            Console.Read();
            //exit program after specified runs and upon pressing a key



        }
    }
}
