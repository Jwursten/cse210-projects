// See https://aka.ms/new-console-template for more information
Console.WriteLine("Library Test");


Book book = new Book("The Hobbit", "978111111111", "2345612");

book.ShowBookDetails();

book.Display();
book.CheckOut();
book.Display();
book.CheckIn();
book.Display();

Console.WriteLine();

DVD dvd1 = new DVD("John Wick", "78945978459", "Action");

dvd1.ShowDVDDetails();
dvd1.Display();
dvd1.CheckOut();
dvd1.Display();
dvd1.CheckIn();
dvd1.Display();