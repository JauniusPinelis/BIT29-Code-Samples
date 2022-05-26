using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    public class ShopItem
    {
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        public string Name { get; set; }
    }
}
