using System;
using System.Threading.Tasks;

namespace Topdev.Crypto.Pools.Generic.Models
{
    public class Miner
    {
        private readonly ApiWebClient _client;
        private readonly string _miner;

        public Miner(ApiWebClient client, string miner)
        {
            _client = client;
            _miner = miner;
        }

        public async Task<History[]> GetHistoryAsync() => await _client.GetDateAsync<History[]>($"/miner/{_miner}/history");

        public async Task<Payout[]> GetPayoutsAsync() => await _client.GetDateAsync<Payout[]>($"/miner/{_miner}/payouts");

        public async Task<Round[]> GetRoundsAsync() => await _client.GetDateAsync<Round[]>($"/miner/{_miner}/rounds");

        public async Task<Settings> GetSettingsAsync() => await _client.GetDateAsync<Settings>($"/miner/{_miner}/settings");

        public async Task<Statistics> GetStatisticsAsync() => await _client.GetDateAsync<Statistics>($"/miner/{_miner}/currentStats");
    }
}
