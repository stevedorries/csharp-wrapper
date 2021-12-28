using System.Text.Json.Serialization;

namespace SimplyCast.Models
{

    public class Link
    {
        [JsonPropertyName("rel")]
        public string? Rel { get; set; }

        [JsonPropertyName("href")]
        public string? Href { get; set; }
    }
}
