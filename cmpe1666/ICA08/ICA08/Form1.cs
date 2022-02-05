using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICA08
{
    public struct Employee//struct employees, have ids and salaries
    {
        public int id;
        public int salary;
    }
    public partial class Form1 : Form
    {
        //hardcoded lists for provided IDs and salaries
        List<int> providedIDs = new List<int>() { 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
        List<int> providedSalary = new List<int>() { 4500, 2800, 1900, 3100, 7000, 3500, 2200, 2800, 2850, 3150, 4000, 4500, 6000, 7200, 3700, 2100, 2450, 2500, 3250, 3700, 3800, 4200, 4100, 3900 };
        List<int> IDs = new List<int>();
        List<int> salary = new List<int>();
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Employee> employees = new List<Employee>(); //store unsorted list
        List<Employee> cloneEmployees = new List<Employee>(); //clone list to be sorted / operated on
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        private void loadButton_Click(object sender, EventArgs e) //opens dialog boxes for employee ids and salary
        {
            openFileDialog1.ShowDialog();
            string fn1 = openFileDialog1.FileName;
            openFileDialog2.ShowDialog();
            string fn2 = openFileDialog2.FileName;
            fileRead(fn1, fn2, ref IDs, ref salary);//read files
            loadButton.Enabled = false; //disable button after load
            
        }

        private void clearSortedButton_Click(object sender, EventArgs e)
        {
            sortedBox.Items.Clear();
        }

        private void bubbleSort(ref List<Employee> list)
        {
            for (int i = 0; i < list.Count; i++)//pass through list n times
            {
                for (int j = 0; j < list.Count - i - 1; j++)//each pass starts at 0 and moves up to last "unsorted value"
                {
                    if (list[j].id > list[j + 1].id) //swaps value of index into the next index if higher, this carries the highest value to the end
                        swap(ref list, j, j + 1);
                }
            }
        }

        private void quickSort(ref List<Employee> list, int start, int end)//references a list and start and end parameters
        {
            int i;
            if (start < end)
            {
                i = Partition(ref list, start, end);//passes list reference, start and end parameters
                quickSort(ref list, start, i - 1); //recursion on left side of partition
                quickSort(ref list, i + 1, end); //recursion on right side of partition
            }
        }
        private int Partition(ref List<Employee> list, int start, int end)
        {
            int p = list[end].id;//grabs last value as "middle" value for partition
            int i = start - 1;
            for (int j = start; j < end; j++)//passes through each index, start to finish
            {
                if (list[j].id <= p)//swaps value to left most index that hasnt been swapped yet if its smaller than "middle" point
                {
                    i++;
                    swap(ref list, i, j);//swap helper method
                }
            }
            swap(ref list, i + 1, end);//swap helper method
            return i + 1;
        }
        private void swap(ref List<Employee> list, int a, int b)//pass list reference and indices for values to swap
        {
            Employee temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        public void fileRead(string fileName1, string fileName2, ref List<int> IDs, ref List<int> salary)
        {
            //open two streamreaders for different files
            StreamReader sr1 = new StreamReader(fileName1);
            StreamReader sr2 = new StreamReader(fileName2);
            int id;
            int sal;
            try
            {
                while (!sr1.EndOfStream)
                {
                    int.TryParse(sr1.ReadLine(), out id);
                    int.TryParse(sr2.ReadLine(), out sal);
                    IDs.Add(id);
                    salary.Add(sal);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void quickSortButton_Click(object sender, EventArgs e)
        {
            unsortClone();
            sw.Start();
            quickSort(ref cloneEmployees, 0, cloneEmployees.Count-1);
            sw.Stop();
            displayList(cloneEmployees, sortedBox);
            displayTicks();
        }

        private void displayUnsortedButton_Click(object sender, EventArgs e)
        {
            employees.Clear();
            if (providedListRadio.Checked)
            {
                for (int i = 0; i < providedIDs.Count; i++)
                {
                    Employee newEmployee = new Employee();
                    newEmployee.id = providedIDs[i];
                    newEmployee.salary = providedSalary[i];
                    employees.Add(newEmployee);
                }
            }
            else
            {
                for (int i = 0; i < IDs.Count; i++)
                {
                    Employee newEmployee = new Employee();
                    newEmployee.id = IDs[i];
                    newEmployee.salary = salary[i];
                    employees.Add(newEmployee);
                }
            }
            displayList(employees, unsortedBox);
            unsortClone();
        }

        private void clearUnsortedButton_Click(object sender, EventArgs e)//clears the unsorted box display
        {
            unsortedBox.Items.Clear();
        }

        private void displayList(List<Employee> list, ListBox box) //display specified Employee list into specified list box
        {
            box.Items.Clear();
            foreach (Employee emp in list)
            {
                box.Items.Add($"{emp.id}:\t{emp.salary}");
            }
        }
        private void unsortClone()//clears clonelist and replaces items from unsorted list
        {
            cloneEmployees.Clear();
            for (int i = 0; i <employees.Count; i++)
            {
                cloneEmployees.Add(employees[i]);
            }
        }

        private void nSquaredSortButton_Click(object sender, EventArgs e)//runs bubble sort and displays results and elapsed ticks
        {
            unsortClone();
            sw.Start();
            bubbleSort(ref cloneEmployees);
            sw.Stop();
            displayList(cloneEmployees, sortedBox); //show sorted list
            displayTicks();//display elapsed ticks and reset sw
        }

        private void displayTicks()//display elapsed sw ticks
        {
            elapsedTicksBox.Text = sw.ElapsedTicks.ToString();
            sw.Reset();
        }

    }
}
