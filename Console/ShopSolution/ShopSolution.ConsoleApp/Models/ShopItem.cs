namespace ShopSolution.ConsoleApp.Models
{
    public class ShopItem
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Quantity: {Quantity}, Price: {Price}";
        }
    }
}
