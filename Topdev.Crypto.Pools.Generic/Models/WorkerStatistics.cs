using System;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class WorkerStatistics : WorkerHistory
    {
        /// <summary>
        /// Gets the last seen.
        /// </summary>
        /// <value>Timestamp of when the worker was last seen by the pool.</value>
        [JsonProperty(PropertyName = "lastSeen"), JsonConverter(typeof(UnixTimeConverter))]
        public DateTime LastSeen { get; set; }
    }
}
