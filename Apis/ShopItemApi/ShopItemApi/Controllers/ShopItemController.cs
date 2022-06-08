using Microsoft.AspNetCore.Mvc;
using ShopItemApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopItemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private List<ShopItem> _shopItems = new List<ShopItem>()
        {
            new ShopItem() { Id = 1, Name = "Candy"},
            new ShopItem() { Id = 2, Name = "Ice Cream"},
        };

        [HttpGet]

        public List<ShopItem> GetAll()
        {
            return _shopItems;
        }

        [HttpGet("{id}")]
        public ShopItem GetById(int id)
        {
            return _shopItems.FirstOrDefault(si => si.Id == id);
        }

        [HttpPost]
        public void Create(ShopItem shopItem)
        {
            _shopItems.Add(shopItem);
        }

        [HttpDelete("{id}")]
        public List<ShopItem> Remove(int id)
        {
            _shopItems = _shopItems.Where(s => s.Id != id).ToList();
            return _shopItems;
        }
    }
}
