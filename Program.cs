using System;
using IteratorPattern;

namespace IteratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library(5);

            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.AddBook(new Book("Brave New World", "Aldous Huxley", 1932));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));

            Console.WriteLine("Книги в библиотеке:");
            foreach (Book book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
