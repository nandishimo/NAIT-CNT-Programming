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

namespace ICA13
{
    delegate void delListToTB(TextBox tb, List<string> list);
    public partial class Form1 : Form
    {
        delListToTB _dDisplayPalindromes = null;
        Thread th1 = null;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

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

        private void findPalindromes()
        {
            _dDisplayPalindromes = new delListToTB(PushListToTB);
            List<string> palindromes = new List<string>();
            foreach (string word in wordString)
            {
                if (isPalindrome(word))
                    palindromes.Add(word);
            }
            Invoke(_dDisplayPalindromes, UI_Loaded_TB, palindromes);
        }
        List<string> wordString = null;
        private void UI_Load_btn_Click(object sender, EventArgs e)
        {
            UI_OFD.ShowDialog();
            wordString = new List<string>(File.ReadAllLines(UI_OFD.FileName));
            UI_Loaded_TB.Text = $"Loaded {wordString.Count()} words!";
        }

        private void UI_Find_btn_Click(object sender, EventArgs e)
        {
            sw.Restart();
            th1 = new Thread(findPalindromes);
            th1.IsBackground = true;
            th1.Start();
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
            UI_Test_TB.Text = message;
        }

        private void PushListToTB(TextBox tb, List<string> list)
        {
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
