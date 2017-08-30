using System;
using System.Runtime.Serialization;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Payout
    {
		[DataMember(Name = "paidOn")]
		private int PaidOnInternal
		{
			set
			{
				PaidOn = DateTimeOffset.FromUnixTimeSeconds(value).DateTime;
			}
		}

		/// <summary>
		/// Gets the paid on.
		/// </summary>
		/// <value>Timestamp of the payout.</value>
		[IgnoreDataMember]
		public DateTime PaidOn { get; private set; }

		/// <summary>
		/// Gets or sets the start.
		/// </summary>
		/// <value>Start block of payout.</value>
		[DataMember(Name = "start")]
		public long Start { get; set; }

		/// <summary>
		/// Gets or sets the end.
		/// </summary>
		/// <value>End block of payout.</value>
		[DataMember(Name = "end")]
		public long End { get; set; }

		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		/// <value>Paid amount in base units.</value>
		[DataMember(Name = "amount")]
		public long Amount { get; set; }

		/// <summary>
		/// Gets or sets the transaction hash.
		/// </summary>
		/// <value>Hash of the payout transaction.</value>
		[DataMember(Name = "txHash")]
        public string TransactionHash { get; set; }
    }
}
