using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string title = "Nandish Patel - Lab 3";



            //main loop
            do
            {

                //get coefficients to ask for user input. return coefficients a,b,c
                GetCoefficients();

                //getRange to ask user for input. return upper and lower range values
                GetRange();

                //Pass coefficients, range vlues, and CDrawer window reference
                DrawGraph();

                //receive prompt to be displayed. return a bool based on user response
                YesNo();
            } while (again);
        }

        private static void GetRange()
        {
            //pass user input to getvalue. return upper and lower range values as doubles
            GetValue();
            GetValue();
            throw new NotImplementedException();
        }

        private static void YesNo()
        {
            throw new NotImplementedException();
        }

        private static void DrawGraph()
        {
            //pass coefficients and current value of x. calculate f(x)
            Quadratic();
            throw new NotImplementedException();
        }

        private static void Quadratic()
        {
            //quadtrativ equation
            double f = a*x^2+b*x+c;
        }

        private static void GetCoefficients()
        {
            //pass prompt to get value for coefficient, get double values, return 3 coefficients to main
            GetValue();
            GetValue();
            GetValue();
            throw new NotImplementedException();
        }

        private static void GetValue()
        {
            //display prompt
            //return user input as double
            throw new NotImplementedException();
        }
    }
}
