using System;
namespace Topdev.Crypto.Pools.Generic
{
    public class Ethermine : GenericPoolApi
    {
        public Ethermine() : base("https://api.ethermine.org")
        {
        }
    }
}
