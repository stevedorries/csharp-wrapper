using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignSendCollection : CollectionBase
    {
        [JsonPropertyName("sends")]
        public CampaignSend[] Sends { get; set; }

    }
}
