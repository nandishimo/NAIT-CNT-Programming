using System;
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
            //display title
            Console.SetWindowSize(100, 60);
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


            //Fails() method determine and list students and marks who fail( lower than 50.0)


            //run program again?

            Console.Read();

        }

        static private void GetValue(out int iTest, string request, int min, int max)
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = int.TryParse(input, out iTest);
                if (!valid)
                    Console.WriteLine(input + " is not a valid input.");
                if (iTest < min || iTest > max)
                    Console.WriteLine(input + " is outside the accepted range.");
            } while (!valid || iTest < min || iTest > max);
        }
        static private void MakeRecords(int size, out string[] names, out double[] marks)
        {
            names = new string[size];
            marks = new double[size];

            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                char[] namechar = new char[rand.Next(5, 12)];
                for (int j = 0; j < namechar.Length; j++)
                {
                    if (j == 0)
                        namechar[j] = Convert.ToChar(rand.Next(65, 90));
                    else
                        namechar[j] = Convert.ToChar(rand.Next(97, 122));
                }
                string name = new string(namechar);
                names[i] = name;
                marks[i] = 100 * rand.NextDouble();
            }
        }
        static private void Show(int size, string[] names, double[] marks)
        {
            Console.WriteLine("\n{0,13}   {1,10}", "Name", "Marks");
            Console.WriteLine("{0,13}   {1,10}", "----", "-----");
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine("{0,13} : {1,10:N1}", names[i], marks[i]);
            }
        }

    }
}
