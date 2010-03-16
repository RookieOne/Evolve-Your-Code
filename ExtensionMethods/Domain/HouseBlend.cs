
namespace ExtensionMethods.Domain
{
    public class HouseBlend : IBeverage
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
