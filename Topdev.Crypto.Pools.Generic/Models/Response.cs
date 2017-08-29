using System;
namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Response<T>
    {
        public string Status
        {
            get;
            set;
        }

        public T Data
        {
            get;
            set;
        }
    }
}
