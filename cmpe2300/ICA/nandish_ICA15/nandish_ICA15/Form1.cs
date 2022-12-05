using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nandish_ICA15
{
  public partial class Form1 : Form
  {
    List<BaseShape> shapes = new List<BaseShape>();
    PicDrawer drawer = null;
    Random rand = new Random();
    public Form1()
    {
      InitializeComponent();
      drawer = new PicDrawer();
      drawer.ContinuousUpdate = false;
      Timer timer = new Timer();
      timer.Interval = 50;
      timer.Enabled = true;
      timer.Tick += Timer_Tick;
      KeyDown += Form1_KeyDown;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      drawer.GetLastMousePosition(out Point mouse);

      switch (e.KeyCode)
      {
        case Keys.C:
          shapes.Clear();
          break;
        case Keys.S:
          shapes.Add(new Snake(mouse, rand.Next(20, 61)));
          break;
        case Keys.B:
          shapes.Add(new Blob(mouse, Color.Blue, rand.Next(30, 51)));
          break;
      }
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      drawer.Clear();
      shapes.RemoveAll(shape =>
      {
        Snake s = shape as Snake;
        bool? val = s.Step();
        if(val== null)
          return false;
        else
          return val.Value;
      }
      );
      shapes.Where(shape => shape is Blob).ToList().ForEach(blob => blob.Animate);
      drawer.Render();
    }
  }
}
