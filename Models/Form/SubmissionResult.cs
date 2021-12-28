using System.Text.Json.Serialization;

namespace SimplyCast.Models.Form
{
    public class SubmissionResult
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("dataType")]
        public string DataType { get; set; }

        [JsonPropertyName("value")]
        public object? Value { get; set; }

        [JsonPropertyName("error")]
        public string? Error { get; set; }

    }
}
