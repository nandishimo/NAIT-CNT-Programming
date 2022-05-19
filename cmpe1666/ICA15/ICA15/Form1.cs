using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ICA15
{
    public delegate void delVoidLBString(ListBox lb, string s);
    public partial class Form1 : Form
    {
        List<Sensor> RawSensorData = null;
        List<Sensor> RawSensorClone = null;
        List<Sensor> SortedClone = null;
        List<Sensor> SearchClone = null;
        Thread th1 = null;
        Thread th2 = null;
        Thread th3 = null;
        Random rand = new Random();
        public struct Sensor
        {
            public int ID;
            public float Temp;
            public Sensor(int id, float temp)
            {
                ID = id;
                Temp = temp;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_BTN_GenerateS_Click(object sender, EventArgs e)
        {
            if(int.TryParse(UI_TB_NumSensors.Text,out int i))
            {
                if (th1!=null)
                {
                    th1.Abort();
                }
                UI_LB_RawData.Items.Clear();
                th1 = new Thread(GenerateRawData);
                th1.IsBackground = true;
                th1.Start();
            }
        }
        private void UI_BTN_DisplaySorted_Click(object sender, EventArgs e)
        {
            if (th2!=null)
            {
                th2.Abort();
            }
            UI_LB_SortedData.Items.Clear();
            th2 = new Thread(SortData);
            th2.IsBackground = true;
            th2.Start();
        }
        private void GenerateRawData()
        {
            if (int.TryParse(UI_TB_NumSensors.Text, out int x))
            {
                RawSensorData = BuildSensorList(GenerateUniqueIDs(x), GenerateTemps(x));
                RawSensorClone = new List<Sensor>(RawSensorData);
                DisplayRawData();
            }
        }
        private List<Sensor> BuildSensorList(List<int> Sensors, List<int> Temps)
        {
            List<Sensor> SensorList = new List<Sensor>();
            for(int i = 0; i < Sensors.Count; i++)
            {
                SensorList.Add(new Sensor(Sensors[i], Temps[i]));
            }
            return SensorList;
        }
        private List<int> GenerateUniqueIDs(int x)
        {
            List<int> Sensors = new List<int>();
            do
            {
                int num = rand.Next(1, 5000);
                if (!Sensors.Contains(num))
                {
                    Sensors.Add(rand.Next(1, 5001));
                }
            } while (Sensors.Count < x);
            return Sensors;
        }
        private List<int> GenerateTemps(int x)
        {
            List<int> Temps = new List<int>();
            for(int i = 0; i<x; i++)
            {
                Temps.Add(rand.Next(-40, 41));
            }
            return Temps;
        }
        private void PushToLB(ListBox lb, string s)
        {
            lb.Items.Add(s);
        }
        private void DisplayRawData()
        {
            foreach (Sensor sens in RawSensorClone)
            {
                Invoke(new delVoidLBString(PushToLB), UI_LB_RawData, $"SensorID: { sens.ID}, Temperature: {sens.Temp}C");
                Thread.Sleep(100);
            }
        }

        private void UI_BTN_Redisplay_Click(object sender, EventArgs e)
        {
            UI_LB_RawData.Items.Clear();
            Thread thDisplay = new Thread(DisplayRawData);
            thDisplay.IsBackground = true;
            thDisplay.Start();
        }


        private void SortData()
        {
            SortedClone = new List<Sensor>(RawSensorClone);
            if (UI_RB_SensorID.Checked)
            {
                if (UI_RB_Ascending.Checked)
                {
                    SortedClone.Sort((x, y) => x.ID.CompareTo(y.ID));
                }
                else
                {
                    SortedClone.Sort((x, y) => y.ID.CompareTo(x.ID));
                }
            }
            else
            {
                if (UI_RB_Ascending.Checked)
                {
                    SortedClone.Sort((x, y) => x.Temp.CompareTo(y.Temp));
                }
                else
                {
                    SortedClone.Sort((x, y) => y.Temp.CompareTo(x.Temp));
                }
            }
            DisplaySortedData();
        }
        private void DisplaySortedData()
        {
            foreach (Sensor sens in SortedClone)
            {
                Invoke(new delVoidLBString(PushToLB), UI_LB_SortedData, $"SensorID: { sens.ID}, Temperature: {sens.Temp}C");
                Thread.Sleep(100);
            }
        }

        private void UI_BTN_DispSelected_Click(object sender, EventArgs e)
        {
            if (th3!=null)
            {
                th3.Abort();
            }
            UI_LB_SensorWTemp.Items.Clear();
            th3 = new Thread(FilterByTemp);
            th3.IsBackground = true;
            th3.Start();
        }
        private void FilterByTemp()
        {
            if(float.TryParse(UI_TB_TempValue.Text, out float f))
            {
                if (UI_RB_Greater.Checked)
                {
                    SearchClone = RawSensorData.FindAll(x => x.Temp > f);
                }
                else
                {
                    SearchClone = RawSensorData.FindAll(x => x.Temp < f);
                }
            }
            DisplayFilteredData();
        }
        private void DisplayFilteredData()
        {
            foreach (Sensor sens in SearchClone)
            {
                Invoke(new delVoidLBString(PushToLB), UI_LB_SensorWTemp, $"SensorID: { sens.ID}, Temperature: {sens.Temp}C");
                Thread.Sleep(100);
            }
        }
    }
}
