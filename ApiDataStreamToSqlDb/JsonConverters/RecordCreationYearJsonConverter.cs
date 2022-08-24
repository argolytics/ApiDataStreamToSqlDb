using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiDataStreamToSqlDb.JsonConverters
{
    public class RecordCreationYearJsonConverter : JsonConverter<string?>
    {
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            if (string.IsNullOrEmpty(value))
                return null;
            try
            {
                string trimmedInput = value.Trim(new char[] { ' ' }).Substring(0, 4);
                if (int.TryParse(trimmedInput, out int result))
                {
                    return result.ToString();
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }
        public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
