using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet {
  public class Book {
    public string title = "";
    public string author = "";
    public int pages = 0;

    public Book(string title, string author, int pages) {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }
  }

}