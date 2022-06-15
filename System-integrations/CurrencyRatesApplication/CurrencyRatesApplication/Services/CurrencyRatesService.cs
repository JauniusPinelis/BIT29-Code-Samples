using CurrencyRatesApplication.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyRatesApplication.Services
{
    public class CurrencyRatesService
    {
        private HttpClient _httpClient;

        public CurrencyRatesService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<ExchangeRate>> GetExchangeRates(string date)
        {
            string url = "http://www.lb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate?Date=" + date;
            var httpResponse = await _httpClient.GetAsync(url);

            var contents = await httpResponse.Content.ReadAsStringAsync();

            // How to parse xml?
            var data = JsonConvert.DeserializeObject<ExchangeRates>(contents);

            return data.Items;
        }
    }
}
