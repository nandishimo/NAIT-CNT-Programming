﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = false;
            do
            {
                Console.Clear();
                //display title
                string title = "Nandish Patel - ICA15";
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
                Console.WriteLine(title);

                //user enters size of array using GetValue() method limit 4 to 10.
                GetValue(out int size, "Enter an integer from 4 to 10: ", 4, 10);

                //MakeRecords() receives size of array
                //create array of marks to store random doubles from 0.0 to 100.0
                //array of student names using random strings 5 to 12 characters long
                //first character must be capitalized. rest of characters are lower case
                //use ASCII table for random integers and typecast
                MakeRecords(size, out string[] names, out double[] marks);


                //Show() method display contents of name array in column 1 and marks in coloumn 2
                //use example format
                Show(size, names, marks);

                //Average() method to calc and display the average marks (one decimalplace).
                //display name and grade of student who is closest to average.
                Average(names, marks);

                //Fails() method determine and list students and marks who fail( lower than 50.0)
                Fails(names, marks);

                //run program again?
                again = RunAgain();
            } while (again);

        }

        static private void GetValue(out int iTest, string request, int min, int max)
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = int.TryParse(input, out iTest);//validate user input 
                if (!valid)
                    Console.WriteLine(input + " is not a valid input.");
                if (iTest < min || iTest > max)//check against max and min
                    Console.WriteLine(input + " is outside the accepted range.");
            } while (!valid || iTest < min || iTest > max);//loop until valid output is created
        }
        static private void MakeRecords(int size, out string[] names, out double[] marks)
        {
            //create new arrays
            names = new string[size];
            marks = new double[size];

            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                char[] namechar = new char[rand.Next(5, 13)];//create array of characters for name of random length 
                for (int j = 0; j < namechar.Length; j++)
                {
                    if (j == 0)
                        namechar[j] = Convert.ToChar(rand.Next(65, 90));//first entry in array is random capital letter
                    else
                        namechar[j] = Convert.ToChar(rand.Next(97, 122));//other entries are random lowercase letters
                }
                string name = new string(namechar);//convert character array into a string array entry
                names[i] = name;
                marks[i] = 100 * rand.NextDouble();//enter random double into marks
            }
        }
        static private void Show(int size, string[] names, double[] marks)
        {
            Console.WriteLine("\n{0,13}{1,8}", "Name", "Marks");//coloumn heading
            Console.WriteLine("{0,13}{1,8}", "-----", "-----");
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine("{0,13}{1,1}{2,1:N1}", names[i]," : ", marks[i]);//table formate enntries
            }
        }

        static private void Average(string[] names, double[] marks)
        {
            double average = marks.Average();//get average mark
            double j = average;
            int i=0;
            foreach (double mark in marks)
                if(i > Math.Abs(average - mark))// find mark that is closest (lowest abs difference} from the average mark
                {
                    j = average - mark;
                    i = Array.IndexOf(marks, mark);
                }
            //display stuff
            Console.WriteLine($"\nThe average of the marks is {average:N1} percent. \n{names[i]} is closest to the average with a mark of {marks[i]:N1} percent");
        }

        static private void Fails(string[] names, double[] marks)
        {
            int i;
            Console.WriteLine("\nHere is a list of failing students...");//dispaly stuff
            Console.WriteLine("\n{0,13}{1,8}", "Name", "Marks");//headings
            Console.WriteLine("{0,13}{1,8}", "-----", "-----");
            foreach (double mark in marks)
            {
                if (mark < 50)//check each entry in array of marks
                {
                    i = Array.IndexOf(marks, mark);
                    Console.WriteLine("{0,13}{1,1}{2,1:N1}", names[i], " : ", marks[i]);//finds index for marks less than 50 and display name and mark for that index
                }
            }
        }

        static private bool RunAgain()
        {
            bool again = false;
            Console.WriteLine("\nWould you like to run the program again? Yes or No");//prompt
            string input = Console.ReadLine();
            if (input == "Yes" || input == "yes")// if input is yes ot Yes, again is true, or else, its false and program exits
                again = true;
            return again;

        }

    }
}
