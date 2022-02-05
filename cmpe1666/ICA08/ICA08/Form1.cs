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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ICA08
{
    public struct Employee
    {
        public string id;
        public string salary;


    }
    public partial class Form1 : Form
    {


        
        public Form1()
        {
            InitializeComponent();
            List<string> providedIDs = new List<string>(){ "28", "53", "12", "18", "8", "2", "19", "57", "62", "34", "23", "14", "48", "35", "55", "22", "26", "15", "7", "9", "32", "43", "41", "51"};
            List<string> providedSalary = new List<string>() { "4500", "2800", "1900", "3100", "7000", "3500", "2200", "2800", "2850", "3150", "4000", "4500", "6000", "7200", "3700", "2100", "2450", "2500", "3250", "3700", "3800", "4200", "4100", "3900"};
        }
        List<Employee> employees = new List<Employee>();

        public void fileRead(string fileName1, string fileName2, ref List<string> IDs, ref List<string> salary)
        {
            StreamReader sr1 = new StreamReader(fileName1);
            StreamReader sr2 = new StreamReader(fileName2);
            while (!sr1.EndOfStream)
            {
                IDs.Add(sr1.ReadLine());
                salary.Add(sr2.ReadLine());
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            List<string> IDs = new List<string>();
            List<string> salary = new List<string>();
            openFileDialog1.ShowDialog();
            string fn1 = openFileDialog1.FileName;
            openFileDialog2.ShowDialog();
            string fn2 = openFileDialog2.FileName;
            fileRead(fn1, fn2, ref IDs, ref salary);
            List<Employee> employees = new List<Employee>();
            for(int i = 0; i<IDs.Count; i++)
            {
                Employee newEmployee = new Employee();
                newEmployee.id = IDs[i];
                newEmployee.salary = salary[i];
                employees.Add(newEmployee);
            }
            foreach(Employee emp in employees)
            {
                unsortedBox.Items.Add($"{emp.id}:\t{emp.salary}");
            }

        }

        private void clearSortedButton_Click(object sender, EventArgs e)
        {
            sortedBox.ClearSelected();
        }
    }
}
