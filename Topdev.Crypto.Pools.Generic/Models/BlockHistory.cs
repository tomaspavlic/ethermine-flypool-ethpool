using System;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class BlockHistory
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>Timestamp of the statistic entry.</value>
        [JsonProperty(PropertyName = "time"), JsonConverter(typeof(UnixTimeConverter))]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets the number of blocks.
        /// </summary>
        /// <value>Number of blocks mined during that hour.</value>
        [JsonProperty(PropertyName = "nbrBlocks")]
        public int NumberOfBlocks { get; set; }

        /// <summary>
        /// Gets or sets the difficulty.
        /// </summary>
        /// <value>Max difficulty that hour.</value>
        [JsonProperty(PropertyName = "difficulty")]
        public long Difficulty { get; set; }
    }
}
