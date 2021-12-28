using System.Text.Json.Serialization;

namespace SimplyCast.Models.SMS
{
    public class CampaignCollection : CollectionBase
    {
        [JsonPropertyName("campaigns")]
        public Campaign[] Campaigns { get; set; }

    }
}

