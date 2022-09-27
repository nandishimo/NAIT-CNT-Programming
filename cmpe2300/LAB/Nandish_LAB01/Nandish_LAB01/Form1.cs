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
    Random rand = new Random();
    Timer timer = new Timer();
    List<Tile> gameTiles = null;
    List<Tile> selectedTiles = new List<Tile>();
    public delegate void TurnHandler();
    public event TurnHandler turnTile;
    int tileSetCount;
    int matchCount;
    int currentMatches;

    public Form1()
    {
      InitializeComponent();
      turnTile += Form1_turnTile;
    }

    private void Form1_turnTile()
    {
      throw new NotImplementedException();
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
