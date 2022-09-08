using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Trace;

namespace NandishPatel_Demo01
{
  public partial class Form1 : Form
  {
    DemoDialog _demoDialog = null;
    int _iWheelValue = 0;
    int _iCaptureValue = 100;
    int _iCaptureXStart = 0;
    int _iTempCapture = 0;

    public Form1()
    {
      InitializeComponent();
      Text = "Demo01";
      _pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      Shown += Form1_Shown;
      MouseWheel += Form1_MouseWheel;//not needed, shows rejection
      lbl_Wheel.MouseWheel += Form1_MouseWheel;
      lbl_Capture.MouseDown += Lbl_Capture_MouseDown;
      lbl_Capture.MouseMove += Lbl_Capture_MouseMove;
      lbl_Capture.MouseUp += Lbl_Capture_MouseUp;
      lbl_Capture.Text = _iCaptureValue.ToString();
      Click += Form1_Click;
      AllowDrop = true;
      _pb.DragEnter += _pb_DragEnter;
      _pb.DragDrop += _pb_DragDrop;
    }

    private void _pb_DragDrop(object sender, DragEventArgs e)
    {
      //throw new NotImplementedException();
    }

    private void _pb_DragEnter(object sender, DragEventArgs e)
    {
      //e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop);
    }

    private void Form1_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
    }

    private void Lbl_Capture_MouseUp(object sender, MouseEventArgs e)
    {
      _iCaptureValue = _iTempCapture;
    }

    private void Lbl_Capture_MouseMove(object sender, MouseEventArgs e)
    {
      //WriteLine(e.X.ToString());
      if (!lbl_Capture.Capture) return;
      _iTempCapture += (e.X-_iCaptureXStart)/10;
      lbl_Capture.Text = _iTempCapture.ToString();
    }

    private void Lbl_Capture_MouseDown(object sender, MouseEventArgs e)
    {
      _iCaptureXStart = e.X; //save start position of mouse down
    }

    private void Form1_MouseWheel(object sender, MouseEventArgs e)
    {
      if (sender != lbl_Wheel) return; //reject if not sent by wheel label
      if (sender is Form1) return; //reject if sender is of type Form
      //WriteLine(e.Delta.ToString());//+120 or -120
      _iWheelValue += e.Delta > 0 ? 1 : -1;
      lbl_Wheel.Text = _iWheelValue.ToString();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      //Allocate a DemoDialog
      _demoDialog = new DemoDialog();
      _demoDialog._GetColor += _demoDialog__GetColor;
      _demoDialog.StartPosition = FormStartPosition.Manual;
      _demoDialog.Location = new Point(this.Left + this.Width, this.Top);
      _demoDialog.Show();
      DemoDialog _dd2 = new DemoDialog();
      _dd2._GetColor += _demoDialog__GetColor;//subscribe to dd event as well
      _dd2.Show();
    }

    private void _demoDialog__GetColor(object sender, Color color)
    {
      BackColor = color;
      //unsubscribe literally
      //_demoDialog._GetColor -= _demoDialog__GetColor;

      //unsubscribe from whoever called
      if(sender is DemoDialog dd)
      {
        dd._GetColor -= _demoDialog__GetColor;  
      }
    }
  }
}
