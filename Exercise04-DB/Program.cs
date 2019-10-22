using System;

namespace Exercise04_DB
{
  class Program
  {
    static void Main(string[] args)
    {
      DbCommand dbCmd = new DbCommand(new OracleConnection("Connection String"));
      dbCmd.Execute();
    }
  }
}
