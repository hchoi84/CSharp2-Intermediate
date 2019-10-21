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
          Console.WriteLine("Time watch started at: {0:mm:ss.fffffff}", sw.Started);
        }
        else if (input == stopCmd)
        {
          sw.Stopped = DateTime.Now;
          Console.WriteLine("Time watch stopped at: {0:mm:ss.fffffff}", sw.Stopped);

          Console.WriteLine(@"Duration: {0:mm\:ss\.fffffff}", sw.Duration);
          Console.WriteLine();
        }
        else if (input == quitCmd)
          break;
        else
        {
          Console.WriteLine("Invalid command");
          Console.WriteLine($"Instruction: \"{startCmd}\", \"{stopCmd}\", \"{quitCmd}\"");
          Console.WriteLine();
        }
      }

      // For TimeSpan, the string format specifier is slightly different. It utilizes literals and escape characters
    }
  }
}
