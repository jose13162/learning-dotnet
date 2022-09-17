using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet {
  public static class Calculator {
    public static double Sum(double number1, double number2) {
      return number1 + number2;
    }

    public static double Subtract(double number1, double number2) {
      return number1 - number2;
    }

    public static double Multiply(double number1, double number2) {
      return number1 * number2;
    }

    public static double Divide(double number1, double number2) {
      return number1 / number2;
    }
  }
}