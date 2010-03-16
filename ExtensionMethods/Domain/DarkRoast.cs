
namespace ExtensionMethods.Domain
{
    public class DarkRoast : IBeverage
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
