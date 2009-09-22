namespace StructureMap
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var container = new Container(registry =>
              {
                  registry.InstanceOf<IBookRepository>()
                      .Is.OfConcreteType<BookRepository>()
                      .WithName("Alias");

                  registry.ForRequestedType<IMagazineRepository>()
                      .TheDefault.Is.OfConcreteType<MagazineRepository>()
                      .WithCtorArg("connectionString").EqualToAppSetting(
                      "connectionString");
              });



            var r = container.GetInstance<IBookRepository>();
        }
    }
}