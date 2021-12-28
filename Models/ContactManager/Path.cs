
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class Path
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("fileCount")]
        public int FileCount { get; set; }

        [JsonPropertyName("directoryCount")]
        public int DirectoryCount { get; set; }

        [JsonPropertyName("path")]
        public Path[]? Contents { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("owner")]
        public User? Owner { get; set; }

        [JsonPropertyName("links")]
        public Link[]? Links { get; set; }
    }

}
