using System;
using System.Collections.Generic;

namespace Exercise04_DB
{
  class Program
  {
    static void Main(string[] args)
    {
      List<DbConnection> dataBases = new List<DbConnection>();

      dataBases.Add(new SqlConnection("SQL Connection String"));
      dataBases.Add(new OracleConnection("Oracle Connection String"));

      for (int i = 0; i < dataBases.Count; i++)
      {
        DbCommand dbCmd = new DbCommand(dataBases[i]);
        dbCmd.Execute();
        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine();

        if (i != dataBases.Count - 1)
          Console.WriteLine("Connecting to next database");
      }
    }
  }
}
