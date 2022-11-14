using GDIDrawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA09
{
  internal class Cart
  {
    private static Random _rand = new Random();
    //only access Random object through this method to ensure thread-safe retrievals
    public static int Next(int min, int max)
    {
      lock (_rand)
      {
        return _rand.Next(min, max);
      }
    }
    public int maxProducts { get; }//max products loaded into cart
    public Stack<char> _products { get;  private set; }//holds all products in cart
    public Color _color { get; private set;}//cart color
    public bool Done //return true if stack is empty
    {
      get
      {
        bool value = false;
        if (_products.Count == 0)
          value = true;
        return value;
      }
    }
    
    /// <summary>
    /// pops next product off stack. returns 0 if no pop
    /// </summary>
    /// <returns></returns>
    public char Process()
    {
      char value = (char)0;
      if(_products.Count != 0)
      {
        value = _products.Pop();
      }
      return value;
    }
    public Cart(string stuff)
    {
      _products = new Stack<char>(stuff.ToArray());
      _color = RandColor.GetColor();
      maxProducts = _products.Count;
    }
    public override string ToString()
    {
      string value="";
      foreach(char c in _products)
      {
        value += c;
      }
      return value;
    }
    public void ShowCart(CDrawer drawer, int row, int position, int rowHeight)
    {
      Rectangle cart = new Rectangle(position, row * rowHeight, maxProducts, rowHeight);
      drawer.AddRectangle(cart,_color,1,Color.White);
      if (position == 0)
      {
        drawer.AddText(ToString(), 10, cart, Color.Black);
      }
    }

  }
}
