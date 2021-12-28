using System.Text.Json.Serialization;

namespace SimplyCast.Models.SMS
{
    public class CampaignSendCollection : CollectionBase
    {
        [JsonPropertyName("sends")]
        public CampaignSend[] Sends { get; set; }

    }
}

