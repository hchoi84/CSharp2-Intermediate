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
        Console.WriteLine("Object {0} has been added", obj.ToString());
      }
    }

    public void Pop()
    {
      if (List.Count == 0)
        throw new InvalidOperationException("Nothing to pop. Stack is empty");

      object obj = List[List.Count - 1];
      List.RemoveAt(List.Count - 1);
      Console.WriteLine("Object {0} has been removed", obj.ToString());
    }

    public void Clear()
    {
      if (List.Count == 0)
        throw new InvalidOperationException("Nothing to clear. Stack is empty");
      else
      {
        List.Clear();
        Console.WriteLine("Stack has been cleared");
      }
    }

    public int GetStackCount()
    {
      return List.Count;
    }
  }
}
