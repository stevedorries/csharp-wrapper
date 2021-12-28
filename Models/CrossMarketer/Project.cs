using System.Text.Json.Serialization;

namespace SimplyCast.Models.CrossMarketer
{
    public class Project
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("connections")]
        public Connection[] Connections { get; set; }
    }

}
