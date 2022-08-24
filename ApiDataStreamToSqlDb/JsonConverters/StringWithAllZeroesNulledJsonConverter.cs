using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiDataStreamToSqlDb.JsonConverters
{
    public class StringWithAllZeroesNulledJsonConverter : JsonConverter<string?>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            if (string.IsNullOrEmpty(value))
                return null;
            var input = value.All(v => v == value[0]);
            if (input)
            {
                return null;
            }
            return value.Trim();
        }

        public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}
