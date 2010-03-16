namespace EvolveYourCodeTests.Domain
{
    public class DarkRoast : ICoffee
    {
        public string GetDescription()
        {
            return "Dark Roast";
        }

        public decimal GetPrice()
        {
            return 7m;
        }
    }
}