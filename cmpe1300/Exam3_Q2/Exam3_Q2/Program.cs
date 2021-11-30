/* *************************************

   * NANDISH PATEL

   * LAB EXAM 3 Q2

   * Question Code: 998

   *************************************/
/***CMPE 1300- Fundamentals of Programming 
 * 
 * LabExam3-Q2- Fall 2021- 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * This program allows you to choose a shape and to input the required dimensions 
 * and it calculates and displays the area for the shape. 
 * 
 * After each run, the program will allow the user to choose whether to continue or to terminate
 * 
 */



namespace LE3_Fall2021_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            String shape;//To store the shape input by the user
            bool validShape;//Used for verifying that the input shape is one of the 
                            //required strings
            bool validNumeric = false;//Used to verify if the input for a numerical value is a valid one
            bool exitProgram = false;//To continue running program until user decides to exit

            //Note: All the variables below have been initialized, since assignment and use of their respective
            //values may be in different blocks {ignore this:  192.197.128.18 }

            double length = 0, width = 0;//dimensions for rectangles;
            double side = 0;//Length of one side for square;
            double radius = 0;//radius for circles;
            double Area = 0;//To store the area calculated for the given shape

            string userAnswer;//To store answer from user whether to continue running the program


            do
            {
                exitProgram = false;

                //Calls getShape to obtain a shape from the user- ValidShape will be true if the user
                // has entered one of the 4 required shapes. Otherwise it will be false
                validShape = GetShape("Enter your choice of shape (rectangle,square, circle): ", out shape);


                //If the shape input is valid- we perform the required inputs
                //and calculation of the area
                if (validShape)
                {   //Input is performed using GetDouble.
                    //Note that squares and circles require only one input value whereas
                    //retangles require 2
                    switch (shape)
                    { //We don't need a default case since we get into the switch only
                        //if we have a valid shape and it's one of the 3 values
                        case "square":
                            validNumeric = GetDouble("Enter the length of one side of the square (cm): ", out side);
                            break;

                        case "circle":
                            validNumeric = GetDouble("Enter the radius of the circle (cm): ", out radius);
                            break;

                        case "rectangle":
                            validNumeric = GetDouble("Enter the length of the rectangle (cm): ", out length);
                            if (validNumeric)
                            {// We enter the width only if the length is a valid numerical value
                                validNumeric = GetDouble("Enter the width of the rectangle (cm) : ", out width);
                            }
                            break;


                    }

                    //Any of the numerical inputs is not valid we display a message of the user
                    if (!validNumeric)
                    {
                        Console.WriteLine("You given an invalid input for a numerical value.");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                    else
                    {  //We have placed the CalculateArea calls in a different switch block, to avoid
                        //so as to avoid additional "if (validNumeric) " checks.
                        switch (shape)
                        { //Again, we don't need a default here, since we reach this code only if the shape is
                          //one of the 3 values listed
                            case "square":
                                Area = CalculateArea(shape, side);
                                break;
                            case "circle":
                                Area = CalculateArea(shape, radius);
                                break;
                            case "rectangle":
                                Area = CalculateArea(shape, length, width);
                                break;

                        }

                        //These 2 lines are for improved formating purposes
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------------------------");

                        //Output of the calculated area
                        Console.WriteLine($"Area of {shape} is: {Area:F2} sq cm");

                        //These 2 lines are for improved formating purposes
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------------------------");
                    }

                }
                else
                {//This block is executed if the user has input an invalid value for the shape
                    Console.WriteLine("You have input an invalid shape");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }


                //Ask the user whether he/she wants to continue- Remain in this loop until the 
                //response is y or n. 
                do
                {
                    Console.Write("Do you want to calculate the area of another shape? (y/n)");
                    userAnswer = Console.ReadLine().ToLower();
                    if ((userAnswer != "y") && (userAnswer != "n"))
                    {
                        Console.WriteLine("You have given an invalid answer");
                    }

                } while ((userAnswer != "y") && (userAnswer != "n"));

                //Setting exitProgram to true will allow the program to exit the do-while loop and thus terminate '
                //the program
                if (userAnswer == "n")
                    exitProgram = true;

                //We clear the console before the next run
                Console.Clear();

            } while (!exitProgram);  //We allow to program to continue running until user decides to exit

        }//End of Main Method


        /*** Add Your Methods Below ***/
        /*system use only: 2021-11-30T10:33:57-07:00        * 9990        */
        static private bool GetShape(string prompt, out string shape)
        /*2 string parameters. first is prompt for user to enter a shape
         * second string to output the shape name
         * display prompt
         * check if user input is either rectangle, square, or circle and assign that shape to the out parameter and return true
         * return false if not one of these 3 options
         */
        {
            Console.Write(prompt);
            shape = Console.ReadLine();
            if (shape == "rectangle" || shape == "square" || shape == "circle")
                return true;
            else
                return false;
        }


        static private bool GetDouble(string prompt, out double d)
        /*first parameter is user prompt
         * 2nd parameter is an out argument of type double
         * display prompt
         * pass value to out, return true if value is valid, return false if not
         */
        {
            Console.Write(prompt);
            bool valid = double.TryParse(Console.ReadLine(), out d);
            return valid;
        }

        //CalculateArea (two overloaded methods)
        /*Both methods have string parameter that passes a shape
         * First method has on value of type double.
         * Second method has 2 values of type double
         * Methods are used to calculate the area of the shape
         * first method calculates for circles and squares (double value is radius for circle or length of one side for square)
         * second method calculates for rectangles (two double values are length and width)
         * both methods return a double for the respective area
         */
        static private double CalculateArea(string shape, double para)
        {
            double area=0;
            if (shape == "circle")
                area = Math.PI * para * para;
            else if (shape == "square")
                area = para * para;
            return area;
        }

        static private double CalculateArea(string shape, double para1, double para2)
        {
            double area=0;
            if (shape == "rectangle")
                area = para1 * para2;
            return area;
        }
    }
}