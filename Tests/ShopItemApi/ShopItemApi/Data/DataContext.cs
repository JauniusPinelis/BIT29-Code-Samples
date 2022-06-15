using Microsoft.EntityFrameworkCore;
using ShopItemApi.Models;

namespace ShopItemApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ShopItem> ShopItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
