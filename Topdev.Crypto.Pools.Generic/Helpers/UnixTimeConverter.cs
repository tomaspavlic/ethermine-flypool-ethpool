using System;
using Newtonsoft.Json;

namespace Topdev.Crypto.Pools.Generic.Helpers
{
    public class UnixTimeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return DateTimeOffset.FromUnixTimeSeconds((long)reader.Value).DateTime;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var datetimeOffset = new DateTimeOffset((DateTime)value);
            serializer.Serialize(writer, datetimeOffset.ToUnixTimeSeconds());
        }
    }
}
