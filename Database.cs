using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet {
  public class Database {
    public int Query() {
      int random = new Random().Next(500, 2000);
      Thread.Sleep(random);

      return random;
    }
  }
}