using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA09
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string pass;
            string title = "ICA09 - Nandish Patel";
            int i = 0;
            bool valid = false;
            string rerun;


            do
            {
                Console.Clear();
                //display title
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
                Console.WriteLine(title);

                do
                {
                    valid = true;
                    //user inputs a password
                    Console.Write("Please enter a password: ");
                    pass = Console.ReadLine();

                    //check password against specifications using foreach loops. display error message for each condition that has not been met
                    //minimum 8 characters
                    foreach (char ch in pass)
                    {
                        i++;
                    }
                    if (i < 7)
                    {
                        Console.WriteLine("Password must be minimum 8 characters in length.");
                        valid = false;
                    }

                    //one uppercase character
                    i = 0;
                    foreach (char ch in pass)
                    {
                        if (char.IsUpper(ch))
                            i++;
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("Password must contain at least one uppercase letter.");
                        valid = false; ;
                    }

                    //one lowercase character
                    i = 0;
                    foreach (char ch in pass)
                    {
                        if (char.IsLower(ch))
                            i++;
                    }
                    if (i == 0)
                        Console.WriteLine("Password must contain at least one lowercase letter.");
                    //one symbol character
                    //no space or tab characters
                    //at least two different numbers

                    //display message if password is acceptable
                } while (!valid);

                //loop program as long as user desires
                Console.Write("Run program again? (Y/N): ");
                rerun = Console.ReadLine();

            } while (rerun == "Y" || rerun == "y");

            Console.WriteLine("\nThe program will now exit...");
            Console.ReadKey();

        }
    }
}
