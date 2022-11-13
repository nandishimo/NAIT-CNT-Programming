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

namespace nandish_ICA09
{
  public partial class Form1 : Form
  {
    Timer timer = new Timer();
    const int totalShoppers = 200;
    const int minStuff = 5;
    const int maxStuff = 15;
    const int scale = 20;
    int cashiers = 1;
    List<ConcurrentQueue<Cart>> queues = new List<ConcurrentQueue<Cart>>();
    CDrawer drawer = null;
    int totalProducts;
    Stopwatch sw = new Stopwatch();
    int sumThreadID;
    
    public Form1()
    {
      InitializeComponent();
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
      if(!(obj is ConcurrentQueue<Cart> queue))
      {
        throw new ArgumentException($"{nameof(obj)} is not a valid queue");
      }
      if(queue.Count != 0)
      {
        int sum = 0;
        while (queue.TryPeek(out Cart cart))
        {
          Thread.Sleep(Cart.Next(200, 400));
          cart.Process();

        }
      }

      
      

    }
  }
}
