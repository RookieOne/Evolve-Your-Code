using EvolveYourCodeTests.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvolveYourCodeTests.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void add_sugar_should_add_sugar_to_coffee()
        {
            var darkRoast = new DarkRoast();
            var coffee = new AddSugarCommand().Execute(darkRoast);

            coffee.ShouldBeType<SugarDecorator>();
        }

        [TestMethod]
        public void add_milk_should_add_milk_to_coffee()
        {
            var darkRoast = new DarkRoast();
            var coffee = new AddMilkCommand().Execute(darkRoast);

            coffee.ShouldBeType<MilkDecorator>();
        }

        [TestMethod]
        public void should_be_able_to_make_dark_roast_and_add_milk_with_delegate_command()
        {
            ICoffee coffee = new DarkRoast();

            coffee = new DelegateCommand(c => c.AddSugar()).Execute(coffee);
            coffee = new DelegateCommand(c => c.AddMilk()).Execute(coffee);

            coffee.ShouldBeType<MilkDecorator>();
        }
    }
}