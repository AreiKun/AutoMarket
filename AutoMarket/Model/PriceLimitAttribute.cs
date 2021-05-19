
namespace AutoMarket
{
    public sealed class PriceLimitAttribute : System.Attribute
    {
        public int Price;
        public PriceLimitAttribute() { }
        public PriceLimitAttribute(int price)
        {
            Price = price;
        }
    }
}
