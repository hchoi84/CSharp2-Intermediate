using System;
using System.Threading;

namespace Exercise04_DB
{
  public class OracleConnection : DbConnection
  {
    public OracleConnection(string connectionString) : base(connectionString) { }
    
    public override void Open()
    {
      Console.WriteLine("Connecting to Oracle...");
      Thread.Sleep(1000);
      Console.WriteLine("Connected to Oracle");
    }

    public override void Close()
    {
      Console.WriteLine("Connection to Oracle has closed");
    }
  }
}
