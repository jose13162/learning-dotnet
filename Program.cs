using System;

namespace Dotnet {
  class Program {
    static void Main() {
      Exam exam = new Exam("John", "ASP.NET", 98);
      exam.Score = 132;

      Console.WriteLine(exam.Score);
    }
  }
}