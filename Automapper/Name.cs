namespace Automapper
{
    public class Name
    {
        public Name(string firstName, char middleInitial, string lastName)
        {
            FirstName = firstName;
            MiddleInitial = middleInitial;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public char MiddleInitial { get; private set; }
        public string LastName { get; private set; }
    }

    public class NameBuilder
    {
        private string _firstName;
        private string _lastName;
        private char _middleInitial;

        public static NameBuilder Create()
        {
            return new NameBuilder();
        }

        public NameBuilder First(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public NameBuilder MI(char middleInitial)
        {
            _middleInitial = middleInitial;
            return this;
        }

        public NameBuilder Last(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public Name Finish()
        {
            return new Name(_firstName, _middleInitial, _lastName);
        }
    }
}