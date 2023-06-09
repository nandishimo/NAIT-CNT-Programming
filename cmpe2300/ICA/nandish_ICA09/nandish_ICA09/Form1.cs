﻿using GDIDrawer;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using static System.Diagnostics.Trace;

namespace nandish_ICA09
{
  public partial class Form1 : Form
  {
    const int totalShoppers = 200;
    const int minStuff = 5;
    const int maxStuff = 15;
    const int scale = 20;
    int cashiers = 1;
    int requiredShoppers = totalShoppers;
    List<ConcurrentQueue<Cart>> queues = new List<ConcurrentQueue<Cart>>();
    CDrawer drawer = null;
    int totalProducts = 0;
    Stopwatch sw = new Stopwatch();
    int sumThreadID = 0;

    public Form1()
    {
      InitializeComponent();
      Text = "ICA09 - Costco Cashier Simulation";
      _btn_Simulate.MouseWheel += _btn_Simulate_MouseWheel;
      _btn_Simulate.Text = $"Simulate [{cashiers}]";
      _lbl_Remaining.Text = "Items to be Processed";
      _btn_Simulate.Click += _btn_Simulate_Click;
      _timer.Interval = 20;
      _timer.Tick += _timer_Tick;
      FormClosed += Form1_FormClosed;
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (drawer != null)
        drawer.Close();
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
      //if drawer doesnt exists, nothing to do, return;
      if (drawer == null)
        return;
      //if there are shoppers remaining
      if (requiredShoppers > 0)
      { //brave implementation
        List<ConcurrentQueue<Cart>> orderedqueues = queues.OrderBy((queue) => queue.Sum((cart) => { return cart.maxProducts; })).ToList();
        if (orderedqueues.First().Sum((cart) => { return cart.maxProducts; }) <= drawer.ScaledWidth - maxStuff)
        {
          orderedqueues.First().Enqueue(new Cart(GetProducts()));
          requiredShoppers--;
        }
        /* 
        //not so brave implementation
        int[] qlengths = new int[queues.Count];
        int i = 0;
        foreach (ConcurrentQueue<Cart> queue in queues)
        { //get length of each queue)
          queue.Sum((cart) => { return cart.maxProducts; });
          qlengths[i] = 0;
          foreach (Cart c in queue)
          {
            qlengths[i] += c.maxProducts;
          }
          i++;
        }
        //put cart into shortest queue (if it fits)
        int j = Array.IndexOf(qlengths, qlengths.Min());
        if (qlengths[j] <= drawer.ScaledWidth - maxStuff)
        {
          queues[j].Enqueue(new Cart(GetProducts()));
          requiredShoppers--;
        };
        */
      }
      //show all carts
      drawer.Clear();
      foreach (ConcurrentQueue<Cart> queue in queues)
      {
        int qlength = 0;
        lock (queues)
        {
          foreach (Cart cart in queue)
          {
            if (cart == null) continue;
            cart.ShowCart(drawer, queues.IndexOf(queue), qlength, 1);
            qlength += cart.maxProducts;
          }
        }
      }
      Text = $"Items Processed : {totalProducts}";
      _lbl_Remaining.Text = $"{requiredShoppers} carts remaining";
      if (requiredShoppers == 0)
      {
        foreach (ConcurrentQueue<Cart> queue in queues)
        {
          queue.Enqueue(null);
        }
      }
      if (sumThreadID == 0)
      {
        drawer.Close();
        Text = $"{totalProducts} items processed in {sw.Elapsed.TotalSeconds:F2} seconds";
        _timer.Stop();
      }
    }

    private void _btn_Simulate_Click(object sender, EventArgs e)
    {
      foreach (ConcurrentQueue<Cart> queue in queues) //for each queue in list
      {
          while (queue.TryDequeue(out Cart cart)) ; //empty out queue
          queue.Enqueue(null); //inject a null to terminate thread
      }
      while (sumThreadID > 0)
        Thread.Sleep(10); //wait for threads to terminate
      queues.Clear(); //clear queues from list
      totalProducts = 0; //reset total products stat
      sw.Restart();
      if (drawer != null)
        drawer.Close();
      drawer = new CDrawer(1500, cashiers * scale);
      drawer.Scale = scale;
      drawer.Position = new Point(Location.X, Location.Y + Height);
      requiredShoppers = totalShoppers;
      for (int i = 0; i < cashiers; i++)
      {
        queues.Add(new ConcurrentQueue<Cart>());
        Thread newThread = new Thread(Cashier);
        newThread.IsBackground = true;
        newThread.Start(queues.Last());
      }
      _timer.Start();
    }

    private void _btn_Simulate_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta > 0)
      {
        cashiers++;
        if (cashiers > 25)
        {
          cashiers = 25;
        }
      }
      if (e.Delta < 0)
      {
        cashiers--;
        if (cashiers < 1)
        {
          cashiers = 1;
        }
      }
      _btn_Simulate.Text = $"Simulate [{cashiers}]";
    }


    string GetProducts()
    {
      string val = "";
      int length = Cart.Next(minStuff, maxStuff);
      for (int i = 0; i < length; i++)
      {
        val += (char)('A' + Cart.Next(0, 26));
      }
      return val;
    }
    void Cashier(object obj)
    {
      if (obj == null) //sanity nul check
        return;
      if (!(obj is ConcurrentQueue<Cart> queue)) //check if obj is valid queue
      {
        throw new ArgumentException($"{nameof(obj)} is not a valid queue");
      }
      Interlocked.Add(ref sumThreadID, Thread.CurrentThread.ManagedThreadId);
      //add threadID to sum
      int sum = 0; //cart product sum
      while (true)
      {
        Thread.Sleep(Cart.Next(200, 400));
        if (queue.IsEmpty)//see if cart is available, if not go back to start of loop
          continue;
        queue.TryPeek(out Cart cart); //get the next cart
        if (cart == null) //if null, queue is done, exit loop, thread can close
          break;
        ; //process cart item
        sum += cart.Process(); // add to products sum
        if (cart.Done) //if cart is done, remove cart from queue and add cart sum to total
        {
          queue.TryDequeue(out Cart result);
          Interlocked.Add(ref totalProducts, sum);
          sum = 0;
        }
      }
      Interlocked.Add(ref sumThreadID, -1 * Thread.CurrentThread.ManagedThreadId);
      WriteLine($"Thread [{Thread.CurrentThread.ManagedThreadId}] done : ThreadID Sum : {sumThreadID}");
      return;
    }
  }
}
