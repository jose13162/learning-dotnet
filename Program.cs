using System;

namespace dotnet {
  class Program {
    static void Main() {
      Song holiday = new Song("Holiday", "Green Day", 200);
      Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

      Console.WriteLine(Song.songCount);
    }
  }
}