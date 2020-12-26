using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace JtdCodegenE2E
{
    /// <summary>
    /// </summary>

    [JsonConverter(typeof(BarJsonConverter))]
    public class Bar
    {
        /// <summary>
        /// The underlying data being wrapped.
        /// </summary>
        public Bar0 Value { get; set; }
    }

    public class BarJsonConverter : JsonConverter<Bar>
    {
        public override Bar Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new Bar { Value = JsonSerializer.Deserialize<Bar0>(ref reader, options) };
        }

        public override void Write(Utf8JsonWriter writer, Bar value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize<Bar0>(writer, value.Value, options);
        }
    }
}