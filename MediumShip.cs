using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet {
  public class MediumShip : Ship {
    private int missilePower = 20;
    private int missileCount = 1;

    public int MissilePower {
      get {
        return this.missilePower;
      }
    }

    public int MissileCount {
      get {
        return this.missileCount;
      }
    }

    public MediumShip() : base(80, 10, 3, 8) { }

    public void LaunchMissiles(Ship target) {
      for (int i = 0; i < this.missileCount; i++) {
        target.TakeDamage(this.missilePower);
      }
    }

    public override void Fix() {
        Console.WriteLine("Fixing another way");
    }
  }
}