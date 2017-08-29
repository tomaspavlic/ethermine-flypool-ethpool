using System;
using System.Runtime.Serialization;

namespace Topdev.Crypto.Pools.Generic.Models
{
    [DataContract]
    public class Statistics
    {
		[DataMember(Name = "time")]
		private long TimeOnInternal
		{
			set
			{
				Time = DateTimeOffset.FromUnixTimeSeconds(value).DateTime;
			}
		}

        [DataMember(Name = "lastSeen")]
        private long LastSeenInternal
        {
            set
            {
                LastSeen = DateTimeOffset.FromUnixTimeSeconds(value).DateTime;
            }
        }


		[IgnoreDataMember]
        public DateTime Time { get; private set; }

		[IgnoreDataMember]
        public DateTime LastSeen { get; set; }

		[DataMember(Name = "reportedHashrate")]
		public decimal ReportedHashrate { get; set; }

		[DataMember(Name = "currentHashrate")]
		public decimal CurrenyHashrate { get; set; }

		[DataMember(Name = "validShares")]
		public int ValidShares { get; set; }

		[DataMember(Name = "invalidShares")]
		public int InvalidShares { get; set; }

		[DataMember(Name = "staleShares")]
		public int StaleShares { get; set; }

		[DataMember(Name = "averageHashrate")]
		public decimal AverageHashrate { get; set; }

		[DataMember(Name = "activeWorkers")]
		public int ActiveWorkers { get; set; }
    }
}
