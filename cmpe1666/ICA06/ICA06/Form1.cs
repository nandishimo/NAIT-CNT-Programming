using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA06
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                names.Add(textBox1.Text);
                nameList.Items.Add(textBox1.Text);
                names.Sort();
                sortedNamesList.Items.Clear();
                foreach (string str in names)
                {
                    sortedNamesList.Items.Add(str);
                }
                textBox1.Clear();
                textBox1.Focus();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int position = -1;
            if (textBox1.Text != "")
                position = listSearch(textBox1.Text,0,names.Count-1, names);
            if (position == -1)
                MessageBox.Show($"{textBox1.Text} was not found in the list.");
            else
                MessageBox.Show($"{textBox1.Text} was found at position {position+1} in the list.");
        }

        private int listSearch(string str, int low, int high, List<string> list)
        {
            string first = list[low];
            string last = list[high];
            if (low > high)
                return -1;
            int mid = (low + high) / 2;
            if (str==list[mid])
                return mid;
            else if (String.Compare(str,list[low]) < 0)
                return listSearch(str, low, mid - 1, list);
            else
                return listSearch(str, mid+1, high, list);
        }
    }
}
