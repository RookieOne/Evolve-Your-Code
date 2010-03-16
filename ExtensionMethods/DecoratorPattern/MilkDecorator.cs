using ExtensionMethods.Domain;

namespace ExtensionMethods.DecoratorPattern
{
    public class MilkDecorator : IBeverage
    {
        public MilkDecorator(IBeverage beverage)
        {
            DecoratedBeverage = beverage;
        }

        IBeverage DecoratedBeverage { get; set; }

        public string GetDescription()
        {
            return DecoratedBeverage.GetDescription() + " with Milk";
        }

        public decimal GetPrice()
        {
            return DecoratedBeverage.GetPrice() + .5m;
        }
    }
}