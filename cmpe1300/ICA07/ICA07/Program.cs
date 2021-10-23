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
            bool input;
            int nGrades;
            Random randGrade = new Random();
            int i;
            int f;
            string dGrades;
            double grade;
            double sumGrades;
            char cont;

            do
            {
                //Display a title with name and assignment number
                Console.Clear();
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2; //move cursor for centered title
                Console.WriteLine(title);

                //Input number of grades to generate as an int. Check that the value is valid int from 5 to 10.
                //If invalid,display an error message and use a do -while loop to perform the input operation again. Display different error messages if the value is invalid, too low or too high.
                Console.Write("\nEnter number of grades to generate (from 5 to 10): ");
                do
                {
                    input = int.TryParse(Console.ReadLine(), out nGrades); //parse user entry
                    if (!input)//checks if input is integer
                        Console.Write("Your entry is not a valid integer. Try again: ");
                    else if (nGrades < 5) //checks if input is too small
                        Console.Write("The value you entered is too small. Try again: ");
                    else if (nGrades > 10) //checkss if input is too large
                        Console.Write("The value you entered is too large. Try again: ");
                } while (!input||nGrades<5||nGrades>10); //repeats loop if input is invalid


                //Using a do -while loop, generate the number of double grades in the range of 0.0 to 100.0 and display each grade using one decimal place as shown below.
                //set initial values for each program run
                i = 0;
                f = 0;
                dGrades = "";
                sumGrades = 0;
                do//main loop to generate random grades and track failed grades and total sum
                {
                    grade = 100 * randGrade.NextDouble();
                    if (grade < 50) 
                        f++;
                    dGrades = (dGrades + $"{grade:F1} ");
                    sumGrades = sumGrades + grade;
                    i++;

                } while (i < nGrades);
                Console.WriteLine($"\nHere are the generated grades...\n\n{dGrades}");

                //Display the average of the grades with one decimal place of accuracy.
                Console.WriteLine($"\nThe average grade was {sumGrades / nGrades:F1}%");//divides sum of generated grades by number of grades to determine average

                //Display the number of failing grades.
                Console.WriteLine($"There were {f} failures.");

                //Using a do -while loop, repeat the program if the user enters ‘y’ or ‘Y’. Clear the Console window.
                Console.Write("\nRun the program again? ( Y / N )");
                cont = Console.ReadKey().KeyChar;//reads key without waiting for user to hit enter

            } while (cont=='y'||cont=='Y');//repeats program on y or Y press
        }
    }
}
