using System.Text.Json.Serialization;

namespace SimplyCast.Models.SMS
{
    public class CampaignList
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("count")]
        public int? Count { get; set; }

        [JsonPropertyName("queued")]
        public int? Queued { get; set; }

        [JsonPropertyName("sent")]
        public int? Sent { get; set; }

    }
}

