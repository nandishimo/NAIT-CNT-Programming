/***CMPE 1666- Intemediate Programming
 * 
 * Winter 2022- Lab Exam 1 Q3 
 * 
 * 
 * Name: Nandish Patel
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExam1Q3
{
    public partial class Form1 : Form
    {    
        //Definition of the struct Sensor to hold information for a sensor- 
        //namely, its sensor id and the recorded temperature
        private struct Sensor
          {
            public int _sensorId;
            public double _temperature;

            //Constructor of the Sensor struct
            public Sensor(int Id, double temp)
            {
                _sensorId = Id;
                _temperature = temp;
            }

          }

        /* You'll use the 2 arrays provided below to build your list of sensors 
                    
         */

        //Array variable containing sensor ids 
        int[] SensorIdArray = {28, 50, 12, 2, 13, 38,5,72,19, 10, 7,22 };

        //Array containg temperature values- Each temperature value is for the sensor id
        //of the corresponding element of the SensorId array
        double[] temperatureArray = { 13.3, 15.5, -12.0, -7.5, 18.2,10.3,14.5, 15.5, -8.0, -4.3, 3.5,-12.0};

        
        
        public Form1()
        {
            InitializeComponent();
        }



        /*The method swap swaps the elements between the positions posn1 and posn2
          of its list parameter L, which is a list of Sensor structs */
        private void swap(List<Sensor> L, int posn1, int posn2)
        {
            Sensor temp = L[posn1];

            L[posn1] = L[posn2];
            L[posn2] = temp;
        }


        /**Note- For the 2 sorting algorithm below
         * If you choose to use QuickSort you'll need to include additional parameters
         * 
         *          
         */



        //Method to sort a list of Sensors by SensorId
        private void SortById(List<Sensor> myList)
        {
            //**Include your code here**/

      

        }


        //The SortByTemp method sorts a list of Sensor structs in descending order of temperatures
        private void SortByTemp(List<Sensor> L)
        {
           /*Include Your Code here**/


        }



    }
}
