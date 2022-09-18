using System;
using System.Collections.Generic;

namespace dotnet {
  class Program {
    static void Main() {
      List<int> list = new List<int>();
      int[] numbers = { 5, 6, 2, 4, 8, 1, 9, 3, 7, 10 };

      list.AddRange(numbers);
      Console.WriteLine(list.TrueForAll(LessThanTen));
    }

    static bool LessThanTen(int number) {
      return number < 10;
    }
  }
}