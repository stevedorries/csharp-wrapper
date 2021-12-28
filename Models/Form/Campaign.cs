using System.Text.Json.Serialization;

namespace SimplyCast.Models.Form
{
    public class Campaign
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("published")]
        public int Published { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("optinRequired")]
        public int OptInRequired { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("createdTime")]
        public DateTime Created { get; set; }

        [JsonPropertyName("modifiedTime")]
        public DateTime Modified { get; set; }

        [JsonPropertyName("closingTime")]
        public DateTime? Closing { get; set; }

        [JsonPropertyName("messages")]
        public object? Messages { get; set; }

        [JsonPropertyName("totalSubmissions")]
        public int? TotalSubmissions { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }

        [JsonPropertyName("lists")]
        public CampaignList[]? Lists { get; set; }
    }
}
