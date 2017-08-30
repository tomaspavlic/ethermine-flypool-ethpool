using System;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class MinerHistory
    {
		/// <summary>
		/// Gets the time.
		/// </summary>
		/// <value>Timestamp of the statistic entry.</value>
		[JsonProperty(PropertyName = "time"), JsonConverter(typeof(UnixTimeConverter))]
        public DateTime Time { get; set; }

		/// <summary>
		/// Gets or sets the reported hashrate.
		/// </summary>
		/// <value>Reported hashrate of the miner in H/s.</value>
		[JsonProperty(PropertyName = "reportedHashrate")]
        public long ReportedHashrate { get; set; }

		/// <summary>
		/// Gets or sets the current hashrate.
		/// </summary>
		/// <value>Average hashrate of the miner in H/s during the last 24h.</value>
		[JsonProperty(PropertyName = "averageHashrate")]
		public long AverageHashrate { get; set; }

		/// <summary>
		/// Gets or sets the valid shares.
		/// </summary>
		/// <value>Current hashrate of the miner in H/s.</value>
		[JsonProperty(PropertyName = "currentHashrate")]
        public long CurrentHashrate { get; set; }

		/// <summary>
		/// Gets or sets the valid shares.
		/// </summary>
		/// <value>Valid shares submitted by the miner.</value>
		[JsonProperty(PropertyName = "validShares")]
        public int ValidShares { get; set; }

		/// <summary>
		/// Gets or sets the invalid shares.
		/// </summary>
		/// <value>Invalid shares submitted by the miner.</value>
		[JsonProperty(PropertyName = "invalidShares")]
        public int InvalidShares { get; set; }

		/// <summary>
		/// Gets or sets the stale shares.
		/// </summary>
		/// <value>Stale shares submitted by the miner.</value>
		[JsonProperty(PropertyName = "staleShares")]
        public int StaleShares { get; set; }

		/// <summary>
		/// Gets or sets the active workers.
		/// </summary>
		/// <value>Currently active workers of the miner.</value>
		[JsonProperty(PropertyName = "activeWorkers")]
        public int ActiveWorkers { get; set; }
    }
}