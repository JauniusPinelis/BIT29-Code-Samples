using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAll()
        {
            return Ok(_shopItemService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var shopItem = _shopItemService.Get(id);
                return Ok(shopItem);
            }
            catch (ItemNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(ShopItem shopItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _shopItemService.Add(shopItem);
            return NoContent();
        }

        [HttpPut]
        public IActionResult Update(ShopItem shopItem)
        {
            _shopItemService.Update(shopItem);
            return NoContent();
        }


        [HttpPut("{id}/deactivate")]
        public IActionResult Deactivate()
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _shopItemService.Remove(id);
            return NoContent();
        }
    }
}
