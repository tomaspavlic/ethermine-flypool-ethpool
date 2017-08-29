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

		[IgnoreDataMember]
		public DateTime PaidOn { get; private set; }
		[DataMember(Name = "start")]
		public long Start { get; set; }
		[DataMember(Name = "end")]
		public long End { get; set; }
		[DataMember(Name = "amount")]
		public long Amount { get; set; }
		[DataMember(Name = "txHash")]
        public string TransactionHash { get; set; }
    }
}
