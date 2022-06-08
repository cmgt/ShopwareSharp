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
    [DataContract(Name = "Salutation")]
    public partial class Salutation : IEquatable<Salutation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Salutation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Salutation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Salutation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="salutationKey">salutationKey (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="letterName">letterName (required).</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="translated">translated.</param>
        public Salutation(string id = default(string), string salutationKey = default(string), string displayName = default(string), string letterName = default(string), Object customFields = default(Object), Object translated = default(Object))
        {
            // to ensure "salutationKey" is required (not null)
            if (salutationKey == null)
            {
                throw new ArgumentNullException("salutationKey is a required property for Salutation and cannot be null");
            }
            this._SalutationKey = salutationKey;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for Salutation and cannot be null");
            }
            this._DisplayName = displayName;
            // to ensure "letterName" is required (not null)
            if (letterName == null)
            {
                throw new ArgumentNullException("letterName is a required property for Salutation and cannot be null");
            }
            this._LetterName = letterName;
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
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
        /// Gets or Sets SalutationKey
        /// </summary>
        [DataMember(Name = "salutationKey", IsRequired = true, EmitDefaultValue = false)]
        public string SalutationKey
        {
            get{ return _SalutationKey;}
            set
            {
                _SalutationKey = value;
                _flagSalutationKey = true;
            }
        }
        private string _SalutationKey;
        private bool _flagSalutationKey;

        /// <summary>
        /// Returns false as SalutationKey should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSalutationKey()
        {
            return _flagSalutationKey;
        }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName
        {
            get{ return _DisplayName;}
            set
            {
                _DisplayName = value;
                _flagDisplayName = true;
            }
        }
        private string _DisplayName;
        private bool _flagDisplayName;

        /// <summary>
        /// Returns false as DisplayName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayName()
        {
            return _flagDisplayName;
        }
        /// <summary>
        /// Gets or Sets LetterName
        /// </summary>
        [DataMember(Name = "letterName", IsRequired = true, EmitDefaultValue = false)]
        public string LetterName
        {
            get{ return _LetterName;}
            set
            {
                _LetterName = value;
                _flagLetterName = true;
            }
        }
        private string _LetterName;
        private bool _flagLetterName;

        /// <summary>
        /// Returns false as LetterName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLetterName()
        {
            return _flagLetterName;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Salutation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SalutationKey: ").Append(SalutationKey).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  LetterName: ").Append(LetterName).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
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
            return this.Equals(input as Salutation);
        }

        /// <summary>
        /// Returns true if Salutation instances are equal
        /// </summary>
        /// <param name="input">Instance of Salutation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Salutation input)
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
                    this.SalutationKey == input.SalutationKey ||
                    (this.SalutationKey != null &&
                    this.SalutationKey.Equals(input.SalutationKey))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.LetterName == input.LetterName ||
                    (this.LetterName != null &&
                    this.LetterName.Equals(input.LetterName))
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
                if (this.SalutationKey != null)
                {
                    hashCode = (hashCode * 59) + this.SalutationKey.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.LetterName != null)
                {
                    hashCode = (hashCode * 59) + this.LetterName.GetHashCode();
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

            yield break;
        }
    }

}
