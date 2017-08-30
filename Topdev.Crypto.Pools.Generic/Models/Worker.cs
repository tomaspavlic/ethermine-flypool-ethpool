using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Topdev.Crypto.Pools.Generic.Models
{
    [DataContract]
    public class Worker 
    {
        /// <summary>
        /// Gets or sets the worker name.
        /// </summary>
        /// <value>Worker name.</value>
        [DataMember(Name = "worker")]
        public string Name { get; private set; }

        [DataMember(Name = "time")]
        private long TimeInternal {
			set
			{
				Time = DateTimeOffset.FromUnixTimeSeconds(value).DateTime;
			}
        }

		/// <summary>
		/// Gets the time.
		/// </summary>
		/// <value>Timestamp of the statistic entry.</value>
		[IgnoreDataMember]
        public DateTime Time { get; private set; }

		/// <summary>
		/// Gets or sets the reported hashrate.
		/// </summary>
		/// <value>Reported hashrate of the worker in H/s.</value>
		[DataMember(Name = "reportedHashrate")]
		public decimal ReportedHashrate { get; private set; }

		/// <summary>
		/// Gets or sets the average hashrate.
		/// </summary>
		/// <value>Average hashrate of the worker in H/s during the last 24h.</value>
		[DataMember(Name = "averageHashrate")]
		public decimal AverageHashrate { get; private set; }

		/// <summary>
		/// Gets or sets the curreny hashrate.
		/// </summary>
		/// <value>Current hashrate of the worker in H/s.</value>
		[DataMember(Name = "currentHashrate")]
		public decimal CurrenyHashrate { get; private set; }

		/// <summary>
		/// Gets or sets the valid shares.
		/// </summary>
		/// <value>Valid shares submitted by the worker.</value>
		[DataMember(Name = "validShares")]
		public int ValidShares { get; private set; }

		/// <summary>
		/// Gets or sets the invalid shares.
		/// </summary>
		/// <value>Invalid shares submitted by the worker.</value>
		[DataMember(Name = "invalidShares")]
		public int InvalidShares { get; private set; }

		/// <summary>
		/// Gets or sets the stale shares.
		/// </summary>
		/// <value>Stale shares submitted by the worker.</value>
		[DataMember(Name = "staleShares")]
		public int StaleShares { get; private set; }
    }
}
