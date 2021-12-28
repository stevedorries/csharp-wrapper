using System.Text.Json.Serialization;

namespace SimplyCast.Models.SMS
{
    public class CampaignResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("from")]
        public string? From { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("time")]
        public DateTime Time { get; set; }

        [JsonPropertyName("contact")]
        public CampaignContact? Contact { get; set; }

        [JsonPropertyName("list")]
        public CampaignList? List { get; set; }

    }
}

