/* *************************************

   * NANDISH PATEL

   * LAB EXAM 4 Q2

   * Question Code: 750

   *************************************/
/**** CMPE 1300 - Fall 2021****
 * 
 * 
 * Lab Exam 4 Question 2
 * 
 * You will add the implementation of methods in this program to achieve the requirements of Question2
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le4Q2Fall2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array containing the names of ten students
            string[] names = {"Jenny Smith", "Jackie Rubber", "Timmy Cameron","Jacky Farmer",
                            "Melani Jasper", "Winnie Belmont", "Harry Watson", "James watt",
                             "Annie Ohms", "Jimmy Ampere"};

            /*Declaration of other variables 192.197.128.18*/

            int[] marks = new int[10]; //Each element of this array will contain the marks 
                                       //for the student whose name in the corresponding element of array names 

            double aveMarks; //To hold the average of the values in array marks

            Random rand = new Random();//rand will be the random number generator 16933
            /*Call To method GenerateMarks()
             * The call will cause the array marks to be filled in with a number of random values 
             * in the range one-thirty, generated using the Random object "rand"
             * 2021-12-15T13:34:30-07:00             */
            GenerateMarks(ref marks, rand);


            /*Call to method CalculateAverageMarks(). This call will return the average of the 
               values in the array "marks". The returned value is of type double.
             */
            aveMarks = CalculateAverageMarks(marks);


            /**Displaying All students Info - The first few lines are only for the headings*/

            Console.WriteLine("Info. about All Students:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Names \t\t Marks");
            Console.WriteLine("----- \t\t -----");

            /*Call to method DisplayMarksInfo(). This call will cause the names and marks of all the students
             * to be displayed, as illustrated in the sample run.
             * 
             */
            DisplayMarksInfo(names, marks);

            //Adding some addition spaces in the output
            Console.WriteLine();
            Console.WriteLine();

            //Displaying the average mark
            Console.WriteLine($"Average Marks: {aveMarks:F2}");
            Console.WriteLine();

            /*Displaying Info for students scoring the average marks or higher - Again thehe first few lines are only for the headings*/
            Console.WriteLine("Info. about Students having scored average marks or higher:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Names \t\t Marks");
            Console.WriteLine("----- \t\t -----");


            /*Call to method DisplayHigherMarksInfo()
            This call to the method will display the names and marks of all students
            having scored higher than average marks
            */
            DisplayHigherMarksInfo(names, marks, aveMarks);

        }



        /*** Write the implementation of the missing methods here ****/
        static private void GenerateMarks(ref int[] marks, Random rand)//pass marks int array and random number
        {
            for(int i=0; i<marks.Length; i++)//loop through each index of array
            {
                marks[i] = rand.Next(1, 31);//assign random int to each index of marks array
            }
        }

        static private double CalculateAverageMarks(int[] marks)
        {
            double total = 0;
            for(int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
            }

            return total / marks.Length ;//array method to calc average
        }

        static private void DisplayMarksInfo(string[] names, int[] marks)
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}\t  {marks[i]}");
            }
        }

        static private void DisplayHigherMarksInfo(string[] names, int[] marks, double average)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (marks[i] >= average)
                {
                    Console.WriteLine($"{names[i]}\t  {marks[i]}");
                }
                
            }
            Console.Write("Press and key to continue . . . ");
            Console.Read();
        }


    }
}