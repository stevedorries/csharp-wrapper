
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class ContactList : IObjectArrayPolymorphic
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("lastAdded")]
        public DateTime LastAdded { get; set; }

        [JsonPropertyName("lastDeleted")]
        public DateTime LastDeleted { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("links")]
        public Link[]? Links { get; set; }
    }

}
