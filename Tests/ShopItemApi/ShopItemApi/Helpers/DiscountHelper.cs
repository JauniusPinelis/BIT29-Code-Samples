namespace ShopItemApi.Helpers
{
    public static class DiscountHelper
    {
        public static decimal GetDiscountPrice(decimal price)
        {
            // discount
            return 0.9M * price;
        }
    }
}
