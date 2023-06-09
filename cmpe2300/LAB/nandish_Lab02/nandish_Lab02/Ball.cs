﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using GDIDrawer;

namespace nandish_Lab02
{
  internal class Ball:IComparable
  {
    //public static float for friction, default 0.991f
    public static float Friction = 0.991f;
    //static Random object initialized
    private static Random _rand = new Random();
    //Vector2 member for ball center
    private Vector2 _center;
    //vector2 member for ball _velocity
    private Vector2 _velocity;
    //public property for ball center get only
    public Vector2 Center { get { return _center; } }
    //public property for ball _velocity get only
    public Vector2 Velocity { get { return _velocity; } }
    //property int Radius public get, private set
    public int Radius { get;private set; }
    //property int Hits public get, private set
    public int Hits { get; private set; }
    //property int totalhits public get, private set
    public int TotalHits { get; private set; }
    //property for ball color public get, private set
    public Color BallColor { get; private set; }
    private Color CueColor { get; } = Color.White;


    /// <summary>
    /// 'regular' Ball contructor accepting a CDrawer and Color
    /// </summary>
    /// <param name="drawer">CDrawer representing pool table</param>
    /// <param name="color">Color of Ball</param>
    public Ball(CDrawer drawer, Color color)
    {
      BallColor = color;
      Radius = _rand.Next(20, 51);
      _center = new Vector2((float)(_rand.NextDouble() * (drawer.ScaledWidth - 2 * Radius) + Radius), (float)(_rand.NextDouble() * (drawer.ScaledHeight - 2 * Radius) + Radius));
    }

    /// <summary>
    /// Cue Ball constructor accepting a CDrawer
    /// </summary>
    /// <param name="drawer">CDrawer representing pool table</param>
    public Ball(CDrawer drawer)
    {
      Radius = 30;
      BallColor = CueColor;
      _center = new Vector2((float)(_rand.NextDouble() * (drawer.ScaledWidth - 2 * Radius) + Radius), (float)(_rand.NextDouble() * (drawer.ScaledHeight - 2 * Radius) + Radius));
    }
    /// <summary>
    /// Reset hit coutner to 0
    /// </summary>
    public void ResetHits()
    {
      Hits = 0;
    }
    /// <summary>
    /// Set Velocity of Ball
    /// </summary>
    /// <param name="vector"></param>
    public void Set_velocity(Vector2 vector)
    {
      _velocity = vector;
    }

