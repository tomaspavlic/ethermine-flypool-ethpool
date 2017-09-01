using System;
using Newtonsoft.Json;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class TopMiner
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
        /// <value>Current hashrate of the network in H/s.</value>
        [JsonProperty(PropertyName = "hashrate")]
        public long Hashrate { get; set; }
    }
}
