using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Numerics;
using System.Drawing;

namespace nandish_Lab02
{
  internal class Table
  {
    //public CDrawer private set, initialized to null
    public CDrawer drawer { private set; get; } = null;
    //list of balls on the table
    private List<Ball> balls = new List<Ball>();
    //vector2 for mouse location
    private Vector2 mousePos = new Vector2();
    //Ball member for cueball
    private Ball cueBall = null;
    //public list of ball, returns copy of member list
    public List<Ball> copyBalls { get { return new List<Ball>(balls); } }
    //public bool property, if any balls are moving (velocty>0), returns true
    public bool Running 
    { 
      get 
      { 
        bool value = false;
        foreach(Ball b in balls)
        {
          if (b.Velocity != Vector2.Zero)
            value = true;
        }
        return value;
      } 
    }
    public Table() //default constructor accepts no arguments
    {
      //do nothing
    }

    /// <summary>
    /// Accepts ints to define width and height of table. Also takes int representing number of balls requried.
    /// Returns nothing.
    /// </summary>
    /// <param name="width">Width of table</param>
    /// <param name="height">Height of table</param>
    /// <param name="numBalls">Number of balls to place on table</param>
    public void MakeTable(int width, int height, int numBalls)
    {
      if (drawer != null) //close existing drawer
        drawer.Close();
      drawer = new CDrawer(width, height, false, true); //create new drawer with continuous update = false and redundamouse = true
      drawer.MouseMoveScaled += Drawer_MouseMoveScaled; //bind mouse move event
      drawer.MouseLeftClickScaled += Drawer_MouseLeftClickScaled; //bind mosue click event
      MakeBalls(numBalls);
      ShowTable();
      
    }

    /// <summary>
    /// Accepts and returns nothing. Move and show all balls on table.
    /// </summary>
    public void ShowTable()
    {
      if (drawer == null) //check if drawer is initialized
        return;
      drawer.Clear(); //clear drawer
      foreach(Ball ball in balls) //iterate through collection and move/show all balls
      {
        ball.Move(drawer,balls);
        ball.Show(drawer);
      }
      if (!Running) //if balls have stopped moving, show line from cue ball to mouse cursor to aim next shot
      {
        drawer.AddLine((int)cueBall.Center.X, (int)cueBall.Center.Y, (int)mousePos.X, (int)mousePos.Y, Color.Yellow);
      }
      drawer.Render(); //render balls and shot line
    }

    /// <summary>
    /// Makes a defined number of regular Balls and an additional cue Ball.
    /// </summary>
    /// <param name="numBalls">Int representing number of regular balls to add</param>
    public void MakeBalls(int numBalls)
    {
      balls.Clear(); //clear collection
      Ball tmp;
      while (balls.Count < numBalls) //create specified number of balls. Only add to collection if balls dont overlap
      {
        tmp = new Ball(drawer, RandColor.GetColor());
        if (!balls.Contains(tmp))
        {
          balls.Add(tmp);
        }
      }
      tmp = new Ball(drawer);
      while (balls.Contains(tmp)) //attempt to create cueball that doesnt overlap
      {
        tmp = new Ball(drawer);
      }
      cueBall = tmp; //assign to cueball member
      balls.Add(tmp); //add cueball to collection
    }

    //Shoot cueball in specified direction with velocity proportional to length of shot vector
    private void Drawer_MouseLeftClickScaled(System.Drawing.Point pos, CDrawer dr)
    {
      if (Running) //dont hit cueball if simulation is running
        return;
      foreach(Ball ball in balls)
      {
        ball.ResetHits(); //reset hit count for all balls for each new shot
      }
      
      Vector2 shot = mousePos - cueBall.Center;
      float length = shot.Length();
      //shot = Vector2.Normalize(shot)*40f;
      //ENHANCEMENT set veolcity to length of vector divided by 15
      shot = Vector2.Normalize(shot) * length/15;
      cueBall.Set_velocity(shot);
    }

    private void Drawer_MouseMoveScaled(System.Drawing.Point pos, CDrawer dr)
    {
      //track mouse position and invoke ShowTable to update shot line vector
      mousePos = new Vector2(pos.X, pos.Y);
      if (!Running)
      {
        ShowTable();
      }
    }
  }
}
