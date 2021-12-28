using System.Text.Json.Serialization;

namespace SimplyCast.Models.CrossMarketer
{
    public class CampaignElement
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("createdTime")]
        public DateTime Created { get; set; }

        [JsonPropertyName("modifiedTime")]
        public DateTime Modified { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }

        [JsonPropertyName("associatedObject")]
        public int? AssociatedObject { get; set; }
    }

}