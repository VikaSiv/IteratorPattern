using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class LibraryIterator : IEnumerator
    {
        private readonly Book[] _books;
        private int _position = -1;

        public LibraryIterator(Book[] books)
        {
            _books = books;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _books.Length && _books[_position] != null;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current => _books[_position];
    }
}
