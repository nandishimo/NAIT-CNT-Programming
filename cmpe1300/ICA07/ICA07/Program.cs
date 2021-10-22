using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string title = "Nandish Patel - ICA07";
            int nGrades;
            Random randGrade = new Random();
            int i;

            do
            {
                //Display a title with name and assignment number
                Console.Clear();
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
                Console.WriteLine(title);

                //Input number of grades to generate as an int. Check that the value is valid int from 5 to 10.
                //If invalid,display an error message and use a do -while loop to perform the input operation again. Display different error messages if the value is invalid, too low or too high.
                Console.Write("\nEnter number of grades to generate (from 5 to 10): ");
                int.TryParse(Console.ReadLine(), out nGrades);



                //Using a do -while loop, generate the number of double grades in the range of 0.0 to 100.0 and display each grade using one decimal place as shown below.
                i = 0;
                double[] grades= new double[nGrades];
                do
                {
                    grades[i] = 100 * randGrade.NextDouble();
                    i++;

                } while (i < nGrades)


                //Display the average of the grades with one decimal place of accuracy.


                //Display the number of failing grades.


                //Using a do -while loop, repeat the program if the user enters ‘y’ or ‘Y’. Clear the Console window.


            } while ();
        }
    }
}
