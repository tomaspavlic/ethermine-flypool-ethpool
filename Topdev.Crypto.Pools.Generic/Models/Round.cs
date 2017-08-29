using System;
using System.Runtime.Serialization;

namespace Topdev.Crypto.Pools.Generic.Models
{
    [DataContract]
    public class Round
    {
        [DataMember(Name = "block")]
        public long Block { get; set; }
        [DataMember(Name = "amount")]
        public long Amount { get; set; }
    }
}
