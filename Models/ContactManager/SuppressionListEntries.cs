
using System.Text.Json.Serialization;

namespace SimplyCast.Models.ContactManager
{
    public class SuppressionListEntries
    {
        /// <summary>
        /// The total number of entities in the collection.
        /// </summary>
        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// If a query was used in the request, will be the total number of 
        /// entities that match the filter query.
        /// </summary>
        [JsonPropertyName("filterCount")]
        public int FilterCount { get; set; }

        /// <summary>
        /// The number of entities returned in the response.
        /// </summary>
        [JsonPropertyName("responseCount")]
        public int ResponseCount { get; set; }

        /// <summary>
        /// A collection of suppression entry representations
        /// </summary>
        [JsonPropertyName("suppressionEntries")]
        public SuppressionListEntry[] SupressionEntries { get; set; }
    }

}
