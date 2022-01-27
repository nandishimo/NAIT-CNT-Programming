using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random(); //random variable used for generating random numbers in list
        List<int> numList = new List<int>();//to store generated list
        List<int> cloneList = new List<int>(); //to store copy or original list to perform sorting on.
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch(); //stopwatch to measure elapsed ticks for each sorting method
        private void generateButton_Click(object sender, EventArgs e)
        {
            bool error = false;//presense of error in entered values
            string errorMessage = "";
            if (!int.TryParse(numValBox.Text, out int num)|| num <= 10)
            {
                errorMessage += "\"Number of Values\" must be a valid integer greater than 10. ";//error if invalid integer or not greater than 10
                error = true;
            }
            if (!int.TryParse(minValBox.Text, out int min))
            {
                errorMessage += "\"Minimum Value\" must be a valid integer. "; //error if invalid integer
                error = true;
            }
            if (!int.TryParse(maxValBox.Text, out int max)|| min>=max)
            {
                errorMessage += "\"Maximum Value\" must be a valid integer greater than the minimum value. "; //error if invalid integer or not greater than min
                error = true;
            }
            //clear boxes 
            numValBox.Clear();
            minValBox.Clear();
            maxValBox.Clear();
            if (error)
            {
                MessageBox.Show(errorMessage, "Error");//display error message if error was found
                return;
            }
            numList.Clear();//clear values from list
            generateList(num, min, max); //generate new values for list
            displayRAW(); //display generated list
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            //clear clonelist and add values from generated list
            cloneList.Clear();
            for(int i=0; i<numList.Count;i++)
            {
                cloneList.Add(numList[i]);
            }
            //run appropriate sorting method depending on which radio button is checked
            if (clearSortButton.Checked)
            {
                stopwatch.Start();
                bubbleSort(ref cloneList);
                stopwatch.Stop();
            }
            else if (selectionButton.Checked)
            {
                stopwatch.Start();
                selectionSort(ref cloneList);
                stopwatch.Stop();
            }
            else if (insertionButton.Checked)
            {
                stopwatch.Start();
                insertionSort(ref cloneList);
                stopwatch.Stop();
            }
            else
            {
                stopwatch.Start();
                quickSort(ref cloneList,0, cloneList.Count - 1);
                stopwatch.Stop();
            }
            //add values from sorted list into sorted textbox
            string listGen = "";
            foreach (int i in cloneList)
            {
                listGen += $"{i}, ";
            }
            sortedBox.Text = listGen;
            sortingTimeBox.Text = stopwatch.ElapsedTicks.ToString();//display elasped ticks for that method
            stopwatch.Reset();//reset the stopwatch
        }
        private void generateList(int num, int min, int max) //takes number of values, minumum value and maximum value
        {
            for (int i = 0; i < num; i++)
            {
                numList.Add(rand.Next(min, max+1));//adds random integers to list with passed parameters
            }
        }
        private void quickSort(ref List<int> list, int start, int end)//references a list and start and end parameters
        {
            int i;
            if (start < end)
            {
                i = Partition(ref list, start, end);//passes list reference, start and end parameters
                quickSort(ref list, start, i - 1); //recursion on left side of partition
                quickSort(ref list, i + 1, end); //recursion on right side of partition
            }
        }
        private int Partition(ref List<int> list, int start, int end)
        {
            int p = list[end];//grabs last value as "middle" value for partition
            int i = start - 1;
            for(int j=start; j < end; j++)//passes through each index, start to finish
            {
                if (list[j] <= p)//swaps value to left most index that hasnt been swapped yet if its smaller than "middle" point
                {
                    i++;
                    swap(ref list, i, j);//swap helper method
                }
            }
            swap(ref list, i + 1, end);//swap helper method
            return i + 1;
        }
        private void insertionSort(ref List<int> list)
        {
            int j;
            int temp;
            for (int i=1; i < list.Count; i++)//passes through entire list once and stores current value to temp
            {
                temp = list[i];
                j = i - 1;
                //finds compares the temp value to the value at one index lower, moves into the "insertion" loop when the temp is smaller
                
                while ((j >= 0)&&(list[j] > temp))
                //passes back through the array moving each value to one index higher until it finds a spot where the temp value is not smaller
                {
                    list[j + 1] = list[j];
                    j--;
                }
                //"inserts" the temp value in current index
                list[j + 1] = temp;
            }
        }
        private void selectionSort(ref List<int> list)
        {
            for(int i = 0; i < list.Count; i++)//passes through entire list
            {
                int maxP = 0;//starting index of "max" value
                int lastP = list.Count - 1 - i; //position of last "unsorted" value
                for (int j=0; j < list.Count - i; j++)//passes through "unsorted" section of the list to find highest value
                {
                    if (list[j] > list[maxP])//set index of max value as j
                        maxP = j;
                }
                swap(ref list, maxP, lastP);//swaps highest value in unsorted exection of list to the end of unsorted section
            }
        }
        private void bubbleSort(ref List<int> list)
        {
            for (int i = 0; i < list.Count; i++)//pass through list n times
            {
                for (int j = 0; j < list.Count - i - 1;j++)//each pass starts at 0 and moves up to last "unsorted value"
                {
                    if (list[j] > list[j + 1]) //swaps value of index into the next index if higher, this carries the highest value to the end
                        swap(ref list, j, j + 1);
                }
            }
        }
        private void clearRawButton_Click(object sender, EventArgs e)
        {
            generatedBox.Clear();//clear the disaply of generated values 
        }

        private void reDisplayButton_Click(object sender, EventArgs e)
        {
            displayRAW();//displays the generated lsit of values
        }
        private void displayRAW()
        {
            string listGen = "";
            foreach (int i in numList)
            {
                listGen += $"{i}, ";//concats a string which each integer in the unsorted/generated list
            }
            generatedBox.Text = listGen;//displays unsorted string in box
        }
        private void swap(ref List<int> list, int a, int b)//pass list reference and indices for values to swap
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        private void sortClearButton_Click(object sender, EventArgs e)
        {
            sortedBox.Clear();//clear display of sorted values
            sortingTimeBox.Clear();//clear display of elapsed ticks
        }
    }
}
