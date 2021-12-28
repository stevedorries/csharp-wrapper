using System.Text.Json.Serialization;

namespace SimplyCast.Models.CrossMarketer
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
