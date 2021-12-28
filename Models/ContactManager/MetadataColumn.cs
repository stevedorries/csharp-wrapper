
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class MetadataColumn
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("userDefined")]
        public int UserDefined { get; set; }

        [JsonPropertyName("visible")]
        public int Visible { get; set; }

        [JsonPropertyName("editable")]
        public int Editable { get; set; }

        [JsonPropertyName("valueColumn")]
        public string ValueColumn { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }
    }

}
