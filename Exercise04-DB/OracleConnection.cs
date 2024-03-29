using System;
using System.Threading;

namespace Exercise04_DB
{
  public class OracleConnection : DbConnection
  {
    public OracleConnection(string connectionString) : base(connectionString, new TimeSpan(0, 5, 0)) 
    { 
    }
    
    public override void Open()
    {
      Console.WriteLine("Connecting to Oracle...");
      Thread.Sleep(1000);
      Console.WriteLine("Connected to Oracle");
    }

    public override void Close()
    {
      Console.WriteLine($"Connection to Oracle will automatically close in {this.Timeout}");
    }
  }
}
