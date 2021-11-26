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
        //display request string, grab user input
        //error handling (parse)
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
        //GetValue(out int, string, min)
        //display request string, grab user input
        //error handling (parse, and min)
        static private void GetValue(out int iTest, string request, int min)
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = int.TryParse(input, out iTest);
                if (!valid || iTest < min)
                    Console.WriteLine(input + " is not a valid input.");
            } while (!valid || iTest < min);
        }
        //GetValue(out int, string, min, max)
        //display request string, grab user input
        //error handling (parse, min, max)
        static private void GetValue(out int iTest, string request, int min, int max)
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = int.TryParse(input, out iTest);
                if (!valid || iTest < min || iTest > max)
                    Console.WriteLine(input + " is not a valid input.");
            } while (!valid || iTest < min || iTest > max);
        }
        //GetValue(out double, string)
        //display request string, grab user input
        //error handling (parse)
        static private void GetValue(out double dTest, string request)
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = double.TryParse(input, out dTest);
                if (!valid)
                    Console.WriteLine(input + " is not a valid input.");
            } while (!valid);
        }
        //GetValue(out int, string, min)
        //display request string, grab user input
        //error handling (parse, and min)
        static private void GetValue(out double dTest, string request, double min)
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = double.TryParse(input, out dTest);
                if (!valid || dTest < min)
                    Console.WriteLine(input + " is not a valid input.");
            } while (!valid || dTest < min);
        }
        //GetValue(out int, string, min, max)
        //display request string, grab user input
        //error handling (parse, min, max)
        static private void GetValue(out double dTest, string request, double min, double max)
        {
            bool valid = false;
            do
            {
                Console.Write(request);
                string input = Console.ReadLine();
                valid = double.TryParse(input, out dTest);
                if (!valid || dTest < min || dTest > max)
                    Console.WriteLine(input + " is not a valid input.");
            } while (!valid || dTest < min || dTest > max);
        }
    }
}
