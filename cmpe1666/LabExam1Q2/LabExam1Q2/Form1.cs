/**
 * 
 * CMPE 1666- Intemediate Programming
 * 
 * Lab Exam 1- Winter 2022- Question 2
 * 
 * Name: Nandish Patel
 * 
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

namespace LabExam1Q2
{
    public partial class Form1 : Form
    {

        //The provided Data Sets to help debugging and testing your method
        //to calculate the score of symmetry
        private int[] DataSet1 = { 6, 5, 3, 4, 2, 2, 4, 6, 12, 6 };
        private int[] DataSet2 = { 6, 5, 3, 4, 2, 2, 4, 3, 12, 6 };
        private int[] DataSet3 = { 4, 5, 5, 4, 2, 4, 3, 6, 6 };

        public Form1()
        {
            InitializeComponent();
        }


        /**Write your code here **/
        int[] workingArray;//working array for calculating scores
        private int checkSymmetry(int[] array)
        {
            int score = 0;//initial score
            if (array[0] == array[array.Length - 1])//compare outer array elements (or center element if only one left) for a score of 1 if equal
                score = 1;
            if (array.Length > 2)//base condition, recursion ends when sub array reaches the center 1 or 2 values
            {
                int[] subArray = new int[array.Length - 2];
                Array.Copy(array, 1, subArray, 0, array.Length - 2);
                score += checkSymmetry(subArray);//recursively add score from each sub array pair
            }
            return score;

        }

        private void UI_LoadData_Btn_Click(object sender, EventArgs e)
        {//check which radio button is checked and load relevant dataset into working array and display in textbox
            if (UI_DataSet1_Radio.Checked)
            {
                displayArray(DataSet1);
                workingArray = DataSet1;
            }
                
            if (UI_DataSet2_Radio.Checked)
            {
                displayArray(DataSet2);
                workingArray = DataSet2;
            }
            if (UI_DataSet3_Radio.Checked)
            {
                displayArray(DataSet2);
                workingArray = DataSet2;
            }
        }

        private void displayArray(int[] array) //helper method to display array in textbox
        {
            string display = "";
            foreach(int num in array)
            {
                display += $"{num}, ";
            }
            UI_Display_Tbx.Text = display;
        }

        private void UI_CalculateScore_Btn_Click(object sender, EventArgs e)
        {//calls symmetry scoring function and displays results in results textbox
            UI_Score_Tbx.Text = $"{checkSymmetry(workingArray)}";
        }

        private void UI_GenerateValues_Btn_Click(object sender, EventArgs e)
        { //generates a random array based on given parameters, loads it into the workingArray var and displays the array
            Random rand = new Random();
            if (//check if textbox entries are invalid
            !int.TryParse(UI_NumValues_Tbx.Text, out int num)//number of values to generate
            || !int.TryParse(UI_LowerLimit_Tbx.Text, out int low)//lower limit of values to generate
            || !int.TryParse(UI_UpperLimit_Tbx.Text, out int high))//upper limit of values to generate
            {
                UI_Display_Tbx.Text = ("One or more the parameters are invalid.");//error message displayed instead of array
                return;
            }
            workingArray = new int[num];
            for(int i = 0; i<num; i++)
            {
                workingArray[i] = rand.Next(low, high + 1);
            }
            displayArray(workingArray);
        }
    }
}
