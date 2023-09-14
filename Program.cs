using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Book
{
    public string Title { get; }
    public string Author { get; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Bookshelf
{
    private List<Book> books = new List<Book>();
    public Book this[string title]
    {
        get
        {
            foreach (var book in books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }
}

class Program
{
    static void Main()
    {
        Bookshelf bookshelf = new Bookshelf();

        bookshelf.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
        bookshelf.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
        bookshelf.AddBook(new Book("1984", "George Orwell"));

        Book book1 = bookshelf["The Great Gatsby"];
        Book book2 = bookshelf["To Kill a Mockingbird"];
        Book book3 = bookshelf["Nonexistent Book"];

        if (book1 != null)
        {
            Console.WriteLine($"Book 1: {book1.Title} by {book1.Author}");
        }
        else
        {
            Console.WriteLine("Book 1 not found.");
        }

        if (book2 != null)
        {
            Console.WriteLine($"Book 2: {book2.Title} by {book2.Author}");
        }
        else
        {
            Console.WriteLine("Book 2 not found.");
        }

        if (book3 != null)
        {
            Console.WriteLine($"Book 3: {book3.Title} by {book3.Author}");
        }
        else
        {
            Console.WriteLine("Book 3 not found.");
        }

        Console.ReadLine();
    }
}
