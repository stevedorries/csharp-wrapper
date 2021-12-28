using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignMessage
    {
        [JsonPropertyName("html")]
        public string HTML { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

    }
}
