using EvolveYourCodeTests.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvolveYourCodeTests.Tests
{
    [TestClass]
    public class DecoratorTests
    {
        [TestMethod]
        public void adding_milk_should_update_dark_roast_price()
        {
            var darkRoast = new MilkDecorator(new DarkRoast());

            darkRoast.GetPrice().ShouldBe(7.5m);
        }

        [TestMethod]
        public void adding_milk_using_extension_should_update_dark_roast_price()
        {
            var darkRoast = new DarkRoast().AddMilk();

            darkRoast.GetPrice().ShouldBe(7.5m);
        }
    }
}