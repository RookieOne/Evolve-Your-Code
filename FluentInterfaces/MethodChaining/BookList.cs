using System.Collections.Generic;
using FluentInterfaces.Builders;

namespace FluentInterfaces.MethodChaining
{
    public class BookList
    {
        public BookList()
        {
            _books = new List<Book>();
        }

        readonly List<Book> _books;

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