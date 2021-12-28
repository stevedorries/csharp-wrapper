
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class Field
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("userDefined")]
        public int UserDefined { get; set; }

        [JsonPropertyName("visible")]
        public int Visible { get; set; }

        [JsonPropertyName("editable")]
        public int Editable { get; set; }

        [JsonPropertyName("extended")]
        public int Extended { get; set; }
    }

}
