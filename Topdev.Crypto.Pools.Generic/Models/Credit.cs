using System;
using Newtonsoft.Json;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Credit
    {
        /// <summary>
        /// Gets or sets the miner.
        /// </summary>
        /// <value>The miner.</value>
        [JsonProperty(PropertyName = "miner")]
        public string Miner { get; set; }

        /// <summary>
        /// Gets or sets the hashrate.
        /// </summary>
        /// <value>Current hashrate in H/s.</value>
        [JsonProperty(PropertyName = "hashrate")]
        public long Hashrate { get; set; }

        /// <summary>
        /// Gets or sets the credit.
        /// </summary>
        /// <value>Credit of the miner.</value>
        [JsonProperty(PropertyName = "credit")]
        public long Credits { get; set; }
    }
}
