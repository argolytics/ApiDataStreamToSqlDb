using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiDataStreamToSqlDb.JsonConverters
{
    public class StringWithBlankNoneNulledJsonConverter : JsonConverter<string?>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            if (string.IsNullOrEmpty(value))
                return null;
            if (value.Trim() == "Blank" || value.Trim() == "None")
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
