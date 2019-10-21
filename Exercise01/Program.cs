using System;

namespace Exercise01
{
  class Program
  {
    static void Main(string[] args)
    {
      StopWatch sw = new StopWatch();
      Random rand = new Random();
      string startCmd = "1";
      string stopCmd = "2";
      string quitCmd = "q";

      Console.Beep();
      Console.WriteLine($"Instruction: \"{startCmd}\", \"{stopCmd}\", \"{quitCmd}\"");
      while (true)
      {
        string input = Console.ReadLine();

        if (input == startCmd)
        {
          sw.Started = DateTime.Now;
          Console.WriteLine("Time watch started at: {0}", sw.Started.ToString("HH:mm:ss.fffffff"));
        }

        if (input == stopCmd)
        {
          sw.Stopped = DateTime.Now;
          Console.WriteLine("Time watch stopped at: {0}", sw.Stopped.ToString("HH:mm:ss.fffffff"));

          Console.WriteLine("Duration: {0}", sw.Duration.ToString());
          Console.WriteLine();
        }

        if (input == quitCmd)
          break;
      }

      // For TimeSpan, the string format specifier is slightly different. It utilizes literals and escape characters
    }
  }
}
