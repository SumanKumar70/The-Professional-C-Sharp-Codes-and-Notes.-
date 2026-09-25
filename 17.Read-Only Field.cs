using System;

class Book
{
    
    public readonly string ISBN;

    
    public Book(string isbn)
    {
        ISBN = isbn;
    }
}

class Program
{
    static void Main(string[]args)
    {
      
        Book book = new Book("978-1234567890");

        
        Console.WriteLine("ISBN: " + book.ISBN);

        
    }
}
