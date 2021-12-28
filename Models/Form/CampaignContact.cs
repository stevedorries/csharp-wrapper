using System.Text.Json.Serialization;

namespace SimplyCast.Models.Form
{
    public class CampaignContact
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }
    }
}