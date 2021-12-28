using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignTrackingLink
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("trackingLink")]
        public string TrackingLink { get; set; }

    }
}
