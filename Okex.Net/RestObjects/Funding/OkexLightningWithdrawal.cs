﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using Okex.Net.Converters;
using Okex.Net.Enums;
using System;

namespace Okex.Net.RestObjects.Funding
{
    public class OkexLightningWithdrawal
    {
        [JsonProperty("cTime"), JsonConverter(typeof(OkexTimestampConverter))]
        public DateTime Time { get; set; }

        [JsonProperty("wdId")]
        public string WithdrawalId { get; set; }
    }
}