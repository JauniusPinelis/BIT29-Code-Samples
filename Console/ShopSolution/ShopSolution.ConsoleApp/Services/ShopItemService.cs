using ShopSolution.ConsoleApp.Models;

namespace ShopSolution.ConsoleApp.Services
{
    public class ShopItemService
    {
        private List<ShopItem> _shopItems = new List<ShopItem>();
        private Customer _customer = new Customer();

        public void Add(string name, int quantity, decimal price)
        {
            if (_shopItems.Any(si => si.Name == name))
            {
                throw new ArgumentException("Item already exists");
            }

            ShopItem item = new ShopItem
            {
                Name = name,
                Quantity = quantity,
                Price = price
            };

            _shopItems.Add(item);
        }

        public void Remove(string name)
        {
            if (!_shopItems.Any(si => si.Name == name))
            {
                throw new ArgumentException("The item does not exist");
            }

            _shopItems = _shopItems.Where(si => si.Name != name).ToList();
        }

        public List<ShopItem> GetAll()
        {
            return _shopItems;
        }

        public List<ShopItem> GetCustomerItems()
        {
            return _customer.Cart;
        }

        public void UpdateQuantity(string name, int quantity)
        {
            var item = _shopItems.FirstOrDefault(si => si.Name == name);

            if (item == null)
            {
                throw new ArgumentException("The item does not exist");
            }

            item.Quantity = quantity;
        }

        public decimal GetBalance()
        {
            return _customer.Balance;
        }

        public void Topup(decimal topup)
        {
            _customer.Balance += topup;
        }

        public void Buy(string name, int quantity)
        {
            var item = _shopItems.FirstOrDefault(si => si.Name == name);

            if (item == null)
            {
                throw new ArgumentException("The item does not exist");
            }

            decimal price = item.Price * quantity;

            if (price > _customer.Balance)
            {
                throw new ArgumentException("do not have enough money");
            }

            if (quantity > item.Quantity)
            {
                throw new ArgumentException("Not enough of the item");
            }

            item.Quantity -= quantity;
            _customer.Balance -= price;

            _customer.Cart.Add(new ShopItem
            {
                Name = item.Name,
                Price = item.Price,
                Quantity = quantity,
            });
        }
    }
}
