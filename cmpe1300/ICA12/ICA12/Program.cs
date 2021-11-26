using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA12
{
    class Program
    {
        static void Main(string[] args)
        {
            int iTest;
            double dTest;

            GetValue(out iTest, "Enter an integer: ");
            Console.WriteLine("iTest = {0}", iTest);

            GetValue(out iTest, "Enter a positive integer: ", 0);
            Console.WriteLine("iTest = {0}", iTest);

            GetValue(out iTest, "Enter an integer from 0 to 100: ", 0, 100);
            Console.WriteLine("iTest = {0}", iTest);

            GetValue(out dTest, "Enter a double: ");
            Console.WriteLine("dTest = {0}", dTest);

            GetValue(out dTest, "Enter a positive double: ", 0.0);
            Console.WriteLine("dTest = {0}", dTest);

            GetValue(out dTest, "Enter a double from 0.0 to 100.0: ", 0.0, 100.0);
            Console.WriteLine("dTest = {0}", dTest);

            Console.ReadKey();
        }
        //GetValue(out int, string)
        //displayer request string, grab user input
        //error handling
        static private void GetValue(out int iTest, string request)
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = int.TryParse(input, out iTest);
                if (!valid)
                    Console.WriteLine(input + " is not a valid input.");
            } while (!valid);
            
        }

        static private void GetValue(out int iTest, string input, int min)
        {
            throw new NotImplementedException();
        }

        static private void GetValue(out int iTest, string input, int min, int max)
        {
            throw new NotImplementedException();
        }

        static private void GetValue(out double dTest, string input)
        {
            throw new NotImplementedException();
        }

        static private void GetValue(out double dTest, string input, double min)
        {
            throw new NotImplementedException();
        }

        static private void GetValue(out double dTest, string input, double min, double max)
        {
            throw new NotImplementedException();
        }
    }
}
