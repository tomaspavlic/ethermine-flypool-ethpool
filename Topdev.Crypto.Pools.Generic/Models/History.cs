using System;
using System.Runtime.Serialization;

namespace Topdev.Crypto.Pools.Generic.Models
{
    [DataContract]
    public class History
    {

        [DataMember(Name = "time")]
        private int TimeInternal { 
            set 
            {
                Time = DateTimeOffset.FromUnixTimeSeconds(value).DateTime;
            }
        }

        [IgnoreDataMember]
        public DateTime Time { get; private set; }
        [DataMember(Name = "reportedHashrate")]
        public long ReportedHashrate { get; set; }
        [DataMember(Name = "currentHashrate")]
        public long CurrentHashrate { get; set; }
        [DataMember(Name = "validShares")]
        public int ValidShares { get; set; }
        [DataMember(Name = "invalidShares")]
        public int InvalidShares { get; set; }
        [DataMember(Name = "staleShares")]
        public int StaleShares { get; set; }
        [DataMember(Name = "averageHashrate")]
        public long AverageHashrate { get; set; }
        [DataMember(Name = "activeWorkers")]
        public int ActiveWorkers { get; set; }
    }
}