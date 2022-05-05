using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1666_LE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_lb_NameList.Items.Add("Example Name"); //add example name to listbox in start
        }

        private void UI_btn_AddName_Click(object sender, EventArgs e)
        {
            ModalForm dlg = new ModalForm();//create new instance of modal form
            if(UI_lb_NameList.SelectedIndex!=-1)
            {
                dlg.string1 = UI_lb_NameList.SelectedItem.ToString();//display selected name in listbox
            }
            else
            {
                dlg.string1 = "no selection";//if nothing is selected in listbox, display no selection
            }
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                if (dlg.string1!="")
                    UI_lb_NameList.Items.Add(dlg.string1);//add name to listbox if its not empty
            }
            UI_lb_NameList.SelectedIndex = -1;//unselect item in listbox

        }
    }
}
