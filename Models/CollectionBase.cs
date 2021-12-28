using System.Text.Json.Serialization;

namespace SimplyCast.Models
{
    public abstract class CollectionBase
    {
        /// <summary>
        /// Total count represents the total number of entities available on
        /// the resource before filtering.
        /// </summary>
        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Filter count represents the total number of entities available on
        /// the resource after any filtering queries (excluding offset/limit)
        /// are applied.
        /// </summary>
        [JsonPropertyName("filterCount")]
        public int FilterCount { get; set; }

        /// <summary>
        /// Response count is the number of entities returned in the response, 
        /// provided as a convenience.
        /// </summary>
        [JsonPropertyName("responseCount")]
        public int ResponseCount { get; set; }

        /// <summary>
        /// A collection of relation links. Used for paging; next and prev 
        /// links will contain the appropriate query parameters for retrieving
        /// the next and previous pages.
        /// </summary>
        [JsonPropertyName("links")]
        public Link[]? Links { get; set; }
    }
}
