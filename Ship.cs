using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet {
  public class Ship {
    private int healthPoints;
    private int currentHealthPoints;
    private int power;
    private int turretCount;
    private int fixPoints;

    public int HealthPoints {
      get {
        return this.healthPoints;
      }
    }

    public int CurrentHealthPoints {
      get {
        return this.currentHealthPoints;
      }
    }

    public int Power {
      get {
        return this.power;
      }
    }

    public int TurretCount {
      get {
        return this.turretCount;
      }
    }

    public int FixPoints {
      get {
        return this.fixPoints;
      }
    }

    public Ship(int healthPoints, int power, int turretCount, int fixPoints) {
      this.healthPoints = healthPoints;
      this.currentHealthPoints = healthPoints;
      this.power = power;
      this.turretCount = turretCount;
      this.fixPoints = fixPoints;
    }

    public void Attack(Ship target) {
      for (int i = 0; i < this.turretCount; i++) {
        target.TakeDamage(this.power);
      }
    }

    public void TakeDamage(int damage) {
      if (damage > this.currentHealthPoints) {
        this.currentHealthPoints = 0;
      } else {
        this.currentHealthPoints -= damage;
      }
    }

    public virtual void Fix() {
      if (this.currentHealthPoints + this.fixPoints > this.healthPoints) {
        this.currentHealthPoints = this.healthPoints;
      } else {
        this.currentHealthPoints += this.fixPoints;
      }
    }
  }
}