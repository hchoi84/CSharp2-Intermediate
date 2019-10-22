using System;
using System.Threading;

namespace Exercise04_DB
{
  public abstract class DbConnection
  {
    public string ConnectionString { get; private set; }
    public TimeSpan Timeout { get; set; }

    public DbConnection (string connectionString)
    {
      if (String.IsNullOrEmpty(connectionString))
        throw new InvalidOperationException("Connection String is either invalid or null");

      ConnectionString = connectionString;
    }

    public abstract void Open();
    public abstract void Close();

    public void Run()
    {
      Console.WriteLine("Processing...");
      Thread.Sleep(2000);
      Console.WriteLine("Processing done");
    }
  }
}
