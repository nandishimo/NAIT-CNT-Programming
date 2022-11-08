using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Numerics;

namespace nandish_Lab02
{
  internal class Table
  {
    public CDrawer drawer { private set; get; } = null;
    private List<Ball> balls = new List<Ball>();
    private Vector2 mousePos = new Vector2();
    private Ball cueBall = null;
    public List<Ball> copyBalls { get { return new List<Ball>(balls); } }
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
    public Table()
    {

    }

    public void MakeTable(int width, int height, int numBalls)
    {
      if (drawer != null)
        drawer.Close();
      drawer = new CDrawer(width, height, false, true);
      drawer.MouseMoveScaled += Drawer_MouseMoveScaled;
      drawer.MouseLeftClickScaled += Drawer_MouseLeftClickScaled;
      
    }
    public void ShowTable()
    {
      if (drawer == null)
        return;
      foreach(Ball ball in balls)
      {

      }
    }

    private void Drawer_MouseLeftClickScaled(System.Drawing.Point pos, CDrawer dr)
    {
      throw new NotImplementedException();
    }

    private void Drawer_MouseMoveScaled(System.Drawing.Point pos, CDrawer dr)
    {
      throw new NotImplementedException();
    }
  }
}
