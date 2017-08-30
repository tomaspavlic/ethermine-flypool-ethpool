using System;
using Newtonsoft.Json;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Price
    {
		/// <summary>
		/// Gets or sets the usd.
		/// </summary>
		/// <value>Current price in USD.</value>
		[JsonProperty(PropertyName = "usd")]
        public decimal Usd { get; set; }

		/// <summary>
		/// Gets or sets the btc.
		/// </summary>
		/// <value>Current price in BTC.</value>
		[JsonProperty(PropertyName = "btc")]
        public decimal Btc { get; set; }
    }
}
