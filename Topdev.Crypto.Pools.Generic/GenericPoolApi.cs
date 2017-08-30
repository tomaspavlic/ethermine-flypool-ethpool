using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Topdev.Crypto.Pools.Generic.Models;

namespace Topdev.Crypto.Pools.Generic
{
    public abstract class GenericPoolApi
    {
        private readonly ApiWebClient _apiClient;
        private readonly Pool _pool;

        protected GenericPoolApi(string endpoint)
        {
            _apiClient = new ApiWebClient(endpoint);
            _pool = new Pool(_apiClient);
        }

        public Pool Pool
        {
            get
            {
                return _pool;
            }
        }

        public Miner GetMiner(string miner)
        {
            return new Miner(_apiClient, miner);
        }
    }
}
