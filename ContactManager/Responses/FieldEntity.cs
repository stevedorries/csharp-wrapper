//----------------------------------------------------------------
// FieldEntity.cs
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

namespace SimplyCast.ContactManager.Responses
{
    /// <summary>
    /// This class represents a field entity. A field entity represents a value
    /// on a column in the Contact Manager, storing information about a
    /// particular contact. For convenience, many of the column attributes are
    /// provided in the entity representation.
    /// </summary>    
    public class FieldEntity
    {
        /// <summary>
        /// The unique identifier of the column that the field is associated 
        /// with.
        /// </summary>
        [JsonPropertyName("id")]
        public string ID
        {
            get;
            set;
        }

        /// <summary>
        /// The value on the field (an email address or name, for example).
        /// </summary>
        [JsonPropertyName("value")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the column assoctiated with the field.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// A flag indicating if the column is user-defined or if it is a 
        /// system column. 
        /// </summary>
        public bool IsUserDefined
        {
            get { return UserDefined != 0; }
        }

        /// <summary>
        /// An accessor for the raw userDefined value. Used only for XML 
        /// serialization.
        /// </summary>
        [JsonPropertyName("userDefined")]
        public int UserDefined
        {
            get;
            set;
        }

        /// <summary>
        /// A flag indicating if the column is visible in the user interface.
        /// </summary>
        public bool IsVisible
        {
            get { return Visible != 0; }
        }

        /// <summary>
        /// An accessor for the raw visible value. Used only for XML
        /// serialization.
        /// </summary>
        [JsonPropertyName("visible")]
        public int Visible
        {
            get; set;
        }

        /// <summary>
        /// A flag indicating if the column is editable.
        /// </summary>
        public bool IsEditable
        {
            get { return Editable == 0 ? false : true; }
        }

        /// <summary>
        /// An accessor for the raw editable value. Used only for XML
        /// serialization.
        /// </summary>
        [JsonPropertyName("editable")]
        public int Editable
        {
            get;
            set;
        }

        /// <summary>
        /// A flag indicating that the field is considered an 'extended' field.
        /// Extended fields are accessible, but generally contain system 
        /// information that may not be used. Extended fields can be optionally
        /// disabled in requests as a means to reduce overhead.
        /// </summary>
        [JsonPropertyName("extended")]
        public int Extended
        {
            get;
            set;
        }

        /// <summary>
        /// A flag indicating that the field is considered an 'extended' field.
        /// Extended fields are accessible, but generally contain system 
        /// information that may not be used. Extended fields can be optionally
        /// disabled in requests as a means to reduce overhead.
        /// </summary>
        public bool IsExtended
        {
            get { return Extended != 0; }
        }
    }
}
