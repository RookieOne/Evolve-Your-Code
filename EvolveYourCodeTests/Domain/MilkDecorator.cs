namespace EvolveYourCodeTests.Domain
{
    public class MilkDecorator : ICoffee
    {
        public MilkDecorator(ICoffee decoratedCoffee)
        {
            _decoratedCoffee = decoratedCoffee;
        }

        readonly ICoffee _decoratedCoffee;

        public string GetDescription()
        {
            return _decoratedCoffee.GetDescription() + " with milk";
        }

        public decimal GetPrice()
        {
            return _decoratedCoffee.GetPrice() + .5m;
        }
    }
}