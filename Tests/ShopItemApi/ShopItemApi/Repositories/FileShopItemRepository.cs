using Newtonsoft.Json;
using ShopItemApi.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopItemApi.Repositories
{
    public class FileShopItemRepository : IShopItemRepository
    {
        private readonly string _fileName = "data.json";
        public async Task Create(ShopItem shopItem)
        {
            string dataText = await File.ReadAllTextAsync(_fileName);

            var shopItems = JsonConvert.DeserializeObject<List<ShopItem>>(dataText);

            shopItems.Add(shopItem);

            var updatedDataText = JsonConvert.SerializeObject(shopItems);

            await File.WriteAllTextAsync(_fileName, updatedDataText);
        }

        public async Task<List<ShopItem>> GetAll()
        {
            string dataText = await File.ReadAllTextAsync(_fileName);

            var shopItems = JsonConvert.DeserializeObject<List<ShopItem>>(dataText);

            return shopItems;
        }

        public async Task<ShopItem> GetById(int id)
        {
            string dataText = await File.ReadAllTextAsync(_fileName);

            var shopItems = JsonConvert.DeserializeObject<List<ShopItem>>(dataText);

            return shopItems.FirstOrDefault(s => s.Id == id);
        }

        public Task<ShopItem> GetByIdWithDiscount(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Remove(int id)
        {
            string dataText = await File.ReadAllTextAsync(_fileName);

            var shopItems = JsonConvert.DeserializeObject<List<ShopItem>>(dataText);

            shopItems = shopItems.Where(si => si.Id != id).ToList();

            var updatedDataText = JsonConvert.SerializeObject(shopItems);

            await File.ReadAllTextAsync(updatedDataText);
        }
    }
}
