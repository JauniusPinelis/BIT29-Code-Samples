using System.Collections.Generic;
using System.Xml.Serialization;

namespace CurrencyRatesApplication.Models
{
    public class ExchangeRatesCollection
    {
        [XmlElement("ExchangeRatesCollection")]
        public List<ExchangeRate> ExchangeRates { get; set; }
    }
}
