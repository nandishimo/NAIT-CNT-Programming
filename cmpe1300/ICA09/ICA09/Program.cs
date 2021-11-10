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
            string pass;//password
            string title = "ICA09 - Nandish Patel";//title
            int i = 0;//counter
            bool valid = false;//password valid?
            string rerun;//stores user entry to check to rerun program
            char first='x';//stores first digit found in password
            bool diff;//stores whether or not the password contains 2 different numbers


            do
            {
                Console.Clear();
                //display title
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
                Console.WriteLine(title);

                valid = true;//sets password to be valid and each failure condition can change this so false
                //user inputs a password
                Console.Write("\nPlease enter a password: ");
                pass = Console.ReadLine();

                //check password against specifications using foreach loops. display error message for each condition that has not been met
                //minimum 8 characters
                foreach (char ch in pass)
                {
                    i++;//counter for number of characters
                }
                if (i <= 7)//password fails if length is seven or less
                {
                    Console.WriteLine("Password must be minimum 8 characters in length.");
                    valid = false;
                }

                //one uppercase character
                i = 0;
                foreach (char ch in pass)
                {
                    if (char.IsUpper(ch))//counter for number of uppercase characters
                        i++;
                }
                if (i == 0)//password fails if no uppercase letters
                {
                    Console.WriteLine("Password must contain at least one uppercase letter.");
                    valid = false;
                }

                //one lowercase character
                i = 0;
                foreach (char ch in pass)
                {
                    if (char.IsLower(ch))
                        i++;//counter for # of lowercase chars
                }
                if (i == 0)//password fails if no lowercase letters
                {
                    Console.WriteLine("Password must contain at least one lowercase letter.");
                    valid = false;
                }
                        
                //one symbol character
                i = 0;
                foreach (char ch in pass)
                {
                    if (char.IsSymbol(ch))//
                        i++;
                }
                if (i == 0)//password fails if no symbols
                {
                    Console.WriteLine("Password must contain at least one symbol.");
                    valid = false;
                }

                //no space or tab characters
                i = 0;
                foreach (char ch in pass)
                {
                    if (char.IsWhiteSpace(ch))
                        i++;
                }
                if (i != 0)//password fails if it contains spaces or tabs
                {
                    Console.WriteLine("Password must not contain any spaces or tabs.");
                    valid = false;
                }
                        
                //at least two different numbers
                //first check for numbers and store the first number in a variable
                //check each number against the stored one as you count
                i = 0;
                diff = false;
                foreach (char ch in pass)
                {
                    if (char.IsDigit(ch))
                    {
                        if (i == 0)
                            first = ch;//stores first character in different variable
                        i++;//adds to counter 
                        if (!first.Equals(ch))//checks each digit against the first
                            diff = true;
                    }

                }
                if (!diff)//less than 2 different numbers triggers this fail condition
                {
                    Console.WriteLine("Password must contain at least two different numbers.");
                    valid = false;
                }
                //display message if password is acceptable  
                if (valid)
                    Console.WriteLine($"\nThe password \"{pass}\" is valid.");
                else
                    Console.WriteLine($"\nThe password \"{pass}\" is invalid.");
                //loop program as long as user desires
                Console.Write("\nRun program again? (Y/N): ");
                rerun = Console.ReadLine();

            } while (rerun == "Y" || rerun == "y");

            Console.WriteLine("\nThe program will now exit...");
            Console.ReadKey();

        }
    }
}
