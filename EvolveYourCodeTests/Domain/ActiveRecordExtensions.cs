namespace EvolveYourCodeTests.Domain
{
    public static class ActiveRecordExtensions
    {
        public static void Save<T>(this T item)
        {
            new Repository<T>().Save(item);
        }
    }
}