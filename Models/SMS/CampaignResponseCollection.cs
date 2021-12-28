using System.Text.Json.Serialization;

namespace SimplyCast.Models.SMS
{
    public class CampaignResponseCollection : CollectionBase
    {
        [JsonPropertyName("responses")]
        public CampaignResponse[] Responses { get; set; }

    }
}

