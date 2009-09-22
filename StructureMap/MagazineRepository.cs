namespace StructureMap
{
    public class MagazineRepository : IMagazineRepository
    {
        private readonly string _connectionString;

        public MagazineRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}