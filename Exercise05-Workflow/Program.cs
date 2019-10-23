using System;
using System.Collections.Generic;

namespace Exercise05_Workflow
{
  class Program
  {
    static void Main(string[] args)
    {
      var Units = new List<ITrainUnit>();

      Units.Add(new Paladin());
      Units.Add(new Archer());
      Units.Add(new Sorcerror());

      foreach (var unit in Units)
      {
        Console.WriteLine("====================");
        unit.Execute();
      }
    }
  }
}
