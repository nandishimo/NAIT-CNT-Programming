using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nandish_ICA14
{
  abstract class Gate
  {
    protected bool _IN1;
    public bool IN1 { get { return _IN1; } }
    protected bool _IN2;
    public bool IN2 { get { return _IN1; } }
    protected bool _OUT;
    public bool OUT { get { return _OUT; } }
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
    public abstract void Latch();

    public abstract string AName { get; }
    public string Name
    {
      get { return $"[{AName}]"; }
    }

  }
  class NandGate : Gate
  {
    public override void Latch()
    {
      _OUT = !(_IN1 && _IN2);
    }
    public override string AName { get; } = "NAND";
  }
  class OrGate : Gate
  {
    public override void Latch()
    {
      _OUT = _IN1 || _IN2;
    }
    public override string AName { get; } = "OR";
  }
  class XorGate : Gate
  {
    public override void Latch()
    {
      _OUT = (_IN1 && !_IN2) || (_IN2 && !_IN1);
    }
    public override string AName { get; } = "XOR";
  }
  class AndGate : NandGate
  {
    public override void Latch()
    {
      base.Latch();
      _OUT = !_OUT;
    }
    public override string AName { get; } = "AND";
  }
}