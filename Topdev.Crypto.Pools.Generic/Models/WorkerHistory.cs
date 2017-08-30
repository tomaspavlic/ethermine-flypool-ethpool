using System;
using System.Runtime.Serialization;

namespace Topdev.Crypto.Pools.Generic.Models
{
	[DataContract]
	public class WorkerHistory
	{

		[DataMember(Name = "time")]
		private int TimeInternal
		{
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
		public long ReportedHashrate { get; set; }

		/// <summary>
		/// Gets or sets the current hashrate.
		/// </summary>
		/// <value>Average hashrate of the worker in H/s during the last 24h.</value>
		[DataMember(Name = "averageHashrate")]
		public long AverageHashrate { get; set; }

		/// <summary>
		/// Gets or sets the valid shares.
		/// </summary>
		/// <value>Current hashrate of the worker in H/s.</value>
		[DataMember(Name = "currentHashrate")]
		public long CurrentHashrate { get; set; }

		/// <summary>
		/// Gets or sets the valid shares.
		/// </summary>
		/// <value>Valid shares submitted by the worker.</value>
		[DataMember(Name = "validShares")]
		public int ValidShares { get; set; }

		/// <summary>
		/// Gets or sets the invalid shares.
		/// </summary>
		/// <value>Invalid shares submitted by the worker.</value>
		[DataMember(Name = "invalidShares")]
		public int InvalidShares { get; set; }

		/// <summary>
		/// Gets or sets the stale shares.
		/// </summary>
		/// <value>Stale shares submitted by the worker.</value>
		[DataMember(Name = "staleShares")]
		public int StaleShares { get; set; }
		
	}
}
