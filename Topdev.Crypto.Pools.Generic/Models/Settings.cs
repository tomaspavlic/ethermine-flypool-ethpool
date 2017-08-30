using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    [DataContract]
    public class Settings
    {
		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>Masked Email address of the miner.</value>
		[DataMember(Name = "email")]
        public string Email { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:Topdev.Crypto.Pools.Generic.Models.Settings"/> is monitor.
		/// </summary>
		/// <value>Monitoring enabled</value>
		[DataMember(Name = "monitor"), JsonConverter(typeof(BoolConverter))]
        public bool Monitor { get; set; }

		/// <summary>
		/// Gets or sets the minimal payout.
		/// </summary>
		/// <value>Minimum payout amount defined by the miner in base units.</value>
		[DataMember(Name = "minPayout")]
        public long MinimalPayout { get; set; }

		/// <summary>
		/// Gets or sets the ip.
		/// </summary>
		/// <value>Masked IP address of one randomly selected worker.</value>
		public string Ip { get; set; }
    }
}
