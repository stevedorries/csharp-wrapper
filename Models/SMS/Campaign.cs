using System.Text.Json.Serialization;

namespace SimplyCast.Models.SMS
{
    public class Campaign
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("totalPrice")]
        public float TotalPrice { get; set; }

        [JsonPropertyName("totalQueued")]
        public int TotalQueued { get; set; }

        [JsonPropertyName("totalSent")]
        public int TotalSent { get; set; }

        [JsonPropertyName("totalFailed")]
        public int TotalFailed { get; set; }

        [JsonPropertyName("sentTime")]
        public DateTime SentTime { get; set; }

        [JsonPropertyName("transactional")]
        public int Transactional { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("totalResponses")]
        public int TotalResponses { get; set; }

        [JsonPropertyName("lists")]
        public CampaignList[]? Lists { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }
    }
}

