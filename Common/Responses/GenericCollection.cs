//----------------------------------------------------------------
// GenericCollection.cs
// Copyright SimplyCast 2014
// This projected is licensed under the terms of the MIT license.
//  (see the attached LICENSE.txt).
//----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace SimplyCast.Common.Responses
{
    /// <summary>
    /// This class is a helper for other collection classes, as they will often
    /// share the attributes below.
    /// </summary>
    abstract public class GenericCollection
    {
        /// <summary>
        /// Total count represents the total number of entities available on
        /// the resource before filtering.
        /// </summary>
        [JsonPropertyName("totalCount")]
        public int TotalCount
        {
            get;set;
        }

        /// <summary>
        /// Filter count represents the total number of entities available on
        /// the resource after any filtering queries (excluding offset/limit)
        /// are applied.
        /// </summary>
        [JsonPropertyName("filterCount")]
        public int FilterCount
        {
            get;set;
        }

        /// <summary>
        /// Response count is the number of entities returned in the response, 
        /// provided as a convenience.
        /// </summary>
        [JsonPropertyName("responseCount")]
        public int ResponseCount
        {
            get;set;
        }

        /// <summary>
        /// A collection of relation links. Used for paging; next and prev 
        /// links will contain the appropriate query parameters for retrieving
        /// the next and previous pages.
        /// </summary>
        [JsonPropertyName("links")]
        public RelationLink[] Links
        {
            get;set;
        }
    }
}
