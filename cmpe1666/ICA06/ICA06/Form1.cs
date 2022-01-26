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
            if (textBox1.Text != "")//only executes if textbox has something in it
            {
                //add name from textbox to list and listbox
                names.Add(textBox1.Text);
                nameList.Items.Add(textBox1.Text);
                //sort list and add disaply in other listbox
                names.Sort();
                sortedNamesList.Items.Clear();
                foreach (string str in names)
                {
                    sortedNamesList.Items.Add(str);
                }
                //clear current text from textbox
                textBox1.Clear();
                textBox1.Focus();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //call recursive binary search for position of search text
            int position = -1;
            if (textBox1.Text != "")
                position = listSearch(textBox1.Text,0,names.Count-1, names);
            if (position == -1)
                MessageBox.Show($"{textBox1.Text} was not found in the list."); //message if no found (position -1)
            else
                MessageBox.Show($"{textBox1.Text} was found at position {position+1} in the list."); //message if found
            textBox1.Clear();//clear textbox after search
            textBox1.Focus();
        }

        private int listSearch(string str, int low, int high, List<string> list)
        {
            //set low and high (alphabetically) strings
            string first = list[low];
            string last = list[high];
            if (low > high)
                return -1;
            int mid = (low + high) / 2;//calc mid point of list
            if (str==list[mid])
                return mid;//return value when found
            else if (String.Compare(str,list[low]) < 0)//
                return listSearch(str, low, mid - 1, list);//call method with search limited to lower half
            else
                return listSearch(str, mid+1, high, list);//call method with search limited to upper half
        }
    }
}
