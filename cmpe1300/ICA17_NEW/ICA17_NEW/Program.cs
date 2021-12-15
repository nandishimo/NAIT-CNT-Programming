using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICA17_NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            {
                Console.Clear();
                //display title
                string title = "Nandish Patel - ICA17";
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;
                Console.WriteLine(title);
                Console.WriteLine("Select the operation...");
                Console.Write("\nr. Read student data from a file.\nw. Write student data to a file.\ng. Generate random student data." +
                    "\na. Display the average.\ff. Display a list of failing students.\nq. Quit the program.\nYour selection: ");

                char select = Console.ReadKey().KeyChar;
                switch (select)
                {
                    case 'r':
                        {
                            Console.WriteLine("\nEnter a file name: ");
                            string file = Console.ReadLine();
                            StreamReader marksIn = new StreamReader($"{file}.txt");
                            StreamReader namesIn = new StreamReader("names.txt");
                            int size = 0;
                            while (marksIn.ReadLine() != null)
                                size++;
                            double mInput;
                            double[] marks = new double[size];
                            //double[] marks;
                            string nInput;
                            string[] names = new string[size];
                            int i;
                            try
                            {
                                i = 0;
                                while (double.TryParse(marksIn.ReadLine(), out mInput))
                                {
                                    marks[i] = mInput;
                                    i++;
                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            try
                            {
                                i = 0;
                                while ((nInput = namesIn.ReadLine()) != null)
                                {
                                    names[i] = nInput;
                                    i++;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }

                    case 'w':
                        {
                            StreamWriter marksOut = new StreamWriter("marks.txt");
                            StreamWriter namesOut = new StreamWriter("names.txt");
                            try
                            {
                                foreach (double value in marks)
                                {
                                    marksOut.WriteLine(value);
                                }
                                marksOut.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            try
                            {
                                foreach (string name in names)
                                {
                                    namesOut.WriteLine(name);
                                }
                                namesOut.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }

                    case 'g':
                        {
                            GetValue(out size, "Enter an integer from 4 to 10: ", 4, 10);
                            MakeRecords(size, out names, out marks);
                            break;
                        }

                    case 'a':
                        {
                        try
                        {
                            //Average(names, marks);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occured.");
                            Console.WriteLine($"The error was:{ex.Message}");
                        }
                        break;
                        }

                    case 'f':
                        {
                            //Fails(names, marks);
                            break;
                        }

                    case 'q':
                        {
                            again = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("That is not a valid selection.");
                            again = true;
                            break;
                        }

                }
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

                Console.WriteLine("{0,13}{1,1}{2,1:N1}", names[i], " : ", marks[i]);//table formate enntries
            }
        }

        static private void Average(string[] names, double[] marks)
        {
            double average = marks.Average();//get average mark
            double j = average;
            int i = 0;
            foreach (double mark in marks)
                if (i > Math.Abs(average - mark))// find mark that is closest (lowest abs difference} from the average mark
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

        //static private bool RunAgain()
        //{
        //    bool again = false;
        //    Console.WriteLine("\nWould you like to run the program again? Yes or No");//prompt
        //    string input = Console.ReadLine();
        //    if (input == "Yes" || input == "yes")// if input is yes ot Yes, again is true, or else, its false and program exits
        //        again = true;
        //    return again;

        //}
    }
}
