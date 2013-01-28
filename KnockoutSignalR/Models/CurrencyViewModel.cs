using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace KnockoutSignalR.Models
{
    public class CurrencyViewModel
    {
        public class Currency
        {
            [JsonProperty(PropertyName = "code")]
            public string Code { get; set; }
            [JsonProperty(PropertyName = "price")]
            public decimal Price { get; set; }
        }

        public List<Currency> Currencies { get; set; }
    }
}