namespace EvolveYourCodeTests.Domain
{
    public class HouseBlend : ICoffee
    {
        public string GetDescription()
        {
            return "House Blend";
        }

        public decimal GetPrice()
        {
            return 5m;
        }
    }
}