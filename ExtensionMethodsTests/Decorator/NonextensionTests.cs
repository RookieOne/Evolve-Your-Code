using ExtensionMethods.DecoratorPattern;
using ExtensionMethods.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodsTests.Decorator
{
    [TestClass]
    public class NonextensionTests
    {
        [TestMethod]
        public void dark_roast()
        {
            var darkRoast = new DarkRoast();
            darkRoast.GetPrice().ShouldBe(7m);
        }

        [TestMethod]
        public void dark_roast_with_milk()
        {
            var darkRoast = new MilkDecorator(new DarkRoast());
            darkRoast.GetPrice().ShouldBe(7.5m);
        }

        [TestMethod]
        public void dark_roast_with_sugar()
        {
            var darkRoast = new SugarDecorator(new DarkRoast());
            darkRoast.GetPrice().ShouldBe(7.2m);
        }

        [TestMethod]
        public void dark_roast_with_sugar_and_milk()
        {
            var darkRoast = new SugarDecorator(new MilkDecorator(new DarkRoast()));
            darkRoast.GetPrice().ShouldBe(7.7m);
        }
    }
}