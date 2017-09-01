using System;
using Newtonsoft.Json;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class PoolInfo
    {
        /// <summary>
        /// Gets or sets the mined blocks.
        /// </summary>
        /// <value>Array of blocks recently mined by the pool.</value>
        [JsonProperty(PropertyName = "minedBlocks")]
        public Block[] MinedBlocks { get; set; }

        /// <summary>
        /// Gets or sets the top miners.
        /// </summary>
        /// <value>Array of top miners.</value>
        [JsonProperty(PropertyName = "topMiners")]
        public TopMiner[] TopMiners { get; set; }

        /// <summary>
        /// Gets or sets the statistics.
        /// </summary>
        /// <value>General pool stats.</value>
        [JsonProperty(PropertyName = "poolStats")]
        public PoolStatistics Statistics { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>Price information.</value>
        [JsonProperty(PropertyName = "price")]
        public Price Price { get; set; }
    }
}
