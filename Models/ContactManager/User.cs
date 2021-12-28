
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
    }

}
