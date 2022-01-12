using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICA02
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string title = "CMPE 1666 - ICA02 - Winter 2022 - Nandish Patel";
            bool again = true;
            string input;
            char selection;

            do
            {
                Console.Clear();
                
                //display menu options
                Console.WriteLine(title);
                Console.Write("\n1. Check Palindrome on Input Value\n2. Find Palindromes in File\n3. Exit\nPlease select an option [1/2/3]: ");
                selection = Console.ReadKey(true).KeyChar; //grab keypress from user
                
                switch (selection)//switch case based on keypress
                {
                    case '1'://option 1. ask for input, use IsPalindrome method on input and display if input is palindrome or not
                        {
                            Console.Write("\nPlease enter a word to check: ");//prompt user for word to check
                            input = Console.ReadLine();
                            bool result = IsPalindrome(input);
                            if (result)//display result
                                Console.WriteLine("\nThe word " + input + " is a palindrome!");
                            else
                                Console.WriteLine("\nThe word " + input + " is not a palindrome.");
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                    case '2':
                        {
                            Console.Write("\nPlease enter a filename: ");//prompt user for filename
                            input = Console.ReadLine();
                            try
                            {
                                StreamReader word = new StreamReader(input);//open stream reader
                                Console.WriteLine("\nHere is a list of palindromes found in that file:");
                                do
                                {
                                    string testWord = word.ReadLine();//read word and test with palindrome method. display word in console if true
                                    if (IsPalindrome(testWord))
                                    {
                                        Console.WriteLine(testWord);
                                    }
                                } while (!word.EndOfStream);//loop until end of file
                                word.Close();//close stream
                            }
                            catch (Exception ex)//catch exceptions and display error message in console
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                    case '3': //changes again variable to false. display exit message
                        {
                            again=false;
                            Console.Write("\nPress any key to exit...");
                            Console.ReadKey();
                            break;
                        }
                    default: //if valid selection is not pressed, display error
                        {
                            Console.Write("\nThat is not a valid option. Press any key to try again...");
                            Console.ReadKey();
                            break;
                        }
                }
            } while (again);
                
        }

        static private bool IsPalindrome(string word)
        {
            if (word.Length < 2)
            {
                return true;
            }
            else if (word[0] == word[word.Length - 1])
            {
                return IsPalindrome(word.Substring(1, word.Length - 2));
            }
            else
            {
                return false;
            }
        }
    }
}
