//----------------------------------------------------------------
// ContactEntity.cs
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
    /// This class represents a contact entity representation and fully 
    /// supports XML serialization. Field information (email, name, etc.)
    /// is accessible via the Fields property.
    /// </summary>
    [XmlRoot(ElementName = "contact")]
    public class ContactEntity
    {
        /// <summary>
        /// The internal identifier of the contact. Can be used to reference
        /// the contact directly.
        /// </summary>
        [JsonPropertyName("id")]
        public int ID
        {
            get; set;
        }

        /// <summary>
        /// The date that the contact entry was created.
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created
        {
            get; set;
        }

        /// <summary>
        /// The date that the contact entry was last modified.
        /// </summary>
        [JsonPropertyName("modified")]
        public DateTime Modified
        {
            get; set;
        }

        /// <summary>
        /// An array of field entities. Each field entity will contain
        /// 
        /// a single field entry (email, for example).
        /// </summary>
        [JsonPropertyName("fields")]
        public Dictionary<int, FieldEntity>? Fields
        {
            get; set;
        }

        /// <summary>
        /// An array of list entities. Each list entity represents a list that
        /// the contact appears on.
        /// </summary>
        [JsonPropertyName("lists")]
        [JsonConverter(typeof(DictionaryOrEmptyArrayConverter<ContactList>))]
        //[JsonIgnore()]
        public Dictionary<int, ContactList> Lists
        {
            get; set;
        }

        /// <summary>
        /// A collection of relation links. Will contain (at least) a link to
        /// the contact resource that this contact exists at.
        /// </summary>
        [JsonPropertyName("links")]
        public RelationLink[]? Links
        {
            get; set;
        }

        /// <summary>
        /// This method is provided as a helper for extracting a field by the 
        /// column name. Because column names aren't guaranteed to be unique, 
        /// this method returns a list of field entities (you'll probably only
        /// care about the first).
        /// </summary>
        /// <param name="name">The name of the field(s) to retrieve.</param>
        /// <returns>A list of the matching field entities. If you want the 
        /// value, access the Value property.</returns>
        public List<FieldEntity> GetFieldsByName(string name)
        {
            List<FieldEntity> returnFields = new();
            foreach (var kv in Fields)
            {
                if (kv.Value.Name == name)
                {
                    returnFields.Add(kv.Value);
                }
            }

            return returnFields;
        }
    }
}
