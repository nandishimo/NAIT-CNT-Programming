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
    public partial class Form1 : Form
    {
        public struct Employee
        {
            public int id;
            public int salary;
            
        }
        public static void serializeEmployeeArray(Employee[] employees, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, employees);
            fs.Close();
        }

        public static Employee[] deserializationEmployeeArray(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Employee[] array = (Employee[])bf.Deserialize(fs);
            fs.Close();
            return (array);
        }

        public Form1()
        {
            InitializeComponent();
            //List<Employee> employees.id ={ 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
            //int[] salaries = { 4500, 2800, 1900, 3100, 7000, 3500, 2200, 2800, 2850, 3150, 4000, 4500, 6000, 7200, 3700, 2100, 2450, 2500, 3250, 3700, 3800, 4200, 4100, 3900 };
        }
        Employee[] employees = new Employee[24];

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fn = openFileDialog1.FileName;
            Employee[] employees = new Employee[1000];
            employees = deserializationEmployeeArray(fn);
            
        }
    }
}
