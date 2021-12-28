using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignCollection : CollectionBase
    {
        [JsonPropertyName("campaigns")]
        public Campaign[] Campaigns { get; set; }

    }
}
