using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiDataStreamToSqlDb.JsonConverters
{
    public class StringWithBlankNone0Blank0NulledJsonConverter : JsonConverter<string?>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            if (string.IsNullOrEmpty(value))
                return null;
            if (
                value.Trim() == "Blank" || 
                value.Trim() == "None (0)" || 
                value.Trim() == "Blank (0)" || 
                value.Trim() == "Blank (000)"
                )
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
