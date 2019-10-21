using System;
using System.Threading;

namespace Exercise01
{
  class Program
  {
    static void Main(string[] args)
    {
      StopWatch sw = new StopWatch();

      sw.Started = DateTime.Now;
      Console.WriteLine("Time watch started at: {0}", sw.Started.ToString("HH:mm:ss.fffffff"));

      sw.Stopped = DateTime.Now;
      Console.WriteLine("Time watch stopped at: {0}", sw.Stopped.ToString("HH:mm:ss.fffffff"));

      Console.WriteLine("Duration: {0}", sw.Duration.ToString());

      Console.WriteLine();

      Thread.Sleep(3000);
      sw.Started = DateTime.Now;
      Console.WriteLine("Time watch started at: {0}", sw.Started.ToString("HH:mm:ss.fffffff"));

      Thread.Sleep(3000);
      sw.Stopped = DateTime.Now;
      Console.WriteLine("Time watch stopped at: {0}", sw.Stopped.ToString("HH:mm:ss:fffffff"));

      Console.WriteLine(@"Duration: {0:ss\.fffffff}", sw.Duration);
      // For TimeSpan, the string format specifier is slightly different. It utilizes literals and escape characters
    }
  }
}
