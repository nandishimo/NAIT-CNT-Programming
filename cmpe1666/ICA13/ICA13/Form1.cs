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
using System.Threading;
/*Made by Nandish Patel
 *May 2022
 */
namespace ICA13
{
    delegate void delListToTB(TextBox tb, List<string> list);//delegate to take tb element and list of strings
    public partial class Form1 : Form
    {
        delListToTB _dDisplayPalindromes = null; //create instance of delegate to display palindromes
        Thread th1 = null; //thread for find palindromes method
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); //stopwatch to time palindrome finding

        public Form1()
        {
            InitializeComponent();
        }

        private bool isPalindrome(string word) //check word if palindrome
        {
            int length = word.Length;
            if (length <= 1)
                return true;
            if (word[0] == word[length - 1])
            {
                return isPalindrome(word.Substring(1, length - 2));//recursively check if ith and (n-ith) letter are the same
            }
            else
                return false;
        }

        private void findPalindromes()//check if palindrome, but for a whole list of strings this time.
        {
            _dDisplayPalindromes = new delListToTB(PushListToTB);
            List<string> palindromes = new List<string>();
            foreach (string word in wordString)
            {
                if (isPalindrome(word))
                    palindromes.Add(word);
            }
            Invoke(_dDisplayPalindromes, UI_Loaded_TB, palindromes);//push found palindromes to display after complete.
        }
        List<string> wordString = null;
        private void UI_Load_btn_Click(object sender, EventArgs e)
        {
            UI_OFD.ShowDialog();
            wordString = new List<string>(File.ReadAllLines(UI_OFD.FileName)); //read words from file and load into list fo strings
            UI_Loaded_TB.Text = $"Loaded {wordString.Count()} words!";
        }

        private void UI_Find_btn_Click(object sender, EventArgs e)
        {//restart sw and start background thread to find all palindromes loaded
            sw.Restart();
            th1 = new Thread(findPalindromes);
            th1.IsBackground = true;
            th1.Start();
        }

        private void UI_Test_btn_Click(object sender, EventArgs e)
        { //test single words from textbox 
            string message = "";
            if (UI_Test_TB.Text == "")
                return;
            if (isPalindrome(UI_Test_TB.Text))
            {
                message = $"{UI_Test_TB.Text} is a palindrome!";
            }
            else
            {
                message = $"{UI_Test_TB.Text} is NOT a palindrome!";
            }
            UI_Test_TB.Text = message;
        }

        private void PushListToTB(TextBox tb, List<string> list)
        { //method to display a list of strings in a textbox
            string str = "";
            foreach(string word in list)
            {
                str += word + ", ";
            }
            tb.Text = str+ " ----- "+list.Count + " palindromes were found in "+sw.ElapsedMilliseconds+"ms";
            sw.Stop();
        }
    }
}
