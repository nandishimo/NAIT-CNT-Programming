using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace nandish_Lab02
{
  internal class Ball
  {
    //public static float for friction, default 0.991f
    public static float Friction = 0.991f;
    //static Random object initialized
    private static Random _rand = new Random();
    //Vector2 member for ball center
    private Vector2 _center;
    //vector2 member for ball velocity
    private Vector2 _velocity;
    //public property for ball center get only
    public Vector2 Center { get { return _center; } }
    //public property for ball velocity get only
    public Vector2 Velocity { get { return _velocity; } }
    //property int Radius public get, private set
    public int Radius { get;private set; }
    //property int Hits public get, private set
    public int Hits { get; private set; }
    //property int totalhits public get, private set
    public int TotalHits { get; private set; }
    //property for ball color public get, private set
    public Color BallColor { get; private set; }
  }
}
