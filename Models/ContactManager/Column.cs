
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class Column
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("userDefined")]
        public int UserDefined { get; set; }

        [JsonPropertyName("visible")]
        public int Visible { get; set; }

        [JsonPropertyName("editable")]
        public int Editable { get; set; }

        [JsonPropertyName("extended")]
        public int Extended { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("mergeTags")]
        public string[] MergeTags { get; set; }

        [JsonPropertyName("links")]
        public Link[]? Links { get; set; }
    }

}
