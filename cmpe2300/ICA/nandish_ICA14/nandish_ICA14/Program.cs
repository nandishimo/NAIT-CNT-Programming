using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace nandish_ICA14
{
  internal class Program
  {

    static void Main(string[] args)
    {
      /*
      Gate[] _gates = { new NandGate(), new OrGate(), new XorGate(), new AndGate() };
      for (int i=0; i<_gates.Length; i++)
      {
        Console.WriteLine(ToTable(_gates[i]));
      }
      */
      Gate[] _gates = { new AndGate(), new OrGate(), new NandGate(), new XorGate(), new NandGate(),
                           new OrGate(), new AndGate(), new XorGate(), new AndGate(), new OrGate() };




    }
    private static string ToTable(Gate g)
    {
      StringBuilder s = new StringBuilder();
      s.AppendLine($"A\tB\t{g.Name}");
      for(int i=0;i<2;i++)
      {
        for(int j=0; j<2; j++)
        {
          g.Set(i, j);
          g.Latch();
          s.AppendLine($"{i}\t{j}\t{g.OUT}");
        }
      }

      return s.ToString();
    }
  }
}
