using System;
using System.Runtime.Serialization;

namespace Topdev.Crypto.Pools.Generic.Models
{
    [DataContract]
    public class Round
    {
		/// <summary>
		/// Gets or sets the block.
		/// </summary>
		/// <value>Block number of the round.</value>
		[DataMember(Name = "block")]
        public long Block { get; set; }

		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		/// <value>Amount in base units allocated to the miner in the round.</value>
		[DataMember(Name = "amount")]
        public long Amount { get; set; }
    }
}
