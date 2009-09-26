using System.Collections.Generic;

namespace FluentExamples
{
    public class BookList
    {
        private readonly List<Book> _books;

        public BookList()
        {
            _books = new List<Book>();
        }

        public BookList Add(Book book)
        {
            _books.Add(book);
            return this;
        }

        public BookList Sort()
        {
            _books.Sort();
            return this;
        }
    }
}