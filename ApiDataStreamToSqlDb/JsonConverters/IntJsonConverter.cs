using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiDataStreamToSqlDb.JsonConverters
{
    public class IntJsonConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            if (string.IsNullOrEmpty(value))
                return 0;
            string trimmedInput = value.Trim(new char[] { ' ', '$', '%' });
            if (decimal.TryParse(trimmedInput, out decimal decimalResult))
            {
                var result = (int)decimal.Truncate(decimalResult);
                return result;
            }
            return 0;
        }
        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
