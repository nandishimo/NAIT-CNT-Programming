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

namespace ICA13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isPalindrome(string word)
        {
            int length = word.Length;
            if (length <= 1)
                return true;
            if (word[0] == word[length - 1])
            {
                return isPalindrome(word.Substring(1, length - 2));
            }
            else
                return false;
        }
        List<string> wordString = new List<string>();
        private void UI_Load_btn_Click(object sender, EventArgs e)
        {
            UI_OFD.ShowDialog();
            wordString = new List<string>(File.ReadAllLines(UI_OFD.FileName));
            /*
            DialogResult result = UI_OFD.ShowDialog();
            if(DialogResult.OK == result)
            {
                try
                {
                    
                    
                    StreamReader reader = new StreamReader(UI_OFD.FileName);
                    while(reader.Peek() != -1)
                    {
                        wordString.Add(reader.ReadLine());
                    }
                    reader.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }*/
            string str = "";
            foreach(string word in wordString)
            {
                str += word + ", ";
            }
            UI_Loaded_TB.Text = str;
        }

        private void UI_Find_btn_Click(object sender, EventArgs e)
        {

        }

        private void UI_Test_btn_Click(object sender, EventArgs e)
        {
            string message = "";
            if (isPalindrome(UI_Test_TB.Text))
            {
                message = $"{UI_Test_TB.Text} is a palindrome!";
            }
            else
            {
                message = $"{UI_Test_TB.Text} is NOT a palindrome!";
            }
            MessageBox.Show(message);


        }
    }
}
