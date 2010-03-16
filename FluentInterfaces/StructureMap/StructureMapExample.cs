using StructureMap;

namespace FluentInterfaces.StructureMap
{
    public class StructureMapExample
    {
        public void Example()
        {
            var container = new Container(x =>
                                              {
                                                  x.For<IBookRepository>()
                                                      .Use<BookRepository>()
                                                      .Named("Book Repository");

                                                  x.For<IMagazineRepository>()
                                                      .Use<MagazineRepository>();
                                              });
        }
    }
}