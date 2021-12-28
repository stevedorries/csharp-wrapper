using System.Text.Json.Serialization;

namespace SimplyCast.Models.SMS
{
    public class CampaignSend
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("queued")]
        public int Queued { get; set; }

        [JsonPropertyName("sent")]
        public int Sent { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("price")]
        public float Price { get; set; }

        [JsonPropertyName("charged")]
        public int Charged { get; set; }

        [JsonPropertyName("from")]
        public string? From { get; set; }

        [JsonPropertyName("queuedTime")]
        public DateTime QueuedTime { get; set; }

        [JsonPropertyName("sentTime")]
        public DateTime SentTime { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("list")]
        public CampaignList? List { get; set; }

        [JsonPropertyName("contact")]
        public CampaignContact? Contact { get; set; }

    }
}

