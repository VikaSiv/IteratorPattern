using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int Year { get; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Year})";
        }
    }
}
