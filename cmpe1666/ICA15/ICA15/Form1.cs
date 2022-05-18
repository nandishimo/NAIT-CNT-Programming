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
        Thread th1 = null;
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
            UI_BTN_GenerateS.Enabled = false;
            UI_LB_RawData.Items.Clear();
            th1 = new Thread(GenerateRawData);
            th1.IsBackground = true;
            th1.Start();
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
    }
}
