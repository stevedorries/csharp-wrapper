using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignSender
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

    }
}
