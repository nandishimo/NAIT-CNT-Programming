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
    public TrekLamp(byte byToggle, Color LampColor, int border=2)
    {
      _byToggle = byToggle;
      _LampColor = LampColor;
      _border = border;
      Random random = new Random();
      _byTick = RandColor.GetColor().R;
    }
    public TrekLamp() : this(64,RandColor.GetColor(),6)
    {
      //default constructor
    }
    public void TickLamp()
    {
      _byTick+=3;
    }
    public void RedAlert(bool state)
    {
      if (state)
      {
        _byTick = _byToggle;
      }
      else
        _byTick = RandColor.GetColor().R;
    }
    public void RenderLamp(ref CDrawer window, int lamp)
    {
      if (_byTick > _byToggle)
      {
        window.AddRectangle(lamp % window.ScaledWidth, lamp / window.ScaledWidth, 1, 1, _LampColor, _border,Color.Black);
      }

      
    }
    
  }
}
