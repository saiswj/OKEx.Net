﻿using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using Okex.Net.Converters;
using Okex.Net.Enums;
using System;

namespace Okex.Net.RestObjects.Trade
{
    public class OkexOrderAmendRequest
    {
        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore), JsonOptionalProperty]
        public long? OrderId { get; set; }

        [JsonProperty("clOrdId")]
        public string ClientOrderId { get; set; }
        
        [JsonProperty("reqId")]
        public string RequestId { get; set; }
        
        [JsonProperty("cxlOnFail", NullValueHandling = NullValueHandling.Ignore), JsonOptionalProperty]
        public bool? CancelOnFail { get; set; }
        
        [JsonProperty("newSz", NullValueHandling = NullValueHandling.Ignore), JsonOptionalProperty]
        public decimal? NewQuantity { get; set; }
        
        [JsonProperty("newPx", NullValueHandling = NullValueHandling.Ignore), JsonOptionalProperty]
        public decimal? NewPrice { get; set; }
    }
}