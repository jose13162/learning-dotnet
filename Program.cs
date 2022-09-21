using System;
using System.Diagnostics;

namespace dotnet {
  class Program {
    public static async Task Main() {
      Database database = new Database();
      Stopwatch stopwatch = new Stopwatch();
      
      stopwatch.Start();

      int number = await Task.Run(() => {
        int data = database.Query();

        return data;
      });
      
      stopwatch.Stop();

      Console.WriteLine(stopwatch.ElapsedMilliseconds);
      Console.WriteLine(number);
    }
  }
}