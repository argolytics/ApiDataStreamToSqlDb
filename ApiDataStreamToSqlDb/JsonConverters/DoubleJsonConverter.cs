using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiDataStreamToSqlDb.JsonConverters
{
    public class DoubleJsonConverter : JsonConverter<double>
    {
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = (string)reader.GetString();
            if (string.IsNullOrEmpty(value))
                return 0;
            string trimmedInput = value.Trim(new char[] { ' ', '$', '%' });
            if (Int64.TryParse(trimmedInput, out long result))
            {
                return result;
            }
            else
            {
                return 0;
            };
        }
        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
