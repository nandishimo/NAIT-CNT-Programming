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
		}

        private static string YesNo(string v)
        {
			Console.WriteLine(v);
			return Console.ReadLine();
        }

        private static int SecTotal(int iMinTotal, int iSecTotal)
        {
			return 60 * iMinTotal + iSecTotal;
        }

        private static void DisplayTotal(int iMinTotal, int iSecTotal)
        {
			Console.WriteLine($"The minutes are {iMinTotal} and the seconds are {iSecTotal}.");
        }

        static private void GetTrack(out int min, out int sec)
		{
			Console.Write("Please enter a track length (mm:ss): ");
			string time = Console.ReadLine();
			string[] bettertime = time.Split(':');
			int.TryParse(bettertime[0], out min);
			int.TryParse(bettertime[1], out sec);
		}

		static private void AddTrack(int MinIn, int SecIn, ref int MinTotal, ref int SecTotal)
        {
			MinTotal += MinIn;
			SecTotal += SecIn;
        }
	}
}