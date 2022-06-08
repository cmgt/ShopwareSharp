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
    [DataContract(Name = "SeoUrlTemplate")]
    public partial class SeoUrlTemplate : IEquatable<SeoUrlTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeoUrlTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeoUrlTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeoUrlTemplate" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="salesChannelId">salesChannelId.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="customFields">customFields.</param>
        public SeoUrlTemplate(string id = default(string), string salesChannelId = default(string), bool isValid = default(bool), Object customFields = default(Object))
        {
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._SalesChannelId = salesChannelId;
            if (this.SalesChannelId != null)
            {
                this._flagSalesChannelId = true;
            }
            this._IsValid = isValid;
            if (this.IsValid != null)
            {
                this._flagIsValid = true;
            }
            this._CustomFields = customFields;
            if (this.CustomFields != null)
            {
                this._flagCustomFields = true;
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
        /// Gets or Sets SalesChannelId
        /// </summary>
        [DataMember(Name = "salesChannelId", EmitDefaultValue = false)]
        public string SalesChannelId
        {
            get{ return _SalesChannelId;}
            set
            {
                _SalesChannelId = value;
                _flagSalesChannelId = true;
            }
        }
        private string _SalesChannelId;
        private bool _flagSalesChannelId;

        /// <summary>
        /// Returns false as SalesChannelId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSalesChannelId()
        {
            return _flagSalesChannelId;
        }
        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", EmitDefaultValue = true)]
        public bool IsValid
        {
            get{ return _IsValid;}
            set
            {
                _IsValid = value;
                _flagIsValid = true;
            }
        }
        private bool _IsValid;
        private bool _flagIsValid;

        /// <summary>
        /// Returns false as IsValid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsValid()
        {
            return _flagIsValid;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeoUrlTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SalesChannelId: ").Append(SalesChannelId).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as SeoUrlTemplate);
        }

        /// <summary>
        /// Returns true if SeoUrlTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of SeoUrlTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeoUrlTemplate input)
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
                    this.SalesChannelId == input.SalesChannelId ||
                    (this.SalesChannelId != null &&
                    this.SalesChannelId.Equals(input.SalesChannelId))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
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
                if (this.SalesChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannelId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsValid.GetHashCode();
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

            // SalesChannelId (string) pattern
            Regex regexSalesChannelId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSalesChannelId.Match(this.SalesChannelId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesChannelId, must match a pattern of " + regexSalesChannelId, new [] { "SalesChannelId" });
            }

            yield break;
        }
    }

}
