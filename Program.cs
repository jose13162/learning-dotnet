using System;

namespace dotnet {
  class Program {
    public static void Main() {
      var source = new CancellationTokenSource();
      var token = source.Token;
      source.Cancel();

      Task task = Task.Run(() => {
        if (token.IsCancellationRequested) {
          token.ThrowIfCancellationRequested();
        }

        Thread.Sleep(2000);
      }, token);

      try {
        task.Wait();
      } catch (Exception exception) {
        Console.WriteLine(exception.Message);
      }

      Console.WriteLine(task.Status);
      Console.WriteLine(task.IsCanceled);
    }
  }
}