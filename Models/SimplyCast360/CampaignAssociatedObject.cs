using System.Text.Json.Serialization;
using SimplyCast.Models;


namespace SimplyCast.SimplyCast360.Models
{
    public class CampaignAssociatedObject
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }

    }
}