using System;
using System.Threading.Tasks;
using Topdev.Crypto.Pools.Generic.Helpers;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Miner
    {
        private readonly ApiWebClient _client;
        private readonly string _miner;

        public string Address 
        {
            get
            {
                return _miner;
            }
        }

        public Miner(ApiWebClient client, string miner)
        {
            _client = client;
            _miner = miner;
        }

        public async Task<MinerHistory[]> GetHistoryAsync() => await _client.GetDataAsync<MinerHistory[]>($"/miner/{_miner}/history");

        public async Task<Payout[]> GetPayoutsAsync() => await _client.GetDataAsync<Payout[]>($"/miner/{_miner}/payouts");

        public async Task<Round[]> GetRoundsAsync() => await _client.GetDataAsync<Round[]>($"/miner/{_miner}/rounds");

        public async Task<Settings> GetSettingsAsync() => await _client.GetDataAsync<Settings>($"/miner/{_miner}/settings");

        public async Task<MinerStatistics> GetStatisticsAsync() => await _client.GetDataAsync<MinerStatistics>($"/miner/{_miner}/currentStats");

        public async Task<Worker[]> GetWorkersAsync() => await _client.GetDataAsync<Worker[]>($"/miner/{_miner}/workers");

        public async Task<WorkerHistory[]> GetWorkerHistoryAsync(string workerName) => await _client.GetDataAsync<WorkerHistory[]>($"/miner/{_miner}/worker/{workerName}/history");

        public async Task<WorkerStatistics> GetWorkerCurrentStatisticsAsync(string workerName) => await _client.GetDataAsync<WorkerStatistics>($"/miner/{_miner}/worker/{workerName}/currentStats");
    }
}
