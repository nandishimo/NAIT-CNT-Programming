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
        private void generateButton_Click(object sender, EventArgs e)
        {
            int.TryParse(numValBox.Text, out int num);
            int.TryParse(minValBox.Text, out int min);
            int.TryParse(maxValBox.Text, out int max);
            numList.Clear();
            generateList(num, min, max);

            string listGen="";
            foreach (int i in numList)
            {
                listGen += $"{i}, ";
            }
            generatedBox.Text = listGen;
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (bubbleButton.Checked)
                bubbleSort();
            else if (selectionButton.Checked)
                selectionSort();
            else if (insertionButton.Checked)
                insertionSort();
            else
                quickSort(0,numList.Count-1);
            string listGen = "";
            foreach (int i in numList)
            {
                listGen += $"{i}, ";
            }
            sortedBox.Text = listGen;
        }

        private void generateList(int num, int min, int max)
        {
            for (int i = 0; i < num; i++)
            {
                numList.Add(rand.Next(min, max+1));
            }
        }

        private void quickSort(int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(start, end);
                quickSort(start, i - 1);
                quickSort(i + 1, end);
            }
        }

        private int Partition(int start, int end)
        {
            int p = numList[end];
            int i = start - 1;
            for(int j=start; j < end; j++)
            {
                if (numList[j] <= p)
                {
                    i++;
                    swap(i, j);
                }
            }
            swap(i + 1, end);
            return i + 1;
        }

        private void insertionSort()
        {
            int j;
            int temp;
            for (int i=1; i < numList.Count; i++)
            {
                temp = numList[i];
                j = i - 1;
                while((j>=0)&&(numList[j]>temp))
                {
                    numList[j + 1] = numList[j];
                    j--;
                }
                numList[j + 1] = temp;
            }
        }

        private void selectionSort()
        {
            for(int i = 0; i < numList.Count; i++)
            {
                int maxP = 0;
                int lastP = numList.Count - 1 - i;
                for (int j=0; j < numList.Count - i; j++)
                {
                    if (numList[j] > numList[maxP])
                        maxP = j;
                }
                swap(maxP, lastP);
            }
        }

        private void swap(int a, int b)
        {
            System.Diagnostics.Trace.WriteLine(a);
            int temp = numList[a];
            numList[a] = numList[b];
            numList[b] = temp;
        }

        private void bubbleSort()
        {
            for (int i = 0; i < numList.Count; i++)
            {
                for (int j = 0; j < numList.Count - i - 1;j++)
                {
                    if (numList[j] > numList[j + 1])
                        swap(j, j + 1);
                }
            }
        }
    }
}
