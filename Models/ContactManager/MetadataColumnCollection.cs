
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class MetadataColumnCollection : CollectionBase
    {
        [JsonPropertyName("metadataColumns")]
        public MetadataColumn[] MetadataColumns { get; set; }
    }

}
