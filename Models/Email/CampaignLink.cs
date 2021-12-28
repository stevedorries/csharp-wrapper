using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignLink
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("url")]
        public string URL { get; set; }

    }
}
