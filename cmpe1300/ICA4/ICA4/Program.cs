using System;

namespace ICA4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string userChoice;
            string C;
            string computerChoice;
            int rand;
            Random randomNumber = new Random();
            string[] RPS = { "rock", "paper", "scissors" };

            //display title

            //diplay RPS choices and ask for user input
            Console.WriteLine("Please select your play from the following options:\n\n Paper\n Rock\n Scissors");
            Console.Write("\nYour selection is: ");
            userChoice = Console.ReadLine().ToLower();

            switch (userChoice)
            {

            }

            //use RNG to determine computer's choice
            computerChoice=RPS[randomNumber.Next(0,2)];

            //display outcome
            Console.WriteLine($"\nYou played {userChoice}. The computer played {computerChoice}");

            //end program
            Console.Read();
        }
    }
}
