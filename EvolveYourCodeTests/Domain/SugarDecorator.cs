namespace EvolveYourCodeTests.Domain
{
    public class SugarDecorator : ICoffee
    {
        public SugarDecorator(ICoffee decoratedCoffee)
        {
            _decoratedCoffee = decoratedCoffee;
        }

        readonly ICoffee _decoratedCoffee;

        public string GetDescription()
        {
            return _decoratedCoffee + " with sugar";
        }

        public decimal GetPrice()
        {
            return _decoratedCoffee.GetPrice() + .2m;
        }
    }
}