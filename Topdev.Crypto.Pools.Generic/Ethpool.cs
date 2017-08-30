using System;
namespace Topdev.Crypto.Pools.Generic
{
    public class Ethpool : GenericPoolApi
    {
        public Ethpool() : base("http://api.ethpool.org")
        {
        }
    }
}
