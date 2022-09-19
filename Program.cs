using System;

namespace dotnet {
  class Program {
    static void Main() {
      Database database = new Database();

      Thread thread1 = new Thread(database.Query);
      thread1.Name = "Thread 1";
      Thread thread2 = new Thread(database.Query);
      thread2.Name = "Thread 2";
      Thread thread3 = new Thread(database.Query);
      thread3.Name = "Thread 3";
      Thread thread4 = new Thread(database.Query);
      thread4.Name = "Thread 4";

      thread1.Start();
      thread2.Start();
      thread3.Start();
      thread4.Start();
    }
  }
}