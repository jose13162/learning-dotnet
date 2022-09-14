﻿using System;

namespace classes_and_objects {
  class Program {
    static void Main() {
      Book book1 = new Book();
      book1.title = "Harry Potter";
      book1.author = "JK Rowling";
      book1.pages = 400;

      Book book2 = new Book();
      book2.title = "Lord Of the Rings";
      book2.author = "Tolkein";
      book2.pages = 700;

      Console.WriteLine(book1.title);
      Console.WriteLine(book2.author);
    }
  }
}