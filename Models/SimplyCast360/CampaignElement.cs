using System.Text.Json.Serialization;



namespace SimplyCast.SimplyCast360.Models
{
    public class CampaignElement : CampaignBase
    {
        [JsonPropertyName("associatedObject")]
        public CampaignAssociatedObject AssociatedObject { get; set; }
    }
}