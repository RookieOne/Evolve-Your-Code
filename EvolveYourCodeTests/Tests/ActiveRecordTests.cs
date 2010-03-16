using EvolveYourCodeTests.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvolveYourCodeTests.Tests
{
    [TestClass]
    public class ActiveRecordTests
    {
        [TestMethod]
        public void should_save_dark_roast()
        {
            var darkRoast = new DarkRoast();

            darkRoast.Save();

            Repository<DarkRoast>.LastItemSaved.ShouldBe(darkRoast);
        }
    }
}