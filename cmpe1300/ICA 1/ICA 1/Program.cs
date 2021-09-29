using System;

namespace ICA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "ICA01 - Nandish Patel"; //declare and set title
            Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2;//set cursor position
            Console.WriteLine(title);//write title
            
            Console.Write("\nEnter the number of cans of pop you'd like to purchase: ");//ask for user input
            int number = 0; //declare number of pop cans 
            string input = ""; //declare input string
            input = Console.ReadLine(); //read input
            int.TryParse(input, out number); //parse input as int
            
            Console.Write("\nEnter the cost per can of pop: "); //ask for cost of pop
            input = Console.ReadLine(); //read input
            double cost = 0; //declare cost of pop
            double.TryParse(input, out cost); //parse input as float
            
            double subtotal = number * cost; //calculate subtotal
            double gst = subtotal * 0.05; //calculate GST
            double total = subtotal + gst; //calculate total

            Console.WriteLine($"\nThe GST is {gst:c}"); //display gst
            Console.WriteLine($"\nThe total cost is {total:c}"); //display total cost
            Console.Write($"\nPress the <enter> key to exit: ");
            Console.Read();



        }
    }
}
