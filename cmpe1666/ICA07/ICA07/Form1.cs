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
        Random rand = new Random();
        List<int> numList = new List<int>();
        List<int> cloneList = new List<int>();
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        private void generateButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            string errorMessage = "";
            if (!int.TryParse(numValBox.Text, out int num)|| num <= 10)
            {
                errorMessage += "\"Number of Values\" must be a valid integer greater than 10. ";
                error = true;
            }
            if (!int.TryParse(minValBox.Text, out int min))
            {
                errorMessage += "\"Minimum Value\" must be a valid integer. ";
                error = true;
            }
            if (!int.TryParse(maxValBox.Text, out int max)|| min>=max)
            {
                errorMessage += "\"Maximum Value\" must be a valid integer greater than the minimum value. ";
                error = true;
            }
            numValBox.Clear();
            minValBox.Clear();
            maxValBox.Clear();
            if (error)
            {
                MessageBox.Show(errorMessage, "Error");
                return;
            }
            numList.Clear();
            generateList(num, min, max);
            displayRAW();
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            cloneList.Clear();
            for(int i=0; i<numList.Count;i++)
            {
                cloneList.Add(numList[i]);
            }
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
            string listGen = "";
            foreach (int i in cloneList)
            {
                listGen += $"{i}, ";
            }
            sortedBox.Text = listGen;
            sortingTimeBox.Text = stopwatch.ElapsedTicks.ToString();
            stopwatch.Reset();
        }

        private void generateList(int num, int min, int max)
        {
            for (int i = 0; i < num; i++)
            {
                numList.Add(rand.Next(min, max+1));
            }
        }

        private void quickSort(ref List<int> list, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(ref list, start, end);
                quickSort(ref list, start, i - 1);
                quickSort(ref list, i + 1, end);
            }
        }

        private int Partition(ref List<int> list, int start, int end)
        {
            int p = list[end];
            int i = start - 1;
            for(int j=start; j < end; j++)
            {
                if (list[j] <= p)
                {
                    i++;
                    swap(ref list, i, j);
                }
            }
            swap(ref list, i + 1, end);
            return i + 1;
        }

        private void insertionSort(ref List<int> list)
        {
            int j;
            int temp;
            for (int i=1; i < list.Count; i++)
            {
                temp = list[i];
                j = i - 1;
                while((j >= 0)&&(list[j] > temp))
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = temp;
            }
        }

        private void selectionSort(ref List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                int maxP = 0;
                int lastP = list.Count - 1 - i;
                for (int j=0; j < list.Count - i; j++)
                {
                    if (list[j] > list[maxP])
                        maxP = j;
                }
                swap(ref list, maxP, lastP);
            }
        }

        private void swap(ref List<int> list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        private void bubbleSort(ref List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1;j++)
                {
                    if (list[j] > list[j + 1])
                        swap(ref list, j, j + 1);
                }
            }
        }

        private void clearRawButton_Click(object sender, EventArgs e)
        {
            generatedBox.Clear();
        }

        private void reDisplayButton_Click(object sender, EventArgs e)
        {
            displayRAW();
        }
        private void displayRAW()
        {
            string listGen = "";
            foreach (int i in numList)
            {
                listGen += $"{i}, ";
            }
            generatedBox.Text = listGen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sortedBox.Clear();
            sortingTimeBox.Clear();
        }
    }
}
