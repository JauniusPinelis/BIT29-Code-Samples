using System;

namespace ShopItemApi.Models
{
    public class ShopItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public string CreateBy { get; set; } = "Admin";
    }
}
