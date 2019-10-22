using System;
using System.Collections.Generic;

namespace Exercise03_Stack
{
  class Stack
  {
    public readonly List<object> List = new List<object>();

    public void Push(object obj)
    {
      if (obj == null)
        throw new InvalidOperationException("Cannot assign null value");
      else if (obj.ToString() == "")
        throw new InvalidOperationException("Cannot assign empty value");
      else
      {
        List.Add(obj);
        Console.WriteLine("Object has been added");
      }
    }

    public object Pop()
    {
      if (List.Count == 0)
        throw new InvalidOperationException("Stack is currently empty");

      object value = List[List.Count - 1];
      List.RemoveAt(List.Count - 1);
      return value;
    }

    public void Clear()
    {
      if (List.Count == 0)
        Console.WriteLine("Stack is already empty");
      else
      {
        List.Clear();
        Console.WriteLine("Stack has been cleared");
      }
    }
  }
}
