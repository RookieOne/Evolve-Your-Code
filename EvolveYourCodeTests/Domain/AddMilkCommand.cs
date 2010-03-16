namespace EvolveYourCodeTests.Domain
{
    public class AddMilkCommand : ICoffeeCommand
    {
        public ICoffee Execute(ICoffee coffee)
        {
            return coffee.AddMilk();
        }
    }
}