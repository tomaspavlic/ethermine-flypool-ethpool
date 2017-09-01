using Newtonsoft.Json;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Round
    {
        /// <summary>
        /// Gets or sets the block.
        /// </summary>
        /// <value>Block number of the round.</value>
        [JsonProperty(PropertyName = "block")]
        public long Block { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>Amount in base units allocated to the miner in the round.</value>
        [JsonProperty(PropertyName = "amount")]
        public long Amount { get; set; }
    }
}
