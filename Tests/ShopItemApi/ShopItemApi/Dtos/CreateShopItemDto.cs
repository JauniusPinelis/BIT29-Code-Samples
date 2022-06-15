using System.ComponentModel.DataAnnotations;

namespace ShopItemApi.Dtos
{
    public class CreateShopItemDto
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
