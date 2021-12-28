using System.Text.Json.Serialization;

namespace SimplyCast.Models.Email
{
    public class Campaign
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("sentTime")]
        public DateTime SentTime { get; set; }

        [JsonPropertyName("totalQueued")]
        public int TotalQueued { get; set; }

        [JsonPropertyName("totalSent")]
        public int TotalSent { get; set; }

        [JsonPropertyName("totalFailed")]
        public int TotalFailed { get; set; }

        [JsonPropertyName("totalHardBounces")]
        public int TotalHardBounces { get; set; }

        [JsonPropertyName("totalSoftBounces")]
        public int TotalSoftBounces { get; set; }

        [JsonPropertyName("totalUnsubscribes")]
        public int TotalUnsubscribes { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("lists")]
        public CampaignList[]? Lists { get; set; }

        [JsonPropertyName("sender")]
        public CampaignSender Sender { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }
    }
}
