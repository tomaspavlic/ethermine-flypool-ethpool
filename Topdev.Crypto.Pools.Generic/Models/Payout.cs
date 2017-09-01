using System;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Payout
    {
        /// <summary>
        /// Gets or sets the paid on.
        /// </summary>
        /// <value>Timestamp of the payout.</value>
        [JsonProperty(PropertyName = "paidOn"), JsonConverter(typeof(UnixTimeConverter))]
        public DateTime PaidOn { get; set; }

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>Start block of payout.</value>
        [JsonProperty(PropertyName = "start")]
        public long Start { get; set; }

        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>End block of payout.</value>
        [JsonProperty(PropertyName = "end")]
        public long End { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>Paid amount in base units.</value>
        [JsonProperty(PropertyName = "amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Gets or sets the transaction hash.
        /// </summary>
        /// <value>Hash of the payout transaction.</value>
        [JsonProperty(PropertyName = "txHash")]
        public string TransactionHash { get; set; }
    }
}
