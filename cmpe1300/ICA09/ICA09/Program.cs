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
            string title = "ICA09 - Nandish Patel";
            int i = 0;//counter
            bool valid = false;//password valid?
            string rerun;
            char first='x';
            bool diff;


            do
            {
                Console.Clear();
                //display title
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
                Console.WriteLine(title);

                do
                {
                    valid = true;//sets password to be valid and each failure condition can change this so false
                    //user inputs a password
                    Console.Write("Please enter a password: ");
                    pass = Console.ReadLine();

                    //check password against specifications using foreach loops. display error message for each condition that has not been met
                    //minimum 8 characters
                    foreach (char ch in pass)
                    {
                        i++;
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
                        if (char.IsUpper(ch))
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
                            i++;
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
                        if (char.IsSymbol(ch))
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
                    if (i < 2 || !diff)//less than 2 numbers or not different numbers triggers this fail condition
                    {
                        Console.WriteLine("Password must contain at least two different numbers.");
                        valid = false;
                    }
                    
                } while (!valid);
                //display message if password is acceptable
                Console.WriteLine($"The password {pass} is valid.");
                //loop program as long as user desires
                Console.Write("Run program again? (Y/N): ");
                rerun = Console.ReadLine();

            } while (rerun == "Y" || rerun == "y");

            Console.WriteLine("\nThe program will now exit...");
            Console.ReadKey();

        }
    }
}
