using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignTrackingLinkCollection : CollectionBase
    {
        [JsonPropertyName("trackingLinks")]
        public CampaignTrackingLink[] TrackingLinks { get; set; }

    }
}
