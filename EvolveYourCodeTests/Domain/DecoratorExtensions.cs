namespace EvolveYourCodeTests.Domain
{
    public static class DecoratorExtensions
    {
        public static ICoffee AddMilk(this ICoffee coffee)
        {
            return new MilkDecorator(coffee);
        }

        public static ICoffee AddSugar(this ICoffee coffee)
        {
            return new SugarDecorator(coffee);
        }
    }
}