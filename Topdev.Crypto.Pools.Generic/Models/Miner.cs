using System.Threading.Tasks;

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

        /// <summary>
        /// Array of the miner statistic entries sorted by time ASC.
        /// </summary>
        public async Task<MinerHistory[]> GetHistoryAsync() => await _client.GetDataAsync<MinerHistory[]>($"/miner/{_miner}/history");

        /// <summary>
        /// Array of payouts sorted by date DESC, limited to the last 100 entries.
        /// </summary>
        public async Task<Payout[]> GetPayoutsAsync() => await _client.GetDataAsync<Payout[]>($"/miner/{_miner}/payouts");

        /// <summary>
        /// Array of rounds sorted by block number DESC, limited to the last 1000 rounds.
        /// </summary>
        public async Task<Round[]> GetRoundsAsync() => await _client.GetDataAsync<Round[]>($"/miner/{_miner}/rounds");

        /// <summary>
        /// Miner settings
        /// </summary>
        public async Task<Settings> GetSettingsAsync() => await _client.GetDataAsync<Settings>($"/miner/{_miner}/settings");

        /// <summary>
        /// Miner Statistics.
        /// </summary>
        /// <returns>The statistics async.</returns>
        public async Task<MinerStatistics> GetStatisticsAsync() => await _client.GetDataAsync<MinerStatistics>($"/miner/{_miner}/currentStats");

        /// <summary>
        /// Array of the worker statistic entries sorted by name ASC.
        /// </summary>
        public async Task<Worker[]> GetWorkersAsync() => await _client.GetDataAsync<Worker[]>($"/miner/{_miner}/workers");

        /// <summary>
        /// Array of the worker statistic entries sorted by date ASC.
        /// </summary>
        /// <param name="workerName">Worker name.</param>
        public async Task<WorkerHistory[]> GetWorkerHistoryAsync(string workerName) => await _client.GetDataAsync<WorkerHistory[]>($"/miner/{_miner}/worker/{workerName}/history");

        /// <summary>
        /// Individual worker statistics.
        /// </summary>
        /// <param name="workerName">Worker name.</param>
        public async Task<WorkerStatistics> GetWorkerCurrentStatisticsAsync(string workerName) => await _client.GetDataAsync<WorkerStatistics>($"/miner/{_miner}/worker/{workerName}/currentStats");
    }
}
