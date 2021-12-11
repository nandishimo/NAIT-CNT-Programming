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
            Console.SetWindowSize(600, 1200);
            string title = "Nandish Patel - ICA15";
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
            Console.WriteLine(title);

            //user enters size of array using GetValue() method limit 4 to 10.


            //MakeRecords() receives size of array
            //create array of marks to store random doubles from 0.0 to 100.0
            //arra of student names using random strings 5 to 12 characters long
            //first character must be capitalized. rest of characters are lower case
            //use ASCII table for random integers and typecast


            //Show() method display contents of name array in column 1 and marks in coloumn 2
            //use example format


            //Average() method to calc and display the average marks (one decimalplace).
            //display name and grade of student who is closest to average.


            //Fails() method determine and list students and marks who fail( lower than 50.0)


            //run program again?

            Console.Read();

        }
    }
}
