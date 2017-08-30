using System;
using System.Runtime.Serialization;

namespace Topdev.Crypto.Pools.Generic.Models
{
    [DataContract]
    public class MinerStatistics
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

		/// <summary>
		/// Gets the time.
		/// </summary>
		/// <value>Timestamp of the statistic entry.</value>
		[IgnoreDataMember]
        public DateTime Time { get; private set; }

		/// <summary>
		/// Gets the last senn.
		/// </summary>
		/// <value>Timestamp of when the miner was last seen by the pool.</value>
		[IgnoreDataMember]
        public DateTime LastSeen { get; set; }

		/// <summary>
		/// Gets or sets the reported hashrate.
		/// </summary>
		/// <value>Reported hashrate of the miner in H/s.</value>
		[DataMember(Name = "reportedHashrate")]
		public decimal ReportedHashrate { get; private set; }

		/// <summary>
		/// Gets or sets the average hashrate.
		/// </summary>
		/// <value>Average hashrate of the miner in H/s during the last 24h.</value>
		[DataMember(Name = "averageHashrate")]
		public decimal AverageHashrate { get; private set; }

		/// <summary>
		/// Gets or sets the curreny hashrate.
		/// </summary>
		/// <value>Current hashrate of the miner in H/s.</value>
		[DataMember(Name = "currentHashrate")]
		public decimal CurrenyHashrate { get; private set; }

		/// <summary>
		/// Gets or sets the valid shares.
		/// </summary>
		/// <value>Valid shares submitted by the miner.</value>
		[DataMember(Name = "validShares")]
		public int ValidShares { get; private set; }

		/// <summary>
		/// Gets or sets the invalid shares.
		/// </summary>
		/// <value>Invalid shares submitted by the miner.</value>
		[DataMember(Name = "invalidShares")]
		public int InvalidShares { get; private set; }

		/// <summary>
		/// Gets or sets the stale shares.
		/// </summary>
		/// <value>Stale shares submitted by the miner.</value>
		[DataMember(Name = "staleShares")]
		public int StaleShares { get; private set; }

		/// <summary>
		/// Gets or sets the active workers.
		/// </summary>
		/// <value>Currently active workers of the miner.</value>
		[DataMember(Name = "activeWorkers")]
		public int ActiveWorkers { get; set; }

		/// <summary>
		/// Gets or sets the unpaid.
		/// </summary>
		/// <value>Unpaid balance(in base units) of the miner.</value>
		[DataMember(Name = "unpaid")]
        public long? Unpaid { get; set; }

		/// <summary>
		/// Gets or sets the unconfirmed.
		/// </summary>
		/// <value>Unconfirmed balance(in base units) of the miner.</value>
		[DataMember(Name = "unconfirmed")]
        public long? Unconfirmed { get; set; }

		/// <summary>
		/// Gets or sets the coin per minimum.
		/// </summary>
		/// <value>Estimated number of coins(in base units) mined per minute(based on your average hashrate as well as the average block time and difficulty of the network over the last 24 hours.)</value>
		[DataMember(Name = "coinsPerMin")]
        public decimal CoinPerMin { get; set; }

		/// <summary>
		/// Gets or sets the USDP er minimum.
		/// </summary>
		/// <value>Estimated number of USD(in base units) mined per minute(based on your average hashrate as well as the average block time and difficulty of the network over the last 24 hours.)</value>
		[DataMember(Name = "usdPerMin")]
		public decimal USDPerMin { get; set; }

		/// <summary>
		/// Gets or sets the BTCP er minimum.
		/// </summary>
		/// <value>Estimated number of BTC(in base units) mined per minute(based on your average hashrate as well as the average block time and difficulty of the network over the last 24 hours.)</value>
		[DataMember(Name = "btcPerMin")]
		public decimal BTCPerMin { get; set; }
    }
}
