using EvolveYourCodeTests.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvolveYourCodeTests.Tests
{
    [TestClass]
    public class HouseBlendTests
    {
        [TestMethod]
        public void price_should_be_5()
        {
            var houseBlend = new HouseBlend();

            houseBlend.GetPrice().ShouldBe(5);
        }

        [TestMethod]
        public void description_should_be_house_blend()
        {
            new HouseBlend().GetDescription().ShouldBe("House Blend");
        }
    }
}