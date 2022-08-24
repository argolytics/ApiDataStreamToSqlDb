using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiDataStreamToSqlDb.JsonConverters
{
    public class DateOnlyWithoutDayJsonConverter : JsonConverter<DateOnly?>
    {
        public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            if (string.IsNullOrEmpty(value))
                return null;
            if (DateOnly.TryParseExact(value, "yyyy.MM", null,
                System.Globalization.DateTimeStyles.None, out DateOnly result))
            {
                return result;
            }
            return null;
        }
        public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
