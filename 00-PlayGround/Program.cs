using System;
using System.Collections.Generic;

namespace _00_PlayGround
{
  class Program
  {
    static void Main(string[] args)
    {
      HttpCookie hc = new HttpCookie();
      hc["me"] = "Howard";
    }
  }

  class HttpCookie
  {
    public Dictionary<string, string> _dictionary { get; set; }

    public string this[string key]
    {
      get { return _dictionary[key]; }
      set { _dictionary[key] = value; }
    }
  }
}
