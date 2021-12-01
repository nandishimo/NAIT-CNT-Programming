using System;
namespace CNT157_ICA19_RefOut_Fall_09
{
	class Program
	{
		static void Main(string[] args)
		{
			int iMmInput;           //track minutes input by user
			int iSecInput;          //track seconds input by user
			int iMinTotal = 0;      //total music minutes
			int iSecTotal = 0;      //total music seconds
			bool bExit = false;     //flag for CD is full

			//repeat until user is done of CD is full 
			do
			{
				//get the time for a single track 
				GetTrack(out iMmInput, out iSecInput);

				//add the track to the current music total time
				AddTrack(iMmInput, iSecInput, ref iMinTotal, ref iSecTotal);

				//display the total time
				DisplayTotal(iMinTotal, iSecTotal);

				//check for the CD being full at about 76 minutes 
				if (SecTotal(iMinTotal, iSecTotal) > 76 * 60)
				{
					Console.WriteLine("The CD is full, exiting..."); bExit = true;
				}
			} while ((YesNo("Add another track?") == "yes") && !bExit);
			Console.WriteLine("Bye!");
			Console.Read();
		}

        private static string YesNo(string v)
        {
			Console.WriteLine(v);
			string input = Console.ReadLine();
            if (input != "yes" && input != "no")
                Console.WriteLine("You must answer yes or no");

            return Console.ReadLine();
        }

        private static int SecTotal(int iMinTotal, int iSecTotal)
        {
			return 60 * iMinTotal + iSecTotal;
        }

        private static void DisplayTotal(int iMinTotal, int iSecTotal)
        {
			Console.WriteLine($"The current total is {iMinTotal}:{iSecTotal}.");

		}

        static private void GetTrack(out int min, out int sec)
		{
			min = GetInt("Enter the minutes: ", 0, 59);
			sec = GetInt("Enter the seconds: ", 0, 59);
		}

		static private int GetInt(string prompt, int min, int max)
        {
			bool valid = false;
			int number = 0;
			do
			{
				Console.Write(prompt);
				valid = int.TryParse(Console.ReadLine(), out number);
				if(number<min || number>max)
					Console.WriteLine("That value is out of range.");
				if (!valid)
					Console.WriteLine("That entry is not a valid number.");
			} while (!valid || number<min ||number >max);
			return number;

        }

		static private void AddTrack(int MinIn, int SecIn, ref int MinTotal, ref int SecTotal)
        {
			MinTotal += MinIn;
			SecTotal += SecIn;
			while(SecTotal>59)
            {
				SecTotal -= 60;
				MinTotal += 1;
            }
        }
	}
}