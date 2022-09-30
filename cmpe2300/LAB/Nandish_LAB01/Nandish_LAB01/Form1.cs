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
  public partial class Form1 : Form
  {
    TileDialog _tileDialog = null; //modeless dialog reference

    Random rand = new Random();
    Timer timer = new Timer();
    List<TileDialog> gameTiles = null;
    List<TileDialog> selectedTiles = new List<TileDialog>();
    public delegate void TurnHandler(object sender);
    public event TurnHandler turnTile = null;
    

    int tileSetCount = 5;
    int tmpTileSet = 0;
    int matchCount = 3;
    int currentMatches = 0;
    int captureYStart = 0;

    public Form1()
    {
      InitializeComponent();
      Text = "CMPE2300 - Lab01 - Concentration";
      _lblTileSets.Text = $"Tile Sets: {tileSetCount}";
      _lblMatchCount.Text =  $"Matches: {matchCount}";
      turnTile += Form1_turnTile;
      _lblMatchCount.MouseWheel += _lblMatchCount_MouseWheel;
      _lblTileSets.MouseDown += _lblTileSets_MouseDown;
      _lblTileSets.MouseMove += _lblTileSets_MouseMove;
      _lblTileSets.MouseUp += _lblTileSets_MouseUp;
      _butStart.Click += _butStart_Click;
      _cbCheat.Click += _cbCheat_Click;
    }

    private void _cbCheat_Click(object sender, EventArgs e)
    {
      if(gameTiles==null)
      {
        return;
      }
      foreach (TileDialog tile in gameTiles)
      {
        tile.Cheat = _cbCheat.Checked;
      }
    }

    public List<string> GetShuffledTileLetters()
    {
      List<string> tileLetters = new List<string>();
      for (int i = 0; i < tileSetCount; ++i)
      {
        for (int j = 0; j < matchCount; ++j)
        {
          tileLetters.Add(Convert.ToChar('A'+i).ToString());
        }
      }
      return tileLetters;
    }
    
    private void _butStart_Click(object sender, EventArgs e)
    {
      List<string> shuffledLetters = GetShuffledTileLetters();
      Screen screen = Screen.FromControl(this); //get the screen the main form is on
      if (gameTiles == null)
        gameTiles = new List<TileDialog>();
      if (gameTiles.Count != 0)
      {
        foreach (TileDialog tile in gameTiles)
        {
          //tile.DialogResult = DialogResult.OK;
          tile.TileTurnHandler(TileDialog.hideOrClose._close);
        }
        gameTiles.Clear();
      }
      for (int i = 0; i<tileSetCount*matchCount; ++i)
      {
        _tileDialog = new TileDialog();
        _tileDialog.Secret = shuffledLetters[i];
        _tileDialog.StartPosition = FormStartPosition.Manual;
        _tileDialog.Cheat = _cbCheat.Checked;
        //turnTile += _tileDialog
        if(gameTiles.Count ==0)
          _tileDialog.Location = new Point(this.Left, this.Bottom + 2);
        else
          _tileDialog.Location = new Point(gameTiles.Last().Left+_tileDialog.Width+2, gameTiles.Last().Top);
        if (_tileDialog.Right > screen.WorkingArea.Right) //wrap tiles to next row if they go past end of screen
          _tileDialog.Location = new Point(gameTiles.First().Left,gameTiles.Last().Bottom+2);
        _tileDialog.Show();
        gameTiles.Add(_tileDialog);
      }
    }

    private void _lblTileSets_MouseUp(object sender, MouseEventArgs e)
    {
      _lblTileSets.Capture = false; //disabled capture
      tileSetCount = Math.Abs(tmpTileSet); //save tmp setcount back to original
    }

    private void _lblTileSets_MouseMove(object sender, MouseEventArgs e)
    {
      if (!_lblTileSets.Capture)//leave if capture is not enabled
        return;
      tmpTileSet = tileSetCount; //save current set count to tmp
      tmpTileSet += (captureYStart-e.Y) / 10; //adjust tmp count for new mouse position
      if (tmpTileSet < 2)
        tmpTileSet = 2;
      _lblTileSets.Text = $"Tile Sets: {tmpTileSet}"; //update label
    }

    private void _lblTileSets_MouseDown(object sender, MouseEventArgs e)
    {
      _lblTileSets.Capture = true; //enables mouse move and continues captures off the label
      captureYStart = e.Y; //saves y position of mouse
    }

    private void Form1_turnTile(object sender)
    {
      throw new NotImplementedException();
    }

    private void _lblMatchCount_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta > 0) //if mousewheel scrolled up, increase match count
        matchCount++;
      else if(matchCount>2) //decrease match count if wheel scrolls down
        matchCount--;
      _lblMatchCount.Text = $"Matches: {matchCount}";
    }
  }
  struct Tile
  {
    private int iNum;
    public Tile(int iVal)
    {
      iNum = iVal;
    }
  }
}
