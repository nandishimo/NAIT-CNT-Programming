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
            Random randomNumber = new Random(); //intialize randomNumber as Random variable
            string[] RPS = { "rock", "paper", "scissors" }; //array for random number to pick RPS

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
            switch (computerChoice)//displays user and computer choices
            {
                case "rock":
                    Console.WriteLine($"\nComputer played rock and you played {userChoice}.\n");
                    break;
                case "paper":
                    Console.WriteLine($"\nComputer played paper and you played {userChoice}.\n");
                    break;
                case "scissors":
                    Console.WriteLine($"\nComputer played scissors and you played {userChoice}.\n");
                    break;
            }


            //display outcome
            switch (computerChoice)
            {
                case "rock"://cases where computer chose rock
                    switch (userChoice)//checks and displays RPS outcome for rock vs user choice
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
                case "paper"://cases where computer chose paper
                    switch (userChoice)//checks and displays RPS outcome for paper vs user choice
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
                case "scissors"://cases where computer chose scissors
                    switch (userChoice)//checks and displays RPS outcome for scissors vs user choice
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
            Console.Write("\nPress any key to exit... ");
            Console.Read();//pause for user input
        }
    }
}
