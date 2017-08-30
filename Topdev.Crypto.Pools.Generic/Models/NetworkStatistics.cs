using System;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class NetworkStatistics
    {
		/// <summary>
		/// Gets or sets the time.
		/// </summary>
		/// <value>Timestamp of the entry.</value>
		[JsonProperty(PropertyName = "time"), JsonConverter(typeof(UnixTimeConverter))]
        public DateTime Time { get; set; }

		/// <summary>
		/// Gets or sets the block time.
		/// </summary>
		/// <value>Current block time of the network.</value>
		[JsonProperty(PropertyName = "blockTime")]
        public decimal BlockTime { get; set; }

		/// <summary>
		/// Gets or sets the difficulty.
		/// </summary>
		/// <value>Current difficulty of the network.</value>
		[JsonProperty(PropertyName = "difficulty")]
        public long Difficulty { get; set; }

		/// <summary>
		/// Gets or sets the hashrate.
		/// </summary>
		/// <value>Current hashrate of the network in H/s.</value>
		[JsonProperty(PropertyName = "hashrate")]
        public long Hashrate { get; set; }

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
