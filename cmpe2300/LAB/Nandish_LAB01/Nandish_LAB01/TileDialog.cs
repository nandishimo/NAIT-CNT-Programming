/***********************************
*Nandish Patel
*CMPE2300
*Submission Code : 1221_2300_L01
***********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nandish_LAB01
{
  public partial class TileDialog : Form
  {
    public enum hideOrClose
    {
      _hide,
      _close
    }
    public delegate void TurnHandler(hideOrClose hoc);
    public event TurnHandler _turntile = null;
    public event EventHandler _guessClick = null;
    public event EventHandler _turnComplete = null;
    public string Secret
    {
      get
      {
        return _lblChar.Text;
      }
      set
      {
        _lblChar.Text = value;
      }
    }
    public bool ShowSecret { 
      set
      {
        if(value)
        {
          _lblChar.ForeColor = Color.Black;
        }
        else
        {
          _lblChar.ForeColor = _lblChar.BackColor;
        }
      } 
    }
    public bool Cheat
    {
      set
      {
        Tag = value;
      }
    }
    Timer timer = new Timer();
    const int maxFontSize = 64;
    int fontSize = maxFontSize;
    
    public TileDialog()
    {
      InitializeComponent();
      StartPosition = FormStartPosition.Manual;
      Text = "Tile";
      Cheat = false;
      _lblChar.Font = new Font("Sans Serif", fontSize);
      timer.Interval = 20;
      _lblChar.BackColor = _lblChar.ForeColor = BackColor;
      //Click += TileDialog_Click;
      _lblChar.Click += TileDialog_Click;
      timer.Tick += Timer_Tick;
      _lblChar.MouseEnter += _lblChar_MouseEnter;
      _lblChar.MouseLeave += _lblChar_MouseLeave;
    }

    public void Set(Point location)
    {
      Location = location;
    }
    public void TileTurnHandler(hideOrClose hoc)
    {
      if (hoc == hideOrClose._hide)
      {
        timer.Enabled = true;
      }
      else if(hoc == hideOrClose._close)
      {
        _turnComplete?.Invoke(this, EventArgs.Empty);
        Close();
      }
    }

    private void _lblChar_MouseLeave(object sender, EventArgs e)
    {
      if ((bool)Tag)
        ShowSecret = false;
    }

    private void _lblChar_MouseEnter(object sender, EventArgs e)
    {
      if ((bool)Tag)
        ShowSecret = (bool)Tag;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      _lblChar.Click -= TileDialog_Click;
      fontSize--;
      if (fontSize < 1)
      {
        timer.Enabled = false;
        _lblChar.Click += TileDialog_Click;
        _lblChar.ForeColor = _lblChar.BackColor;
        fontSize = maxFontSize;
        _lblChar.Font = new Font(_lblChar.Font.FontFamily, fontSize, _lblChar.Font.Style);
        Invoke(_turnComplete);
      }
      else
      {
        _lblChar.Font = new Font(_lblChar.Font.FontFamily, fontSize, _lblChar.Font.Style);
      }
    }

    private void TileDialog_Click(object sender, EventArgs e)
    {
      _guessClick?.Invoke(this, e);

    }
  }
}
