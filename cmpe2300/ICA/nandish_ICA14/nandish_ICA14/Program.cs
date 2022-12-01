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

      Gate[] gates = { new NandGate(), new OrGate(), new XorGate(), new AndGate() };
      for (int i = 0; i < gates.Length; i++)
      {
        Console.WriteLine(ToTable(gates[i]));
      }


      Gate[] _gates = { new AndGate(), new OrGate(), new NandGate(), new XorGate(), new NandGate(),
                           new OrGate(), new AndGate(), new XorGate(), new AndGate(), new OrGate() };

      Console.WriteLine(ToCircuit(_gates));
    }


    private static string ToTable(Gate g)
    {
      StringBuilder s = new StringBuilder();
      s.AppendLine($"A  B  {g.Name}");
      s.AppendLine($"-----------");
      for (int i = 0; i < 2; i++)
      {
        for (int j = 0; j < 2; j++)
        {
          g.Set(i, j);
          g.Latch();
          s.AppendLine($"{i}  {j}  {(g.OUT ? 1 : 0)}");
        }
      }

      return s.ToString();
    }


    private static string ToCircuit(Gate[] _gates)
    {
      StringBuilder s = new StringBuilder();
      s.AppendLine($"A  B  C  D  Z");
      s.AppendLine($"--------------");
      for (int a = 0; a < 2; a++)
      {
        for (int b = 0; b < 2; b++)
        {
          for (int c = 0; c < 2; c++)
          {
            for (int d = 0; d < 2; d++)
            {
              _gates[0].Set(a, a);
              _gates[0].Latch();
              _gates[1].Set(a, b);
              _gates[1].Latch();
              _gates[2].Set(b, c);
              _gates[2].Latch();
              _gates[3].Set(_gates[2].OUT, c != 0);
              _gates[3].Latch();
              _gates[4].Set(_gates[0].OUT, _gates[1].OUT);
              _gates[4].Latch();
              _gates[5].Set(_gates[0].OUT, _gates[4].OUT);
              _gates[5].Latch();
              _gates[6].Set(_gates[1].OUT, _gates[3].OUT);
              _gates[6].Latch();
              _gates[7].Set(_gates[3].OUT, d != 0);
              _gates[7].Latch();
              _gates[8].Set(_gates[5].OUT, _gates[6].OUT);
              _gates[8].Latch();
              _gates[9].Set(_gates[8].OUT, _gates[7].OUT);
              _gates[9].Latch();
              s.AppendLine($"{a}  {b}  {c}  {d}  {(_gates[9].OUT ? 1 : 0)}");
            }
          }
        }
      }
      return s.ToString();
    }

  }
}
