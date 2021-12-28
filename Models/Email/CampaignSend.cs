using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class CampaignSend
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("sentTime")]
        public DateTime SentTime { get; set; }

        [JsonPropertyName("delivered")]
        public int Delivered { get; set; }

        [JsonPropertyName("deliveredTime")]
        public DateTime DeliveredTime { get; set; }

        [JsonPropertyName("list")]
        public CampaignList? List { get; set; }

        [JsonPropertyName("contact")]
        public CampaignContact? Contact { get; set; }

        [JsonPropertyName("hardBounced")]
        public int HardBounced { get; set; }

        [JsonPropertyName("hardBouncedTime")]
        public DateTime HardBouncedTime { get; set; }

        [JsonPropertyName("softBounced")]
        public int SoftBounced { get; set; }

        [JsonPropertyName("softBouncedTime")]
        public DateTime SoftBouncedTime { get; set; }

        [JsonPropertyName("failed")]
        public int Failed { get; set; }

        [JsonPropertyName("unsubscribed")]
        public int Unsubscribed { get; set; }

        [JsonPropertyName("unsubscribedTime")]
        public DateTime UnsubscribedTime { get; set; }

    }
}
