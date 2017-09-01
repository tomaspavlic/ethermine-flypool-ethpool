using System;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class ServerStatistics
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>timestamp of the statistic entry.</value>
        [JsonProperty(PropertyName = "time"), JsonConverter(typeof(UnixTimeConverter))]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets the hashrate.
        /// </summary>
        /// <value>Current hashrate in H/s.</value>
        [JsonProperty(PropertyName = "hashrate")]
        public decimal Hashrate { get; set; }

        /// <summary>
        /// Gets or sets the server.
        /// </summary>
        /// <value>Server name.</value>
        [JsonProperty(PropertyName = "server")]
        public string Server { get; set; }
    }
}
