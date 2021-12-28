using System.Text.Json.Serialization;

namespace SimplyCast.Models.CrossMarketer
{
    public class Connection
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("contacts")]
        public Dictionary<string, Contact>? Contacts { get; set; }

        [JsonPropertyName("@link")]
        public Link Link { get; set; }
    }

}
