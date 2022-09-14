using System;

namespace Dotnet {
  class Program {
    static void Main() {
      Book book = new Book("Harry Potter", "JK Rowling", 400);
      Console.WriteLine(book.title);
      Console.WriteLine(book.author);
      Console.WriteLine(book.pages);
    }
  }
}