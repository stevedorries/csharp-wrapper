using System.Text.Json.Serialization;



namespace SimplyCast.SimplyCast360.Models
{
    public abstract class CampaignBase
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("createdTime")]
        public DateTime Created { get; set; }

        [JsonPropertyName("modifiedTime")]
        public DateTime Modified { get; set; }
    }
}