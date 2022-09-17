using System;

namespace dotnet {
  class Program {
    static void Main() {
      MediumShip mediumShip = new MediumShip();
      MediumShip otherMediumShip = new MediumShip();

      Console.WriteLine(otherMediumShip.CurrentHealthPoints);

      mediumShip.LaunchMissiles(otherMediumShip);

      Console.WriteLine(otherMediumShip.CurrentHealthPoints);

      otherMediumShip.Fix();

      Console.WriteLine(otherMediumShip.CurrentHealthPoints);
    }
  }
}