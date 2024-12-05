using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Library : IEnumerable
    {
        private readonly Book[] _books;
        private int _currentIndex = 0;

        public Library(int capacity)
        {
            _books = new Book[capacity];
        }

        public void AddBook(Book book)
        {
            if (_currentIndex >= _books.Length)
            {
                Console.WriteLine("Библиотека заполнена. Невозможно добавить новую книгу.");
                return;
            }
            _books[_currentIndex++] = book;
        }

        public IEnumerator GetEnumerator()
        {
            return new LibraryIterator(_books);
        }
    }
}
