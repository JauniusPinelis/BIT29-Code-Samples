using CurrencyRatesApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CurrencyRatesApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyRatesController : ControllerBase
    {
        private readonly CurrencyRatesService _currencyRatesService;

        public CurrencyRatesController(CurrencyRatesService currencyRatesService)
        {
            _currencyRatesService = currencyRatesService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string date)
        {
            return Ok(await _currencyRatesService.GetExchangeRates(date));
        }
    }
}
