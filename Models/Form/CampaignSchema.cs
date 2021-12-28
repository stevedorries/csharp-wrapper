using System.Text.Json.Serialization;

namespace SimplyCast.Models.Form
{
    public class CampaignSchema
    {
        [JsonPropertyName("fields")]
        public SchemaField[] Fields { get; set; }

    }
}
