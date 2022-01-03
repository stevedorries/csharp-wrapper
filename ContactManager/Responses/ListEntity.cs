//----------------------------------------------------------------
// ListEntity.cs
// Copyright SimplyCast 2014
// This projected is licensed under the terms of the MIT license.
//  (see the attached LICENSE.txt).
//----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using SimplyCast.Common.Responses;

namespace SimplyCast.ContactManager.Responses
{
    /// <summary>
    /// This class contains a contact list entity representation and fully 
    /// supports XML serialization.
    /// </summary>
    public class ContactList : IObjectArrayPolymorphic
    {
        

        /// <summary>
        /// The ID of the contact list; can be used to directly access the 
        /// list resource.
        /// </summary>
        [JsonPropertyName("id")]
        public int ID
        {
            get; set;
        }

        /// <summary>
        /// The number of contacts that are in the list
        /// </summary>
        [JsonPropertyName("size")]
        public int Size
        {
            get; set;
        }

        /// <summary>
        /// The date and time that the list was created.
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created
        {
            get; set;
        }

        /// <summary>
        /// The date of last contact entry into the list.
        /// </summary>
        [JsonPropertyName("lastAdded")]
        public DateTime LastAdded
        {
            get; set;
        }

        /// <summary>
        /// The date of last contact deletion from the list.
        /// </summary>
        [JsonPropertyName("lastDeleted")]
        public DateTime LastDeleted
        {
            get; set;
        }

        /// <summary>
        /// The name of the list.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// A collection of relation links. Will contain a link to the contact list.
        /// </summary>
        [JsonPropertyName("links")]
        public RelationLink[] Links
        {
            get; set;
        }
    }
}