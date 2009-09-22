namespace LambdaExpressionsConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var spec = new Spec<Book>(b => b.Author == "Timothy Zahn");

            var theGunslinger = new Book {Author = "Stephen King", Title = "The Gunslinger"};
            var heirToTheEmpire = new Book {Author = "Timothy Zahn", Title = "Heir to the Empire"};

            var t = spec.IsSatisfiedBy(heirToTheEmpire);
            var f = spec.IsSatisfiedBy(theGunslinger);

            int stuff = 0;

            var command = new DelegateCommand(() => stuff++);

            command.Execute();
        }
    }
}