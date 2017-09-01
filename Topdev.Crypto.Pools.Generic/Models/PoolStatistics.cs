using System;
using Newtonsoft.Json;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class PoolStatistics
    {
        /// <summary>
        /// Gets or sets the hashrate.
        /// </summary>
        /// <value>Current hashrate of the network in H/s.</value>
        [JsonProperty(PropertyName = "hashrate")]
        public long Hashrate { get; set; }

        /// <summary>
        /// Gets or sets the miners.
        /// </summary>
        /// <value>Currently active miners.</value>
        [JsonProperty(PropertyName = "miners")]
        public int Miners { get; set; }

        /// <summary>
        /// Gets or sets the miners.
        /// </summary>
        /// <value>Currently active workers.</value>
        [JsonProperty(PropertyName = "workers")]
        public int Workers { get; set; }
    }
}
