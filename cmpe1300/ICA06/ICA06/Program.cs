﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA06
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int size; //size of squares to ddraw
            int number; //number of squares to draw
            int i; //counter
            char cont; //variable to check for rerunning program
            Random random = new Random(); //random number generator
            string title = "Nandish Patel - ICA06"; //title var

            //Create GDIDrawer window of size 800x600
            CDrawer window = new CDrawer(800, 600);

            //main do-while loop
            do
            {
                //Display title
                Console.Clear(); //each loop clear console
                Console.CursorLeft = Console.WindowWidth / 2 - title.Length / 2; //center title
                Console.WriteLine(title);

                window.Clear();//clear drawer window

                //query square size from user from 10 to 200. validate as int. use a while loop with error message if invalid
                Console.Write("\nPlease enter an integer from 10 to 200 for the square size: ");//stuck in loop as long as input is invalid
                while (!int.TryParse(Console.ReadLine(), out size) || size < 10 || size > 200) 
                {
                    Console.Write("\nYou must enter a valid integer between 10 and 200: ");
                }

                //query number of squares to draw as integer. check if valid and greater than zero. use a while loop with error message if invalid
                Console.Write("\nPlease enter a positive integer for number of squares you would like drawn: ");//stuck in loop as long as input is invalid
                while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
                {
                    Console.Write("\nYou must enter a valid integer greater than 0: ");
                }
                //draw squares of specified size and number in random colors at random locations in the GDIDrawer window
                i = 0;//set count to zero
                while (i < number)
                {
                    window.AddRectangle(random.Next(0, 800 - size), random.Next(0, 600 - size), size, size, RandColor.GetColor()); //draws random coloured squares in random locations but not off screen
                    i++;//increase counter
                }
                //repeat program in a do-while loop if user enters 'y' or 'Y'. clear the console andd GDIDrawer window
                Console.Write("\nWould you like to run the program again? 'Y' or 'N' ");
                cont = Console.ReadKey().KeyChar;//reads key without waiting for user to hit enter

            } while (cont == 'y' || cont == 'Y');

        }
    }
}
