using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA14
{
  abstract class Gate
  {
    protected bool _IN1 { get { return _IN1; } set { _IN1 = value; } }
    protected bool _IN2 { get { return _IN1; } set { _IN2 = value; } }
    protected bool _OUT { get { return _OUT; } set { _OUT = value; } }
    public void Set(int A, int B)
    {
      _IN1 = A != 0;
      _IN2 = B != 0;
    }
    public void Set(bool A, bool B)
    {
      _IN1 = A;
      _IN2 = B;
    }
    protected abstract void Latch();
    protected abstract string Name { get; }

  }
  class NandGate : Gate
  {
    protected override void Latch()
    {
      _OUT = !(_IN1 && _IN2);
    }
    protected override string Name { get { return "NAND"; } }
  }
  class OrGate : Gate
  {
    protected override void Latch()
    {
      _OUT = _IN1 || _IN2;
    }
    protected override string Name { get { return "OR"; } }
  }
  class XorGate : Gate
  {
    protected override void Latch()
    {
      _OUT = (_IN1 && !_IN2) || (_IN2 && !_IN1);
    }
    protected override string Name { get { return "XOR"; } }
  }
  class AndGate : NandGate
  {
    protected override void Latch()
    {
      
    }
    protected override string Name { get { return "AND"; } }
  }

}