    public override bool Equals(object obj)
    {
      //check if object is a valid ball or throw exception
      if (!(obj is Ball ball))
      {
        throw new ArgumentException($"Ball:Equals - {nameof(obj)} is not a ball");
      }
      //balls are 'Equal' if touching (i.e. sum of ball radius > distance between ball locations) z = sqrt((x1-x2)^2
      return (Radius + ball.Radius) > Math.Sqrt(Math.Pow(_center.X - ball._center.X, 2) + Math.Pow(_center.Y - ball._center.Y, 2));
    }
    public override int GetHashCode()
    {
      return 1;
    }
    public override string ToString()
    { //string to display on ball
      return $"{Radius} : {Hits}";
    }
    /// <summary>
    /// Default Compare method to sort by Radius descending
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>Signed value indicating relative value of Radius. Negative if argument is Larger than Ball. Positive if argument is smaller</returns>
    /// <exception cref="ArgumentException"></exception>
    public int CompareTo(object obj)
    { 
      if (!(obj is Ball ball))
      {
        //throw if obj is not a valid ball
        throw new ArgumentException($"Ball:Equals - {nameof(obj)} is not a ball");
      }
      return -1*Radius.CompareTo(ball.Radius);
    }
    /// <summary>
    /// IComparable compatible method to sort by Hits descending
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns>Signed value indicating relative value of Hits. Negative if left arg is has more hits. Positive if right argument is has more hits</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static int SortDescHits(Ball left, Ball right)
    {
      if (left == null)
        throw new ArgumentNullException($"Ball : Sort by Hits desc : {nameof(left)} - is null");
      if (right == null)
        throw new ArgumentNullException($"Ball : Sort by Hits desc : {nameof(right)} - is null");
      return right.Hits.CompareTo(left.Hits);
    }
    /// <summary>
    /// IComparable compatible method to sort by Total Hits descending
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns>Signed value indicating relative value of Total Hits. Negative if left arg is has more hits. Positive if right argument is has more hits</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static int SortDescTotalHits(Ball left, Ball right)
    {
      if (left == null)
        throw new ArgumentNullException($"Ball : Sort by Total Hits desc : {nameof(left)} - is null");
      if (right == null)
        throw new ArgumentNullException($"Ball : Sort by Total Hits desc : {nameof(right)} - is null");
      return right.TotalHits.CompareTo(left.TotalHits);
    }
    /// <summary>
    /// Renders Ball to supplied CDrawer
    /// </summary>
    /// <param name="drawer">CDrawer representing the pool table</param>
    public void Show(CDrawer drawer)
    {
      if (BallColor == CueColor)
      {
        drawer.AddCenteredEllipse((int)_center.X, +(int)_center.Y, 2 * Radius, 2 * Radius, BallColor, 2, Color.Yellow);
      }
      else
      {
        drawer.AddCenteredEllipse((int)_center.X, +(int)_center.Y, 2 * Radius, 2 * Radius, BallColor);
      }
      drawer.AddText(ToString(), 10, (int)_center.X-Radius, (int)_center.Y-Radius, 2*Radius,2*Radius, Color.Black);
      
    }
    /// <summary>
    /// Accepts CDrawer and list of Balls. Adjusts velocty of balls based on friction. Checks CDrawer boundaries and bounces balls.
    /// Iterate through Ball collection and process collisions
    /// </summary>
    /// <param name="drawer">CDrawer representing the pool table</param>
    /// <param name="balls">List of Balls on pool table</param>
    public void Move(CDrawer drawer, List<Ball> balls)
    {
      //adjust velocity based on friction
      _velocity = Vector2.Multiply(Friction, _velocity);
      if (_velocity.LengthSquared() < 0.1f)
      {
        _velocity = Vector2.Zero;
        return;
      }
      // move the ball
      _center = Vector2.Add(_center, _velocity);

      //check boundary conditions
      //check left bound
      if (_center.X - Radius < 0)
      {
        _velocity.X *= -1;
        _center = new Vector2(Radius, _center.Y);
      }

      //check right bound
      if (_center.X + Radius > drawer.ScaledWidth)
      {
        _velocity.X *= -1;
        _center = new Vector2(drawer.ScaledWidth - Radius, _center.Y);
      }

      //check top bound
      if (_center.Y - Radius < 0)
      {
        _velocity.Y *= -1;
        _center = new Vector2(_center.X, Radius);
      }

      //check bottom bound
      if (_center.Y + Radius > drawer.ScaledHeight)
      {
        _velocity.Y *= -1;
        _center = new Vector2(_center.X, drawer.ScaledHeight - Radius);
      }
      
      //check for collisions
      foreach(Ball ball in balls)
      {
        if (!ReferenceEquals(this,ball))
        {
          if (this.Equals(ball))
          {
            ProcessCollision(ball);
          }
        }
      }
    }
    /// <summary>
    /// Supplied method to process collisions
    /// </summary>
    /// <param name="tar"></param>
    private void ProcessCollision(Ball tar)
    {
      Vector2 dist = tar._center - _center; // Get Collision Vector
      Vector2 myNorm = Vector2.Normalize(tar._center - _center); // Normalize for invoking ball
      Vector2 targetNorm = Vector2.Normalize(_center - tar._center); // Normalize for target ball

      // Calculate Radius weighted velocity vector
      //Vector2 CMVelocity = Vector2.Add(Vector2.Multiply((float)_iRadius / (_iRadius + tar._iRadius), _v), Vector2.Multiply((float)tar._iRadius / (_iRadius + tar._iRadius), tar._v));
      Vector2 CMVelocity = (_velocity * ((float)Radius / (Radius + tar.Radius)) + (tar._velocity * ((float)tar.Radius / (Radius + tar.Radius))));

      // Process invoking ball
      _velocity -= CMVelocity;// Vector2.Subtract(_v, CMVelocity);
      _velocity = Vector2.Reflect(_velocity, myNorm); // perform "bounce"
      _velocity += CMVelocity;// Vector2.Add(_v, CMVelocity);
      Hits++;
      TotalHits++;

      // Process target ball
      tar._velocity -= CMVelocity;
      tar._velocity = Vector2.Reflect(tar._velocity, targetNorm); // perform bounce
      tar._velocity += CMVelocity;// Vector2.Add(tar._v, CMVelocity);
      tar.Hits++;
      tar.TotalHits++;

      // "Fix" collision if balls overlapped - could apply weighted adjustment shift between both balls
      //       but here we just move the target ball over on collision vector so it doesn't overlap
      //tar._center = Vector2.Add(tar._center, Vector2.Multiply((float)((_iRadius + tar._iRadius - dist.Length()) / (_iRadius + tar._iRadius)), dist));
      tar._center += dist * (float)((Radius + tar.Radius - dist.Length()) / (Radius + tar.Radius));
    }
  }
}
