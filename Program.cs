using System;

namespace dotnet {
  class Program {
    static void Main() {
      Knight knight = new Knight();
      Game<Knight> game = new Game<Knight>(knight);

      game.warrior.Attack();
    }
  }

  public interface IWarrior {
    void Attack();
  }

  public class Knight : IWarrior {
    public void Attack() {
      Console.WriteLine("Knight attacks");
    }
  }

  public class Game<T> where T : IWarrior {
    public T warrior;

    public Game(T warrior) {
      this.warrior = warrior;
    }
  }
}