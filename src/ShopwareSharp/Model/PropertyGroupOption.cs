/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ShopwareSharp.Client.FileParameter;
using OpenAPIDateConverter = ShopwareSharp.Client.OpenAPIDateConverter;

namespace ShopwareSharp.Model
{
    /// <summary>
    /// Added since version: 6.0.0.0
    /// </summary>
    [DataContract(Name = "PropertyGroupOption")]
    public partial class PropertyGroupOption : IEquatable<PropertyGroupOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyGroupOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyGroupOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyGroupOption" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="groupId">groupId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="position">position.</param>
        /// <param name="colorHexCode">colorHexCode.</param>
        /// <param name="mediaId">mediaId.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="translated">translated.</param>
        /// <param name="media">media.</param>
        /// <param name="group">group.</param>
        public PropertyGroupOption(string id = default(string), string groupId = default(string), string name = default(string), long position = default(long), string colorHexCode = default(string), string mediaId = default(string), Object customFields = default(Object), Object translated = default(Object), Media media = default(Media), PropertyGroup group = default(PropertyGroup))
        {
            // to ensure "groupId" is required (not null)
            if (groupId == null)
            {
                throw new ArgumentNullException("groupId is a required property for PropertyGroupOption and cannot be null");
            }
            this._GroupId = groupId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PropertyGroupOption and cannot be null");
            }
            this._Name = name;
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._Position = position;
            if (this.Position != null)
            {
                this._flagPosition = true;
            }
            this._ColorHexCode = colorHexCode;
            if (this.ColorHexCode != null)
            {
                this._flagColorHexCode = true;
            }
            this._MediaId = mediaId;
            if (this.MediaId != null)
            {
                this._flagMediaId = true;
            }
            this._CustomFields = customFields;
            if (this.CustomFields != null)
            {
                this._flagCustomFields = true;
            }
            this._Translated = translated;
            if (this.Translated != null)
            {
                this._flagTranslated = true;
            }
            this._Media = media;
            if (this.Media != null)
            {
                this._flagMedia = true;
            }
            this._Group = group;
            if (this.Group != null)
            {
                this._flagGroup = true;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id
        {
            get{ return _Id;}
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private string _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", IsRequired = true, EmitDefaultValue = false)]
        public string GroupId
        {
            get{ return _GroupId;}
            set
            {
                _GroupId = value;
                _flagGroupId = true;
            }
        }
        private string _GroupId;
        private bool _flagGroupId;

        /// <summary>
        /// Returns false as GroupId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGroupId()
        {
            return _flagGroupId;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name
        {
            get{ return _Name;}
            set
            {
                _Name = value;
                _flagName = true;
            }
        }
        private string _Name;
        private bool _flagName;

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return _flagName;
        }
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public long Position
        {
            get{ return _Position;}
            set
            {
                _Position = value;
                _flagPosition = true;
            }
        }
        private long _Position;
        private bool _flagPosition;

        /// <summary>
        /// Returns false as Position should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePosition()
        {
            return _flagPosition;
        }
        /// <summary>
        /// Gets or Sets ColorHexCode
        /// </summary>
        [DataMember(Name = "colorHexCode", EmitDefaultValue = false)]
        public string ColorHexCode
        {
            get{ return _ColorHexCode;}
            set
            {
                _ColorHexCode = value;
                _flagColorHexCode = true;
            }
        }
        private string _ColorHexCode;
        private bool _flagColorHexCode;

        /// <summary>
        /// Returns false as ColorHexCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeColorHexCode()
        {
            return _flagColorHexCode;
        }
        /// <summary>
        /// Gets or Sets MediaId
        /// </summary>
        [DataMember(Name = "mediaId", EmitDefaultValue = false)]
        public string MediaId
        {
            get{ return _MediaId;}
            set
            {
                _MediaId = value;
                _flagMediaId = true;
            }
        }
        private string _MediaId;
        private bool _flagMediaId;

        /// <summary>
        /// Returns false as MediaId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMediaId()
        {
            return _flagMediaId;
        }
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "customFields", EmitDefaultValue = false)]
        public Object CustomFields
        {
            get{ return _CustomFields;}
            set
            {
                _CustomFields = value;
                _flagCustomFields = true;
            }
        }
        private Object _CustomFields;
        private bool _flagCustomFields;

        /// <summary>
        /// Returns false as CustomFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomFields()
        {
            return _flagCustomFields;
        }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Translated
        /// </summary>
        [DataMember(Name = "translated", EmitDefaultValue = false)]
        public Object Translated
        {
            get{ return _Translated;}
            set
            {
                _Translated = value;
                _flagTranslated = true;
            }
        }
        private Object _Translated;
        private bool _flagTranslated;

        /// <summary>
        /// Returns false as Translated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTranslated()
        {
            return _flagTranslated;
        }
        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public Media Media
        {
            get{ return _Media;}
            set
            {
                _Media = value;
                _flagMedia = true;
            }
        }
        private Media _Media;
        private bool _flagMedia;

        /// <summary>
        /// Returns false as Media should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMedia()
        {
            return _flagMedia;
        }
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public PropertyGroup Group
        {
            get{ return _Group;}
            set
            {
                _Group = value;
                _flagGroup = true;
            }
        }
        private PropertyGroup _Group;
        private bool _flagGroup;

        /// <summary>
        /// Returns false as Group should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGroup()
        {
            return _flagGroup;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyGroupOption {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ColorHexCode: ").Append(ColorHexCode).Append("\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PropertyGroupOption);
        }

        /// <summary>
        /// Returns true if PropertyGroupOption instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyGroupOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyGroupOption input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.ColorHexCode == input.ColorHexCode ||
                    (this.ColorHexCode != null &&
                    this.ColorHexCode.Equals(input.ColorHexCode))
                ) && 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Translated == input.Translated ||
                    (this.Translated != null &&
                    this.Translated.Equals(input.Translated))
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.ColorHexCode != null)
                {
                    hashCode = (hashCode * 59) + this.ColorHexCode.GetHashCode();
                }
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Translated != null)
                {
                    hashCode = (hashCode * 59) + this.Translated.GetHashCode();
                }
                if (this.Media != null)
                {
                    hashCode = (hashCode * 59) + this.Media.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // GroupId (string) pattern
            Regex regexGroupId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexGroupId.Match(this.GroupId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupId, must match a pattern of " + regexGroupId, new [] { "GroupId" });
            }

            // MediaId (string) pattern
            Regex regexMediaId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexMediaId.Match(this.MediaId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediaId, must match a pattern of " + regexMediaId, new [] { "MediaId" });
            }

            yield break;
        }
    }

}
