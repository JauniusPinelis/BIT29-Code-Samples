using System.Collections.Generic;
using System.Linq;
using WebApiDemo.Exceptions;
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
            var shopItem = _shopItems.FirstOrDefault(s => s.Id == id);
            if (shopItem == null)
            {
                throw new ItemNotFoundException();
            }

            return shopItem;
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
            var shopItemToUpdate = Get(shopItem.Id);

            shopItemToUpdate.Name = shopItem.Name;
        }

        public void Remove(int id)
        {
            var shopItem = Get(id);

            _shopItems.Remove(shopItem);
        }

    }
}
