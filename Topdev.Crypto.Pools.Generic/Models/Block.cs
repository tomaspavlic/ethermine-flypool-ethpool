using System;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Block
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>Block number.</value>
        [JsonProperty(PropertyName = "number")]
        public long Number { get; set; }

        /// <summary>
        /// Gets or sets the miner.
        /// </summary>
        /// <value>Mined by.</value>
        [JsonProperty(PropertyName = "miner")]
        public string Miner { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>Mined on.</value>
        [JsonProperty(PropertyName = "time"), JsonConverter(typeof(UnixTimeConverter))]
        public DateTime Time { get; set; }
    }
}
