using ShopItemApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopItemApi.Repositories
{
    public interface IShopItemRepository
    {
        Task Create(ShopItem shopItem);
        Task<List<ShopItem>> GetAll();
        Task<ShopItem> GetById(int id);
        Task Remove(int id);
    }
}
