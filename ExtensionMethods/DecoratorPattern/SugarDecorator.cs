using ExtensionMethods.Domain;

namespace ExtensionMethods.DecoratorPattern
{
    public class SugarDecorator : IBeverage
    {
        public SugarDecorator(IBeverage beverage)
        {
            DecoratedBeverage = beverage;
        }

        IBeverage DecoratedBeverage { get; set; }

        public string GetDescription()
        {
            return DecoratedBeverage.GetDescription() + " with Sugar";
        }

        public decimal GetPrice()
        {
            return DecoratedBeverage.GetPrice() + .2m;
        }
    }
}