using CurrencyRatesApplication.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            string url = "http://www.lb.lt/webservices/ExchangeRatesCollection/ExchangeRatesCollection.asmx/getExchangeRatesByDate?Date=" + date;
            var httpResponse = await _httpClient.GetAsync(url);

            var contents = await httpResponse.Content.ReadAsStringAsync();

            // How to parse xml?
            //var data = JsonConvert.DeserializeObject<ExchangeRatesCollection>(contents);

            var stringReader = new System.IO.StringReader(contents);
            var serializer = new XmlSerializer(typeof(ExchangeRatesCollection));
            var parsed = serializer.Deserialize(stringReader) as ExchangeRatesCollection;

            return parsed.ExchangeRates;
        }
    }
}
