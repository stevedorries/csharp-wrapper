using System.Text.Json.Serialization;

namespace SimplyCast.Models.CrossMarketer
{
    public class Contact
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("processed")]
        public int Processed { get; set; }

        [JsonPropertyName("created")]
        public int Created { get; set; }

        [JsonPropertyName("row")]
        public int Row { get; set; }

        [JsonPropertyName("list")]
        public int List { get; set; }

        [JsonPropertyName("communication")]
        public string Communication { get; set; }
    }

}
