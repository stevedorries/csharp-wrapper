using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignInteractionCollection : CollectionBase
    {
        [JsonPropertyName("interactions")]
        public CampaignInteraction[] Interactions { get; set; }

    }
}
