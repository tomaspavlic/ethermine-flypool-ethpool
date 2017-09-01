using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Topdev.Crypto.Pools.Generic.Helpers;
using Topdev.Crypto.Pools.Generic.Models;

namespace Topdev.Crypto.Pools.Generic
{
    public class ApiWebClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;

        public ApiWebClient(string endpoint)
        {
            _endpoint = endpoint;
            _httpClient = new HttpClient();
        }

        public async Task<T> GetDataAsync<T>(string methodUrl)
        {
            var response = await _httpClient.GetStringAsync(_endpoint + methodUrl);

            if (response.Contains("NO DATA"))
                return (T)Activator.CreateInstance(typeof(T));

            var deserializedObject = await DeserializeObjectAsync<Response<T>>(response);

            return deserializedObject.Data;
        }

        private Task<T> DeserializeObjectAsync<T>(string value)
        {
            return Task.Factory.StartNew(() =>
            {
                return JsonConvert.DeserializeObject<T>(value);
            });
        }
    }
}
