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
    {//readable code to hide or close dialog
      _hide,
      _close
    }
    public int endingTurn = 0;//so main form knows if end turn processing(animation) is done
    // delegates/events
    public delegate void TurnHandler(hideOrClose hoc);
    public event TurnHandler _turntile = null;
    public event EventHandler _guessClick = null;
    public event EventHandler _turnComplete = null;
    public string Secret
    {//get or set the secret letter for this tile
      get
      {
        return _lblChar.Text;
      }
      set
      {
        _lblChar.Text = value;
      }
    }
    public bool ShowSecret 
    { //determine if secrete letter is shown or not
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
    { //communicate with tile if cheat mode is enabled
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
      Text = "Tile";
      _lblChar.Font = new Font(_lblChar.Font.FontFamily, fontSize);
      timer.Interval = 20;
      _lblChar.BackColor = _lblChar.ForeColor = BackColor; //Set background of label to match tile and secret letter 
      //bind mouse/click and timer events
      _lblChar.Click += TileDialog_Click;
      timer.Tick += Timer_Tick;
      _lblChar.MouseEnter += _lblChar_MouseEnter;
      _lblChar.MouseLeave += _lblChar_MouseLeave;
    }
    /// <summary>
    /// Allows location of tile dialog to be set
    /// </summary>
    /// <param name="location"></param>
    public void Set(Point location)
    {
      Location = location;
    }
    /// <summary>
    /// Choose to hide or close dialog. 'Hiding' enables timer to handle animation
    /// </summary>
    /// <param name="hoc"></param>
    public void TileTurnHandler(hideOrClose hoc)
    {
      if (hoc == hideOrClose._hide)
      {
        timer.Enabled = true;
      }
      else if(hoc == hideOrClose._close)
      {
        _turnComplete?.Invoke(this, EventArgs.Empty);//bound to callback in main form
        Close();
      }
    }

    private void _lblChar_MouseLeave(object sender, EventArgs e)
    {
      Text = "Tile"; //always keep dialog text "Tile" by default
    }

    private void _lblChar_MouseEnter(object sender, EventArgs e)
    { //reveal secret letter if cheats(stored in Tag) enabled
      if((bool)Tag)
        Text = Secret;
    }
    /// <summary>
    /// Timer enabled upon complete selection but invalid matches.
    /// Reduce font size every tick to animate letters disappearing
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Timer_Tick(object sender, EventArgs e)
    {
      _lblChar.Click -= TileDialog_Click;//disable clicking on tile during animation
      fontSize--;//reduce font size every tick
      if (fontSize < 1)
      { //once font is small enough, hide by matching color to background,
        //rebind click event and invoke turnComplete callback in main form
        timer.Enabled = false;
        _lblChar.Click += TileDialog_Click;
        _lblChar.ForeColor = _lblChar.BackColor;
        fontSize = maxFontSize;
        _lblChar.Font = new Font(_lblChar.Font.FontFamily, fontSize, _lblChar.Font.Style);
        _turnComplete?.Invoke(this, EventArgs.Empty);//bound to callback in main form
      }
      else
      {
        _lblChar.Font = new Font(_lblChar.Font.FontFamily, fontSize, _lblChar.Font.Style);
      }
    }

    private void TileDialog_Click(object sender, EventArgs e)
    {
      if(endingTurn == 1)
      {//ignore if processing(animation)
        return;
      }
      _guessClick?.Invoke(this, e);//bound to callback in main form

    }
  }
}
