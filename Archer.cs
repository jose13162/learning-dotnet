using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet {
  public class Archer : Warrior {
    public Archer(int healthPoints, int strength) : base(healthPoints, strength) { }

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

    public void Shoot() {
      Console.WriteLine("Shooting");
    }
  }
}