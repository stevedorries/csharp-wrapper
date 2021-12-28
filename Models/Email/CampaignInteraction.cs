using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignInteraction
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("time")]
        public DateTime Time { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("webLink")]
        public CampaignLink? WebLink { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("browser")]
        public string Browser { get; set; }

        [JsonPropertyName("contact")]
        public CampaignContact Contact { get; set; }

    }
}
