using System;

namespace Exercise04_DB
{
  public class DbCommand
  {
    public DbConnection DbConnection { get; set; }

    public DbCommand(DbConnection dbConnection)
    {
      if (dbConnection == null)
        throw new InvalidOperationException("DB can't be null");

      DbConnection = dbConnection;
    }

    public void Execute()
    {
      DbConnection.Open();
      DbConnection.Run();
      DbConnection.Close();
    }
  }
}
