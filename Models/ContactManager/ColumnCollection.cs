
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class ColumnCollection : CollectionBase
    {
        [JsonPropertyName("columns")]
        public Column[] Columns { get; set; }
    }

}
