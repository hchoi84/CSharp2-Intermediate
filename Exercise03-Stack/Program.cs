using System;

namespace Exercise03_Stack
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack stack = new Stack();
      int stackStartIdx = 0;
      int stackCount = 4;
      
      for (var i = stackStartIdx; i < stackCount; i++)
      {
        stack.Push(i);
      }
      
      for (var i = stack.GetStackCount(); i >= 0; i--)
      {
        stack.Pop();
      }

      stack.Clear();
    }
  }
}
