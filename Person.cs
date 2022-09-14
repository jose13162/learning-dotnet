using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet {
  public class Person {
    public string name = "";
    public int age = 0;

    public Person(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public void Introduce() {
      Console.WriteLine("Hi! I'm {0} and I'm {1} years old", this.name, this.age);
    }
  }
}