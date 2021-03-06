using System;

namespace ShopItemApi.Dtos
{
    public class ShopItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public decimal Price { get; set; }

        public DateTime Created { get; set; }

    }
}
