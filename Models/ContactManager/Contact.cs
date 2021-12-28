
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class Contact
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("modified")]
        public DateTime Modified { get; set; }

        [JsonPropertyName("fields")]
        public Dictionary<int, Field> Fields { get; set; }

        [JsonPropertyName("lists")]
        [JsonConverter(typeof(DictionaryOrEmptyArrayConverter<ContactList>))]
        public Dictionary<int, ContactList> Lists { get; set; }

        [JsonPropertyName("links")]
        public Link[] Links { get; set; }
    }

}
