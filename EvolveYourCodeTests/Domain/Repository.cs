namespace EvolveYourCodeTests.Domain
{
    public class Repository<T>
    {
        public static T LastItemSaved;

        public void Save(T item)
        {
            // save item
            LastItemSaved = item;
        }
    }
}