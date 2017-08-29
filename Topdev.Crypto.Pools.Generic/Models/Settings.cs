using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    [DataContract]
    public class Settings
    {
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "monitor"), JsonConverter(typeof(BoolConverter))]
        public bool Monitor { get; set; }
        [DataMember(Name = "minPayout")]
        public long MinimalPayout { get; set; }
    }
}
