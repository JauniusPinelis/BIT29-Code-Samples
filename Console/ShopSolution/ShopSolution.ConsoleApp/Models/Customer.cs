namespace ShopSolution.ConsoleApp.Models
{
    public class Customer
    {
        public decimal Balance { get; set; } = 20;

        public List<ShopItem> Cart { get; set; } = new List<ShopItem>();
    }
}
