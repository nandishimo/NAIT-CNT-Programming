using GDIDrawer;
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
    int totalProducts=0;
    Stopwatch sw = new Stopwatch();
    int sumThreadID=0;
    
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
      _timer.Start();
    }

    private void _timer_Tick(object sender, EventArgs e)
    {
      if (drawer == null)
        return;
      if(requiredShoppers>0)
      {
        foreach (ConcurrentQueue<Cart> queue in queues)
        {
          if (queue.Count < 6)
          {
            queue.Enqueue(new Cart(GetProducts()));
            requiredShoppers--;
            break;
          }
        }
      }
      foreach(ConcurrentQueue<Cart> queue in queues)
      {
        int i = 0;
        lock(queues)
        {
          foreach (Cart cart in queue)
          {
            cart.ShowCart(drawer, queues.IndexOf(queue), i, 1);
            i++;
          }
        }
      }
      Text = $"Items Processed : {totalProducts}";
      _lbl_Remaining.Text = $"{requiredShoppers} carts remaining";
      if(requiredShoppers == 0)
      {
        foreach(ConcurrentQueue<Cart> queue in queues)
        {
          queue.Enqueue(null);
        }
      }
      if(sumThreadID == 0)
      {
        drawer.Close();
        Text = $"{totalProducts} items process in {sw.Elapsed.TotalSeconds}.{sw.Elapsed.Milliseconds:F2} seconds";
      }
    }

    private void _btn_Simulate_Click(object sender, EventArgs e)
    {
      foreach(ConcurrentQueue<Cart> queue in queues) //for each queue in list
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
      drawer = new CDrawer(1500,cashiers*scale);
      drawer.Scale = scale;
      drawer.Position = new Point(Location.X, Location.Y + Height);
      requiredShoppers = totalShoppers;
      for(int i = 0; i < cashiers; i++)
      {
        queues.Add(new ConcurrentQueue<Cart>());
        Thread newThread = new Thread(Cashier);
        newThread.Start(queues.Last());
      }

    }

    private void _btn_Simulate_MouseWheel(object sender, MouseEventArgs e)
    {
      if (e.Delta > 0)
      {
        cashiers++;
        if(cashiers > 25)
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
      string val="";
      int length = Cart.Next(minStuff, maxStuff);
      for(int i = 0; i < length; i++)
      {
        val+=(char)('A' + Cart.Next(0,26));
      }
      return val;
    }
    void Cashier(object obj)
    {
      if (obj == null)
        return;
      if(!(obj is ConcurrentQueue<Cart> queue))
      {
        throw new ArgumentException($"{nameof(obj)} is not a valid queue");
      }
      if(queue.Count != 0)
      {
        int sum = 0;
        lock (queues)
        {
          sumThreadID += Thread.CurrentThread.ManagedThreadId;
        }
        
        while (true)
        {
          Thread.Sleep(Cart.Next(200, 400));
          if (queue.IsEmpty)
            continue;
          queue.TryPeek(out Cart cart);
          if (cart == null)
            break;
          if(cart.Done)
          {
            queue.TryDequeue(out Cart result);
            lock (queues)
            {
              totalProducts += sum;
            }
            sum = 0;
          }
        }
      }
      lock (queues)
      {
        sumThreadID -= Thread.CurrentThread.ManagedThreadId;
      }
      WriteLine($"Thread [{Thread.CurrentThread.ManagedThreadId}] done : ThreadID Sum : {sumThreadID}");
      return;
    }
  }
}
