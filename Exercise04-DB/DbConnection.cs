using System;
using System.Threading;

namespace Exercise04_DB
{
  public abstract class DbConnection
  {
    public string ConnectionString { get; private set; }
    public TimeSpan Timeout { get; private set; }

    public DbConnection (string connectionString, TimeSpan timeout)
    {
      if (String.IsNullOrEmpty(connectionString))
        throw new InvalidOperationException("Connection String is either invalid or null");

      ConnectionString = connectionString;
      Timeout = timeout;
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
