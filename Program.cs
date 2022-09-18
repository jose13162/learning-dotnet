using System;
using System.IO;

namespace dotnet {
  class Program {
    static void Main() {
      string filePath = "assets/file.backup.txt";

      try {
        File.Delete(filePath);
      } catch (Exception exception) {
        Console.WriteLine(exception.Message);
      }
    }
  }
}