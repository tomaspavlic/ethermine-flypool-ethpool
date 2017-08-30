using System;
using System.Runtime.Serialization;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class WorkerStatistics : WorkerHistory
    {
		[DataMember(Name = "lastSeen")]
		private int LastSeenInternal
		{
			set
			{
                LastSeen = DateTimeOffset.FromUnixTimeSeconds(value).DateTime;
			}
		}

		/// <summary>
		/// Gets the last seen.
		/// </summary>
		/// <value>Timestamp of when the worker was last seen by the pool.</value>
		[IgnoreDataMember]
		public DateTime LastSeen { get; private set; }
    }
}
