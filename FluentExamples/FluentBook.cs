namespace FluentExamples
{
    public class FluentBook
    {
        public string Author { get; private set; }
        public string Title { get; private set; }

        public static FluentBook Create()
        {
            return new FluentBook();
        }

        public FluentBook Titled(string title)
        {
            Title = title;
            return this;
        }

        public FluentBook WrittenBy(string author)
        {
            Author = author;
            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} by {1}", Title, Author);
        }
    }
}