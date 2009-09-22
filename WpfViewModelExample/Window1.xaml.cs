using System.Collections.Generic;
using System.Windows;
using System.Linq;

namespace WpfViewModelExample
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            var books = new List<Book>();

            //IEnumerable<Book> greatBooks = books.Where(b => b.Author == "Timothy Zahn");

            IEnumerable<Book> greatBooks = books.Where(AuthorIsTimothyZahn);

            foreach (var book in greatBooks)
            {
                    
            }

            InitializeComponent();

            int stuff = 0;

            Loaded += DoStuff;

            Loaded += delegate { stuff++; };

            Loaded += (sender, e) => stuff++;
        }

        public void DoStuff(object sender, RoutedEventArgs e)
        {}

        public bool AuthorIsTimothyZahn(Book b)
        {
            return b.Author == "Timothy Zahn";
        }
    }
}