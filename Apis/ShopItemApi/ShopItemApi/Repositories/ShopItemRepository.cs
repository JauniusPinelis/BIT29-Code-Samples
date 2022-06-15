using Microsoft.EntityFrameworkCore;
using ShopItemApi.Data;
using ShopItemApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopItemApi.Repositories
{
    public class ShopItemRepository : IShopItemRepository
    {
        private readonly DataContext _dataContext;

        public ShopItemRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<ShopItem>> GetAll()
        {
            return await _dataContext.ShopItems.Where(s => !s.Deleted).ToListAsync();
        }

        public async Task Create(ShopItem shopItem)
        {
            _dataContext.ShopItems.Add(shopItem);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<ShopItem> GetById(int id)
        {
            var shopItem = await _dataContext.ShopItems.FirstOrDefaultAsync(si => si.Id == id);
            if (shopItem == null)
            {
                throw new ArgumentException("ShopItem is not found");
            }

            return shopItem;
        }

        public async Task Remove(int id)
        {
            var shopitem = await GetById(id);

            //_dataContext.ShopItems.Remove(shopitem);
            shopitem.Deleted = true;

            _dataContext.Update(shopitem);
            await _dataContext.SaveChangesAsync();
        }
    }
}
