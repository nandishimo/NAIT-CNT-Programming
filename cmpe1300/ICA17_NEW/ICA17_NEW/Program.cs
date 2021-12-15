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
            //display title
            string title = "Nandish Patel - ICA17";
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;//centered title
            Console.WriteLine(title);
            bool again = true;//initial loop boolean
            double[] marks = new double[10];//initialize dummy arrays
            string[] names = new string[10];//initialize dummy arrays
            int size = 0;//starting size of 0
            do
            {

                

                Console.WriteLine("\nSelect the operation...");
                Console.Write("\nr. Read student data from a file.\nw. Write student data to a file.\ng. Generate random student data." +
                    "\na. Display the average.\nf. Display a list of failing students.\nq. Quit the program.\n\nYour selection: ");//display options

                char select = Console.ReadKey().KeyChar;//grab next keypress
                switch (select)
                {
                    case 'r':
                        {
                            ReadFile(out size, out names, out marks);//pass size, names, marks. readfile method and display array
                            Show(size, names, marks);//display array
                            break;
                        }

                    case 'w':
                        {
                            if (size == 0)//if size is still 0 then an array was not generated or written. cannot proceed with writefile method
                            {
                                Console.WriteLine("\nYou must read a file or generate new records first.");//error message
                                break;
                            }
                            WriteFile(size, names, marks);//pass size and arrays to write
                            break;
                        }

                    case 'g':
                        {
                            GetValue(out size, "\nEnter an integer from 4 to 10: ", 4, 10);//get int value for size
                            names = new string[size];//new arrays of size
                            marks = new double[size];
                            MakeRecords(size, out names, out marks);//pass size, names, marks for random record generation
                            Show(size, names, marks);//display array
                            break;
                        }

                    case 'a':
                        {
                            if (size == 0)//checks size, if 0, then an array was not generated or read yet
                            {
                                Console.WriteLine("\nYou must read a file or generate new records first.");
                                break;
                            }
                            Average(names, marks);//pass arrays and displays average mark and closest studetn
                            break;
                        }

                    case 'f':
                        {
                            if (size == 0)//checks size, if 0, then an array was not generated or read yet
                            {
                                Console.WriteLine("\nYou must read a file or generate new records first.");
                                break;
                            }
                            Fails(names, marks);//pass arrays and display fails
                            break;
                        }

                    case 'q':
                        {
                            again = false;//loop exit
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nThat is not a valid selection.");//if one of the previous options is not pressed, display error message and loop again
                            again = true;
                            break;
                        }
                }
            } while (again);
        }
        static private void ReadFile(out int size, out string[] names, out double[] marks)
        {
            Console.Write("\n\nEnter a file name: ");//prompt for file name
            string file = Console.ReadLine();
            size = 0;
            names = new string[size];
            marks = new double[size];
            try
            {
                StreamReader marksIn = new StreamReader(file);//opens file in buffer
                string[] words;
                size = 0;
                while (marksIn.ReadLine() != null)
                {
                    size++;//counts lines in file
                }
                marksIn.Close();//closes
                marksIn = new StreamReader(file);//opens file again to read

                marks = new double[size];//generates new arrays of proper size
                names = new string[size];
                for (int j = 0; j < size; j++)
                {
                    words = marksIn.ReadLine().Split(' ');//splits name and marks
                    names[j] = words[0];//transfwe word string to names array
                    double.TryParse(words[1], out marks[j]); //parse second index of words as double
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Could not execute due to error: " + ex.Message);
            }

        }
        static private void WriteFile(int size, string[] names, double[] marks)
        {
            Console.Write("\n\nEnter a file name: ");//prompt user for file
            string file = Console.ReadLine();
            try
            {
                StreamWriter marksOut = new StreamWriter(file);//open buffer stream
                for (int i=0;i<size;i++)
                {
                    marksOut.WriteLine(names[i]+' '+marks[i]);// writes name and double value with a space delimiter
                }
                marksOut.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not execute due to error: "+ex.Message);
            }
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
                marks[i] = Math.Round(100 * rand.NextDouble(),1);//enter random double into marks
            }
        }
        static private void Show(int size, string[] names, double[] marks)
        {
            Console.WriteLine("\n{0,13}{1,8}", "Name", "Marks");//coloumn heading
            Console.WriteLine("{0,13}{1,8}", "-----", "-----");
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine("{0,13}{1,1}{2,1}", names[i], " : ", marks[i]);//table formate enntries
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
