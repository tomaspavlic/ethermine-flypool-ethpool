using System;
using System.Threading.Tasks;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Pool
    {
        private readonly ApiWebClient _apiClient;

        public Pool(ApiWebClient apiClient)
        {
            _apiClient = apiClient;
        }

		/// <summary>
		/// Basic pool stats
		/// </summary>
		public async Task<PoolInfo> GetInformationAsync() => await _apiClient.GetDataAsync<PoolInfo>("/poolStats");

		/// <summary>
		/// Array of the top 100 miners sorted by their current credit value.
		/// </summary>
		public async Task<Credit[]> GetCreditsAsync() => await _apiClient.GetDataAsync<Credit[]>("/credits");

		/// <summary>
		/// Array of server hashrate ordered by time ASC.
		/// </summary>
		public async Task<BlockHistory[]> GetBlocksHistoryAsync() => await _apiClient.GetDataAsync<BlockHistory[]>("/blocks/history");

        /// <summary>
        /// Network statistics.
        /// </summary>
        public async Task<NetworkStatistics> GetNetworkStatisticsAsync() => await _apiClient.GetDataAsync<NetworkStatistics>("/networkStats");

		/// <summary>
		/// Array of server hashrate ordered by time ASC.
		/// </summary>
		public async Task<ServerStatistics[]> GetServersStatisticsAsync() => await _apiClient.GetDataAsync<ServerStatistics[]>("/servers/history");
    }
}
