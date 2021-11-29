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
            //get coefficients to ask for user input. return coefficients a,b,c
            GetCoefficients();
            
            //getRange to ask user for input. return upper and lower range values
            GetRange();
            
            //Pass coefficients, range vlues, and CDrawer window reference
            DrawGraph();

            //receive prompt to be displayed. return a bool based on user response
            YesNo();
        }

        private static void GetRange()
        {
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
            GetValue();
            GetValue();
            GetValue();
            throw new NotImplementedException();
        }

        private static void GetValue()
        {
            throw new NotImplementedException();
        }
    }
}
