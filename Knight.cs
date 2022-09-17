using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet {
  public class Knight : Warrior {
    public Knight(int healthPoints, int strength) : base(healthPoints, strength) { }

    public void Walk() {
      Console.WriteLine("Walking");
    }

    public void Run() {
      Console.WriteLine("Running");
    }

    public void Defend() {
      Console.WriteLine("Defending");
    }

    public void Heal() {
      Console.WriteLine("Healing");
    }

    public void Stab() {
      Console.WriteLine("Stabbing");
    }
  }
}