using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FizzWare.NBuilder;

namespace FluentExamples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AddExample();
        }


        public static void AddExample()
        {
            IList<Book> books = Builder<Book>
                .CreateListOfSize(15)
                .WhereRandom(5)
                .HasDoneToIt(b => b.Author = "Timothy Zahn")
                .WhereTheFirst(1)
                .Have(b => b.Author == "Timothy Zahn")
                .HasDoneToIt(b => b.Title = "The Cobra Trilogy")
                .Build();


            var comboBox1 = new ComboBox();
            var comboBox2 = new ComboBox();


            foreach (Book b in books)
                comboBox1.Items.Add(b);


            Add<Book>.From(books).To(comboBox2);
        }

        public static void SelectedExample()
        {
            IList<Book> books = Builder<Book>
                .CreateListOfSize(15)
                .WhereRandom(5)
                .HasDoneToIt(b => b.Author = "Timothy Zahn")
                .WhereTheFirst(1)
                .Have(b => b.Author == "Timothy Zahn")
                .HasDoneToIt(b => b.Title = "The Cobra Trilogy")
                .Build();

            IEnumerable<Book> booksToSelect = books.Where(b => b.Author == "Timothy Zahn");

            var listBox = new ListBox();

            Add<Book>.From(books).To(listBox);

            Select<Book>.On(listBox).These(booksToSelect);


            var selectedBooks = new List<Book>();

            foreach (Book b in listBox.SelectedItems)
            {
                selectedBooks.Add(b);
            }


            var selectedBooks2 = Selected<Book>
                                        .From(listBox)
                                        .All();


            foreach (Book b in selectedBooks)
                Console.WriteLine(b);
            foreach (var b in selectedBooks2)
                Console.WriteLine(b);
        }

        public static void LawOfDemeter()
        {

            var myA = new A();

            myA.ChildB.DoStuff();

            myA.DoStuffOnChild();


        }

        public static void Builders()
        {
            var endersGame = FluentBook.Create()
                .Titled("Enders Game")
                .WrittenBy("Orson Scott Card");

            var endersShadow = BookBuilder.NewBook()
                .Titled("Enders Shadow")
                .WrittenBy("Orson Scott Card")
                .Create();

            Console.WriteLine(endersGame);
            Console.WriteLine(endersShadow);
        }
    }
}