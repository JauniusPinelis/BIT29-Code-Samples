using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApiDemo.Exceptions;
using WebApiDemo.Models;
using WebApiDemo.Services;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private readonly ShopItemService _shopItemService;

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
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                ShopItem shopItem = await _shopItemService.Get(id);
                return Ok(shopItem);
            }
            catch (ItemNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShopItem shopItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _shopItemService.Add(shopItem);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ShopItem shopItem)
        {
            await _shopItemService.Update(shopItem);
            return NoContent();
        }


        [HttpPut("{id}/deactivate")]
        public async Task<IActionResult> Deactivate()
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _shopItemService.Remove(id);
            return NoContent();
        }
    }
}
