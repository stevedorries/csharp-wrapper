
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{

    public class SuppressionListEntry
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("added")]
        public DateTime Added { get; set; }

        [JsonPropertyName("hardBounced")]
        public DateTime HardBounced { get; set; }
    }

}
