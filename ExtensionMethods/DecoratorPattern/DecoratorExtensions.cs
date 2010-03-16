using ExtensionMethods.Domain;

namespace ExtensionMethods.DecoratorPattern
{
    public static class DecoratorExtensions
    {
        public static IBeverage AddMilk(this IBeverage beverage)
        {
            return new MilkDecorator(beverage);
        }

        public static IBeverage AddSugar(this IBeverage beverage)
        {
            return new SugarDecorator(beverage);
        }
    }
}