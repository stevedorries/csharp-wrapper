
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class Note
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("contactId")]
        public int ContactId { get; set; }

        [JsonPropertyName("acountManagerId")]
        public int AccountManagerId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("modified")]
        public DateTime Modified { get; set; }

        [JsonPropertyName("links")]
        public Link[]? Links { get; set; }
    }

}
