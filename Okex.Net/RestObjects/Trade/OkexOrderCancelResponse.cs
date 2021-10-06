﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using Okex.Net.Converters;
using Okex.Net.Enums;
using System;

namespace Okex.Net.RestObjects.Trade
{
    public class OkexOrderCancelResponse
    {
        [JsonProperty("ordId")]
        public long? OrderId { get; set; }

        [JsonProperty("clOrdId")]
        public string ClientOrderId { get; set; }
        
        [JsonProperty("sCode")]
        public string Code { get; set; }
        
        [JsonProperty("sMsg")]
        public string Message { get; set; }
    }
}
