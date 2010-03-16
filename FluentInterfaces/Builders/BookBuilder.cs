namespace FluentInterfaces.Builders
{
    public class BookBuilder
    {
        private string _author;
        private string _title;

        public static BookBuilder NewBook()
        {
            return new BookBuilder();
        }

        public BookBuilder Titled(string title)
        {
            _title = title;
            return this;
        }

        public BookBuilder WrittenBy(string author)
        {
            _author = author;
            return this;
        }

        public Book Create()
        {
            return new Book {Title = _title, Author = _author};
        }
    }
}