using System;

namespace Exercise03_Stack
{
  class Program
  {
    static void Main(string[] args)
    {
      var stack = new Stack();
      
      for (var i = 1; i < 4; i++)
      {
        stack.Push(i);
      }

      stack.Clear();
      
      for (var i = 1; i < 4; i++)
      {
        Console.WriteLine(stack.Pop());
      }

    }
  }
}
