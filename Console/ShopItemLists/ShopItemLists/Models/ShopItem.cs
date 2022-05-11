namespace ShopItemLists.Models
{
    public class ShopItem
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public bool Expired { get; set; } = false;
    }
}
