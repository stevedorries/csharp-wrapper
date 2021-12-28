using System.Text.Json.Serialization;

namespace SimplyCast.Models.Form
{
    public class SchemaField
    {
        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("dataType")]
        public string DataType { get; set; }
    }
}
