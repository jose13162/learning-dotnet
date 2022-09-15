using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet {
  public class Exam {
    public string student = "";
    public string subject = "";
    private int score = 0;

    public Exam(string student, string subject, int score) {
      this.student = student;
      this.subject = subject;
      this.Score = score;
    }

    public int Score {
      get {
        return this.score;
      }
      set {
        if (value >= 0 & value <= 100) {
            this.score = value;
        }
      }
    }
  }
}