/*************************************
 * Submission Code: 1222_2800_A02_A04
 * ICA04 - LINQ
 * Nandish Patel
 * 2023/02/13
 ************************************/

using nandish_ICA03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Trace;

namespace nandish_ICA04
{
	public partial class Form1 : Form
	{
		List<string> sourcestrings = new List<string>(new string[] { "Caballo", "Gato", "Perro", "Conejo", "Tortuga", "Cangrejo" });

		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
			Text = "ICA04";
			AllowDrop= true;
			DragEnter += Form1_DragEnter;
			DragDrop += Form1_DragDrop;

		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			var fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First(); //get the first file incase multiple files are dropped at once 
																				  //read the contents of the file and create a list of words. filter out spaces and empty strings
			var sr = new StreamReader(fname);
			var contents = sr.ReadToEnd();
			sr.Close();
			var sw = new StreamWriter("output.txt", false);
			var strings = from str in contents.Split('\r','\n') where str.Length > 0 select str.Trim();
			var dict = strings.Categorize();
			foreach (var kvp in from kv in dict where kv.Value>1 select kv)
			{
				sw.WriteLine($"Duplicate found : {kvp.Key}");
			}

			var newDict = new Dictionary<char, LinkedList<string>>();
			foreach(var key in from kvp in dict orderby kvp.Value descending select kvp.Key)
			{
				var letter = key.ToLower().First();
				
				if(!newDict.ContainsKey(letter))
				{
					var newList = new LinkedList<string>();
					newList.AddLast(key);
					newDict.Add(letter, newList);
				}
				else
				{
					newDict[letter].AddLast(key);
				}
			}

			//newDict = newDict.OrderByDescending(kvp => kvp.Value.Count).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

			foreach(var kvp in newDict)
			{
				sw.WriteLine($"Words starting with {kvp.Key} : {kvp.Value.Count}");
			}
			//count number of words and categories and output to file
			sw.WriteLine($"There are a total of {newDict.Sum(kvp => kvp.Value.Count)} words and {newDict.Count} categories.");

			//find length of longest word(s) and output to file
			//int max = newDict.Max(kvp => kvp.Value.Max(x => x.Length));
			sw.WriteLine($"The longest word is {newDict.Max(kvp => kvp.Value.Max(x => x.Length))} characters");

			//foreach (var word in from longest in newDict.Values.SelectMany(l => l.Where(w => w.Length == newDict.Max(kvp => kvp.Value.Max(x => x.Length)))) select longest)
			//{
			//	sw.WriteLine($"Longest Words (tie for length): {word}");
			//}


			//display biggest of the longest words
			//sw.WriteLine($"The 'biggest', longest word is {newDict.Values.SelectMany(l=>l.Where(w=>w.Length== newDict.Max(kvp => kvp.Value.Max(x => x.Length)))).Max()}");

			//close streamreader and open output file
			sw.Close();
			Process.Start("notepad.exe", "output.txt");

		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			WriteLine("Part A - Q1");
			foreach (string s in from n in sourcestrings where n.Sum(c=>c) < 600 select n)
			{
				
				WriteLine(s);
			}
			WriteLine("\nPart A - Q2");
			foreach (var s in from n in sourcestrings where n.Sum(c=>c) < 600 select n)
			{
				
				WriteLine("Str = " + s.ToString() + ", Sum = " + s.Sum(c => c).ToString());
			}
			WriteLine("\nPart A - Q3");
			foreach (var s in from n in sourcestrings where n.Sum(c => c) < 600 orderby n descending select n)
			{
				
				WriteLine("Str = " + s.ToString() + ", Sum = " + s.Sum(c => c).ToString());
			}

		}
	}
}
