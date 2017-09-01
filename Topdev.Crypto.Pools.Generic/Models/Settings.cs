using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Settings
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>Masked Email address of the miner.</value>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Topdev.Crypto.Pools.Generic.Models.Settings"/> is monitor.
        /// </summary>
        /// <value>Monitoring enabled</value>
        [JsonProperty(PropertyName = "monitor"), JsonConverter(typeof(BoolConverter))]
        public bool Monitor { get; set; }

        /// <summary>
        /// Gets or sets the minimal payout.
        /// </summary>
        /// <value>Minimum payout amount defined by the miner in base units.</value>
        [JsonProperty(PropertyName = "minPayout")]
        public long MinimalPayout { get; set; }

        /// <summary>
        /// Gets or sets the ip.
        /// </summary>
        /// <value>Masked IP address of one randomly selected worker.</value>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }
    }
}
