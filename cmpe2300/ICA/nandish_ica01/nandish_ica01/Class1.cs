using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Diagnostics.Trace;
using GDIDrawer;

/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_A01
***********************************/

namespace nandish_ica01
{
  internal class TrekLamp
  {
    private Color _LampColor;
    private byte _byToggle;
    private byte _byTick;
    private int _border;
    public TrekLamp(byte byToggle, Color LampColor, int border=2) //custom constructor takes, byte, color and integer
    {
      _byToggle = byToggle;
      _LampColor = LampColor;
      _border = border;
      _byTick = RandColor.GetColor().R;
    }
    public TrekLamp() : this(64,RandColor.GetColor(),6) //default constructor with toggle of 64, random color and border of 6
    {
      //default constructor
    }
    public void TickLamp()  //takes nothing and returns nothing. increments tick value
    {
      _byTick+=3;
    }
    public void RedAlert(bool state) //takes a bool and returns nothing. sets tick value = toggle if true, random color if not
    {
      if (state)
      {
        _byTick = _byToggle;
      }
      else
        _byTick = RandColor.GetColor().R;
    }
    public void RenderLamp(ref CDrawer window, int lamp) //takes Drawer reference and integer. returns nothing. renders lamp to drawer if tick > toggle(threshold)
    {
      if (_byTick > _byToggle)
      {
        window.AddRectangle(lamp % window.ScaledWidth, lamp / window.ScaledWidth, 1, 1, _LampColor, _border,Color.Black);
      }
      
    }
    
  }
}
