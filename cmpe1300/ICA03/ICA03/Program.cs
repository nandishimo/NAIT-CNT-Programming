﻿using System;

namespace ICA03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string title = "Nandish Patel - Assignment 3";
            double r = 0;
            string type = "";
            double calc = 0;



            Console.WriteLine(title);

            Console.WriteLine("Enter the radius of a circle or sphere: ");
            double.TryParse(Console.ReadLine(), out r);

            Console.Write("Please enter the desire calculation [A]rea or [V]olume: ");
            type = Console.ReadLine();

            if (type == "A")
            {
                Console.WriteLine($"The area of a circle with a radius of {r} is {Math.PI * r * r}");
            }
            else if (type == "V")
            {
                Console.WriteLine($"The volume of a sphere with a radius of {r} is {4 / 3 * Math.PI * r * r * r}");
            }




            //End program
            Console.Write("Press <enter> to exit: ");

            Console.Read();
        }
    }
}
