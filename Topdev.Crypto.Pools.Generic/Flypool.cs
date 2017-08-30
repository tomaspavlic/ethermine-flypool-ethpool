using System;
namespace Topdev.Crypto.Pools.Generic
{
    public class Flypool : GenericPoolApi
    {
        public Flypool() : base("https://api-zcash.flypool.org")
        {
        }
    }
}
