namespace EvolveYourCodeTests.Domain
{
    public interface ICoffeeCommand
    {
        ICoffee Execute(ICoffee coffee);
    }
}