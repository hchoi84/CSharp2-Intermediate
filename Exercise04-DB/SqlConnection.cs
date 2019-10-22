using System;
using System.Threading;

namespace Exercise04_DB
{
  public class SqlConnection : DbConnection
  {
    public SqlConnection(string connectionString) : base(connectionString, new TimeSpan(0, 2, 0)) 
    {  
    }
    
    public override void Open()
    {
      Console.WriteLine("Connecting to SQL...");
      Thread.Sleep(1000);
      Console.WriteLine("Connected to SQL");
    }

    public override void Close()
    {
      Console.WriteLine($"Connection to SQL will automatically close in {this.Timeout}");
    }
  }
}
