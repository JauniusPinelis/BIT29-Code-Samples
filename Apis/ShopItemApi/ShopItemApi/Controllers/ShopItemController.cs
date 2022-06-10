using Microsoft.AspNetCore.Mvc;
using ShopItemApi.Dtos;
using ShopItemApi.Services;
using System;
using System.Threading.Tasks;

namespace ShopItemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private ShopItemService _shopItemService;

        public ShopItemController(ShopItemService shopItemService)
        {
            _shopItemService = shopItemService;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _shopItemService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await _shopItemService.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateShopItemDto shopItem)
        {
            await _shopItemService.Create(shopItem);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Remove(int id)
        {
            try
            {
                await _shopItemService.GetById(id);

                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
