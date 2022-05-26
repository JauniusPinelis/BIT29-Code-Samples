using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiDemo.Data;
using WebApiDemo.Exceptions;
using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public class ShopItemService
    {
        private readonly DataContext _dataContext;

        public ShopItemService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ShopItem> Get(int id)
        {
            var shopItem = await _dataContext.ShopItems.FirstOrDefaultAsync(s => s.Id == id);
            if (shopItem == null)
            {
                throw new ItemNotFoundException();
            }

            return shopItem;
        }

        public async Task<List<ShopItem>> GetAll()
        {
            return await _dataContext.ShopItems.ToListAsync();

        }

        public async Task Add(ShopItem shopItem)
        {
            _dataContext.ShopItems.Add(shopItem);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Update(ShopItem shopItem)
        {
            _dataContext.Update(shopItem);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            var shopItem = await Get(id);

            _dataContext.ShopItems.Remove(shopItem);
            await _dataContext.SaveChangesAsync();
        }

    }
}
