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

            try
            {
                StreamReader word = new StreamReader("WordList.txt");
                do
                {
                    string testWord = word.ReadLine();
                    if (IsPalindrome(testWord))
                    {
                        Console.WriteLine(testWord);
                    }
                } while (!word.EndOfStream);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }

        static private bool IsPalindrome(string word)
        {
            int i = 0;
            if
            if (word[i] == word[word.Length - i - 1])
            {
                string word = word.Substring(1, word.Length - 2);

            }
            else
            {
                return false;
            }
        }
    }
}
