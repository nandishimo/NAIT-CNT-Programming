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
            int j;
            Sensor temp;
            for (int i = 1; i < myList.Count; i++)//passes through entire list once and stores current value to temp
            {
                temp = myList[i];
                j = i - 1;
                //finds compares the temp value to the value at one index lower, moves into the "insertion" loop when the temp is smaller

                while ((j >= 0) && (myList[j]._sensorId > temp._sensorId))
                //passes back through the array moving each value to one index higher until it finds a spot where the temp value is not smaller
                {
                    myList[j + 1] = myList[j];
                    j--;
                }
                //"inserts" the temp value in current index
                myList[j + 1] = temp;
            }

        }


        //The SortByTemp method sorts a list of Sensor structs in descending order of temperatures
        private void SortByTemp(List<Sensor> L)
        {
            /*Include Your Code here**/
            int j;
            Sensor temp;
            for (int i = 1; i < L.Count; i++)//passes through entire list once and stores current value to temp
            {
                temp = L[i];
                j = i - 1;
                //finds compares the temp value to the value at one index lower, moves into the "insertion" loop when the temp is smaller

                while ((j >= 0) && (L[j]._temperature > temp._temperature))
                //passes back through the array moving each value to one index higher until it finds a spot where the temp value is not smaller
                {
                    L[j + 1] = L[j];
                    j--;
                }
                //"inserts" the temp value in current index
                L[j + 1] = temp;


            }
        }
        List<Sensor> rawData = new List<Sensor>();//create list of sensor structs
        List<Sensor> copyData = new List<Sensor>();//copied list to sort
        private void UI_LoadProvidedData_Btn_Click(object sender, EventArgs e)
        {
            UI_RawData_LB.Items.Clear();//clear lsit box
            for (int i =0; i<SensorIdArray.Length; i++)
            {//create new sensor struct object and fill with array data
                Sensor data = new Sensor();
                data._sensorId = SensorIdArray[i];
                data._temperature = temperatureArray[i];
                //add to original list and copy list
                rawData.Add(data);
                copyData.Add(data);
                UI_RawData_LB.Items.Add($"{data._sensorId}: \t {data._temperature}");
            }

        }

        private void UI_SortProvidedData_btn_Click(object sender, EventArgs e)
        {//check which button is checked and do the relevant sorting

            if (UI_SortByID_Radio.Checked)
                SortById(copyData);
            else
                SortByTemp(copyData);
            UI_SortedData_LB.Items.Clear();//clear sorted data listbox
            for (int i = 0; i < copyData.Count; i++)
            {
                UI_SortedData_LB.Items.Add($"{copyData[i]._sensorId}: \t {copyData[i]._temperature}");//add sorted data to listbox
            }

        }
    }
}
