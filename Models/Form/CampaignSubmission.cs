using System.Text.Json.Serialization;

namespace SimplyCast.Models.Form
{
    public class CampaignSubmission
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("submittedTime")]
        public DateTime Submitted { get; set; }

        [JsonPropertyName("contact")]
        public CampaignContact? Contact { get; set; }

        [JsonPropertyName("results")]
        public SubmissionResult[] Results { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }

    }
}
