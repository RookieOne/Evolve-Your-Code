namespace EvolveYourCodeTests.Domain
{
    public class AddSugarCommand : ICoffeeCommand
    {
        public ICoffee Execute(ICoffee coffee)
        {
            return coffee.AddSugar();
        }
    }
}