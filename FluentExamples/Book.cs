namespace FluentExamples
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return string.Format("{0} by {1}", Title, Author);
        }
    }
}