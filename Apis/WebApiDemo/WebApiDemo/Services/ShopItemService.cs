using System.Collections.Generic;
using System.Linq;
using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public class ShopItemService
    {
        private List<ShopItem> _shopItems = new List<ShopItem>()
        {
            new ShopItem()
            {
                Name = "Ice cream",
                Id = 1
            },
            new ShopItem()
            {
                Name = "Candy",
                Id = 2
            }
        };

        public ShopItem Get(int id)
        {
            return _shopItems.First(s => s.Id == id);
        }

        public List<ShopItem> GetAll()
        {
            return _shopItems;
        }

        public void Add(ShopItem shopItem)
        {
            _shopItems.Add(shopItem);
        }

        public void Update(ShopItem shopItem)
        {
            var shopItemToUpdate = _shopItems.First(s => s.Id == shopItem.Id);

            shopItemToUpdate.Name = shopItem.Name;
        }

        public void Remove(int id)
        {
            var shopItemToRemove = _shopItems.First(s => s.Id == id);

            _shopItems.Remove(shopItemToRemove);
        }

    }
}
