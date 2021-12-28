
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class SuppressionList
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }
    }

}
