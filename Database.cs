using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet {
  public class Database {
    public Object locker = new Object();
    public void Query() {
      lock (locker) {
        Console.WriteLine("Making a query on the database: {0}", Thread.CurrentThread.Name);
      }
    }
  }
}