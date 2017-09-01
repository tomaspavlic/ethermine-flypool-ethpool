using System;
using Topdev.Crypto.Pools.Generic;
using Newtonsoft.Json;

namespace Topdev.Crypto.Pools.Generic.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var ethermine = new Ethermine();
            var miner = ethermine.GetMiner("97ca8a408e0f9315fa46c0d3d5e45956ac1ac7fe");

            // get miner's statistics synchronously
            var miningStatistics = miner.GetStatisticsAsync().Result;

            // convert statistics into json formatted string
            var json = JsonConvert.SerializeObject(miningStatistics, Formatting.Indented);

            // print statistics to console
            Console.WriteLine(json);
        }
    }
}
