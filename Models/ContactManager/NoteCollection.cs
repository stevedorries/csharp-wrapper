
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class NoteCollection : CollectionBase
    {
        [JsonPropertyName("notes")]
        public Note[] Notes { get; set; }
    }

}
