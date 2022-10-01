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
    Timer timer = new Timer();
    Random rand = new Random(); //used for randomizing order of secret letters
    List<TileDialog> gameTiles = null;
    List<TileDialog> selectedTiles = new List<TileDialog>();
    int tileSetCount = 3;
    int tmpTileSet = 0;
    int matchCount = 3;
    int currentMatches = 0;
    int clicks = 0;
    int captureYStart = 0;

    //delegates and event handlers

    //public delegate void dGuessCallback(object sender, EventArgs e);
    //public event dGuessCallback _GuessCallback = null;
    //public delegate void dTurnCompleteCallback(object sender);
    //public event dTurnCompleteCallback _TurnCompleteCallback = null;

    public Form1()
    {
      InitializeComponent();
      Text = "CMPE2300 - Lab01 - Concentration";
      _lblTileSets.Text = $"Tile Sets: {tileSetCount}";
      _lblMatchCount.Text =  $"Matches: {matchCount}";
      timer.Interval = 500;
      //bind mouse and click events
      _lblMatchCount.MouseWheel += _lblMatchCount_MouseWheel;
      _lblTileSets.MouseDown += _lblTileSets_MouseDown;
      _lblTileSets.MouseMove += _lblTileSets_MouseMove;
      _lblTileSets.MouseUp += _lblTileSets_MouseUp;
      _butStart.Click += _butStart_Click;
      _cbCheat.Click += _cbCheat_Click;
      timer.Tick += Timer_Tick;
      Shown += Form1_Shown;
    }


    private void Form1_Shown(object sender, EventArgs e)
    {//show main form in top left of window
      StartPosition = FormStartPosition.Manual;
      Location = new Point (5,15);
    }

    private void _cbCheat_Click(object sender, EventArgs e)
    {// if checked, sets cheat property in all game tiles to true
      if(gameTiles==null)
      {
        return;
      }
      foreach (TileDialog tile in gameTiles)
      {
        tile.Cheat = _cbCheat.Checked;
      }
    }
    /// <summary>
    /// Creates a list of letters based on the user specified tileSetCount and matchCount.
    /// Uses Fisher-Yates shuffle method to randomize the order
    /// </summary>
    /// <returns>Returns a list of type string random order</returns>
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
      for(int i = tileLetters.Count()-1;i>0;i--)
      {
        int j = rand.Next(i + 1);
        string temp = tileLetters[j];
        tileLetters[j] = tileLetters[i];
        tileLetters[i] = temp;
      }
      return tileLetters;
    }
    
    /// <summary>
    /// Click event for the 'Start' button. Resets relevant values and tiles and displays a new game.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void _butStart_Click(object sender, EventArgs e)
    {
      //resets initial values in case of new game after playing 
      Text = "CMPE2300 - Lab01 - Concentration";
      clicks = 0;
      currentMatches = 0;
      List<string> shuffledLetters = GetShuffledTileLetters(); //get random order list of letters according to user specifications
      Screen screen = Screen.FromControl(this); //get the screen the main form is on
      if (gameTiles == null) //if a list of game tiles doesnt exist, make a new one
        gameTiles = new List<TileDialog>();
      if (gameTiles.Count != 0)
      {//if list of game tiles is not empty, close existing tiles through TileTurnHandler
        foreach (TileDialog tile in gameTiles)
        {
          tile.TileTurnHandler(TileDialog.hideOrClose._close);
        }
        gameTiles.Clear();//empty list of tiles after closing dialogs
      }
      for (int i = 0; i<tileSetCount*matchCount; ++i)
      { //create # of tiles required for X sets of Y matches
        _tileDialog = new TileDialog();  //create new game tile
        _tileDialog.Secret = shuffledLetters[i]; //set hidden letter
        _tileDialog.StartPosition = FormStartPosition.Manual;
        _tileDialog.Cheat = _cbCheat.Checked;//set initial cheat value based on state of cheackbox
        _tileDialog._turnComplete += TurnCompleteCallback; //bind turn complete and guess click callback events
        _tileDialog._guessClick += GuessCallback;

        if (gameTiles.Count == 0) //set first game tile to be just under main form
          _tileDialog.Set(new Point(this.Left, this.Bottom + 2));
        else
          //subsequent tiles to be placed to the right of previous tile.
          _tileDialog.Set(new Point(gameTiles.Last().Left + _tileDialog.Width + 2, gameTiles.Last().Top));
        if (_tileDialog.Right > screen.WorkingArea.Right) //wrap tiles to next row if they go past end of screen
          _tileDialog.Set(new Point(gameTiles.First().Left, gameTiles.Last().Bottom + 2));
        _tileDialog.Show(); //show the tile
        gameTiles.Add(_tileDialog); //add tile to game tile list
      }
    }
    /// <summary>
    /// Tile Click / Guess Callback
    /// tracked number of selected tiles and determines if a valid match has been made
    /// calls turntile to hide if invalid match or close tile dialog if valid match
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void GuessCallback(object sender, EventArgs e)
    {
      if (sender is TileDialog td)
      {
        if (selectedTiles.Contains(td))//ignore if tile has already been selected
          return;
        else
        {
          clicks++;//count clicks
          selectedTiles.Add(td); //track selected tiles by adding to a list
          td._turntile += Td__turntile;//bind the turntile event
          td.ShowSecret = true;//reveal the letter
          if (selectedTiles.Count == matchCount)
          {
            foreach(TileDialog tileD in gameTiles)
            {
              tileD.endingTurn = 1;//lets tiles know that turn end is processing. clicks will be ignored
            }
            List<string> tileString = new List<string>();
            foreach (TileDialog tile in selectedTiles)
            {//gather secret letter of selected tiles and compare with Distinct()
              tileString.Add(tile.Secret);
            }
            if (tileString.Distinct().Count() > 1)
            {//hide tiles if different letters showed
              Td__turntile(TileDialog.hideOrClose._hide);
            }
            else
            { //close tiles if all of them match
              currentMatches++;
              timer.Enabled = true;//enable timer for a delayed close

            }
          }
        }
      }
    }
    private void Timer_Tick(object sender, EventArgs e)
    { //delay tiles disappearing on successful match
      Td__turntile(TileDialog.hideOrClose._close);
      timer.Enabled = false;
    }
    /// <summary>
    /// Send order to either hide or close selected tiles
    /// </summary>
    /// <param name="hoc"></param>
    private void Td__turntile(TileDialog.hideOrClose hoc)
    {
      foreach (TileDialog td in selectedTiles)
      {
        td.TileTurnHandler(hoc);
        td._turntile -= Td__turntile;//unbind from this event
      }
      selectedTiles.Clear();//clear tiles from selection
      
    }
    /// <summary>
    /// Checks game state at end of turn. Displays victory message in main form bar or allows clicks to continue
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void TurnCompleteCallback(object sender, EventArgs e)
    {
      if(currentMatches == tileSetCount)
      {
        Text = $"You Win in {clicks} clicks!"; //game over
      }
      else
      {
        foreach (TileDialog tileD in gameTiles)
        {
          tileD.endingTurn = 0; //allows click/guess event to fire
        }
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
      if (tmpTileSet < 2)//minimum 2 sets for a game
        tmpTileSet = 2;
      _lblTileSets.Text = $"Tile Sets: {tmpTileSet}"; //update label
    }

    private void _lblTileSets_MouseDown(object sender, MouseEventArgs e)
    {
      _lblTileSets.Capture = true; //enables mouse move and continues captures off the label
      captureYStart = e.Y; //saves y position of mouse
    }

    private void _lblMatchCount_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta > 0) //if mousewheel scrolled up, increase match count
        matchCount++;
      else if(matchCount>2) //decrease match count if wheel scrolls down, minimum 2 tiles per set
        matchCount--;
      _lblMatchCount.Text = $"Matches: {matchCount}"; //update label
    }
  }
}
