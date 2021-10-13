using System;

namespace ICA4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string userChoice; //user input choice
            string computerChoice; //random choice
            Random randomNumber = new Random();
            string[] RPS = { "rock", "paper", "scissors" };

            //display title

            //diplay RPS choices and ask for user input
            Console.WriteLine("Please select your play from the following options:\n\n Paper\n Rock\n Scissors");
            Console.Write("\nYour selection is: ");
            userChoice = Console.ReadLine().ToLower();
            if (userChoice!="rock"&& userChoice != "paper"&& userChoice != "scissors")
            {
                Console.Write("\nYou have entered an invalid response. The program will now exit...");
                Console.ReadKey();
                System.Environment.Exit(1);

            }


            //use RNG to determine computer's choice
            computerChoice=RPS[randomNumber.Next(0,3)]; //0=rock, 1=paper, 2=scissors
            switch (computerChoice)
            {
                case "rock":
                    Console.WriteLine($"Computer played rock and you played {userChoice}.");
                    break;
                case "paper":
                    Console.WriteLine($"Computer played paper and you played {userChoice}.");
                    break;
                case "scissors":
                    Console.WriteLine($"Computer played scissors and you played {userChoice}.");
                    break;
            }


            //display outcome
            switch (computerChoice)
            {
                case "rock":
                    switch (userChoice)
                    {
                        case "rock":
                            Console.WriteLine("Its a tie!");
                            break;
                        case "paper":
                            Console.WriteLine("Paper covers rock, you win!");
                            break;
                        case "scissors":
                            Console.WriteLine("Rock crushes scissors, you lose.");
                            break;
                    }
                    break;
                case "paper":
                    switch (userChoice)
                    {
                        case "rock":
                            Console.WriteLine("Paper covers rock, you lose.");
                            break;
                        case "paper":
                            Console.WriteLine("Its a tie!");
                            break;
                        case "scissors":
                            Console.WriteLine("Scissors cut paper, you win!");
                            break;
                    }
                    break;
                case "scissors":
                    switch (userChoice)
                    {
                        case "rock":
                            Console.WriteLine("Rock crushes scissors, you win!");
                            break;
                        case "paper":
                            Console.WriteLine("Scissors cut paper, you lose.");
                            break;
                        case "scissors":
                            Console.WriteLine("Its a tie!");
                            break;
                    }
                    break;
            }

                    //end program
                    Console.Read();
        }
    }
}
