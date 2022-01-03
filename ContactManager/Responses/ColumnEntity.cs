//----------------------------------------------------------------
// ColumnEntity.cs
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
    /// This class represents a column entity representation and fully supports
    /// XML serialization. A column entity represents a column in the Contact 
    /// Manager and its properties. Columns exist and have values for all 
    /// contacts. It doesn't represent any values stored; the combination of a
    /// column and a value is a field (and can be retrieved from a contact).
    /// </summary>
    [XmlRoot(ElementName = "column")]
    public class ColumnEntity
    {
        #region Private Members
        private string id;
        private int userDefined;
        private int visible;
        private int editable;
        private string name;
        private string[] mergeTags;
        private RelationLink[] links;
        #endregion

        /// <summary>
        /// The unique internal identifier of the column. 
        /// </summary>
        [JsonPropertyName("id")]
        public string ID 
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// The data type of the column (string, date, etc).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type 
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
            get { return this.userDefined == 0 ? false : true; }
        }

        /// <summary>
        /// An accessor for the raw userDefined value. Used only for XML 
        /// serialization.
        /// </summary>
        [JsonPropertyName("userDefined")]
        public int UserDefined
        {
            get { return this.userDefined; }
            set { this.userDefined = value; }
        }

        /// <summary>
        /// A flag indicating if the column is visible in the user interface.
        /// </summary>
        public bool IsVisible
        {
            get { return this.visible == 0 ? false : true; }
        }

        /// <summary>
        /// An accessor for the raw visible value. Used only for XML
        /// serialization.
        /// </summary>
        [JsonPropertyName("visible")]
        public int Visible
        {
            get { return visible; }
            set { this.visible = value; }
        }

        /// <summary>
        /// A flag indicating if the column is editable.
        /// </summary>
        public bool IsEditable
        {
            get { return editable != 0; }
        }

        /// <summary>
        /// An accessor for the raw editable value. Used only for XML
        /// serialization.
        /// </summary>
        [JsonPropertyName("editable")]
        public int Editable
        {
            get { return editable; }
            set { this.editable = value; }
        }

        /// <summary>
        /// The name of the column (displayed in the user interface).
        /// </summary>
        [JsonPropertyName("name")]
        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// A collection of relation links containing at least a 
        /// self-reference.
        /// </summary>
        [JsonPropertyName("links")]       
        public RelationLink[] Links
        {
            get { return this.links; }
            set { this.links = value; }
        }

        /// <summary>
        /// An array of merge tags. Merge tags are used in application content
        /// to dynamically insert contact information at the time of send.
        /// </summary>
        [JsonPropertyName("mergeTags")]
        public string[] MergeTags
        {
            get { return this.mergeTags; }
            set { this.mergeTags = value; }
        }
    }
}
