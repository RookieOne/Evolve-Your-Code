using EvolveYourCodeTests.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvolveYourCodeTests.Tests
{
    [TestClass]
    public class DarkRoastTests
    {
        [TestMethod]
        public void price_should_be_7()
        {
            var darkRoast = new DarkRoast();

            var price = darkRoast.GetPrice();

            Assert.AreEqual(7m, price);
        }

        [TestMethod]
        public void description_should_be_dark_roast()
        {
            var darkRoast = new DarkRoast();

            var desc = darkRoast.GetDescription();

            Assert.AreEqual("Dark Roast", desc);
        }
    }
}