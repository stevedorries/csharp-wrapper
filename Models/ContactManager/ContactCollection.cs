
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class ContactCollection : CollectionBase
    {
        [JsonPropertyName("contacts")]
        public Contact[] Contacts { get; set; }
    }

}
