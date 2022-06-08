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
    /// ReadSalutation200ResponseAllOf
    /// </summary>
    [DataContract(Name = "readSalutation_200_response_allOf")]
    public partial class ReadSalutation200ResponseAllOf : IEquatable<ReadSalutation200ResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadSalutation200ResponseAllOf" /> class.
        /// </summary>
        /// <param name="elements">elements.</param>
        public ReadSalutation200ResponseAllOf(List<Salutation> elements = default(List<Salutation>))
        {
            this._Elements = elements;
            if (this.Elements != null)
            {
                this._flagElements = true;
            }
        }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "elements", EmitDefaultValue = false)]
        public List<Salutation> Elements
        {
            get{ return _Elements;}
            set
            {
                _Elements = value;
                _flagElements = true;
            }
        }
        private List<Salutation> _Elements;
        private bool _flagElements;

        /// <summary>
        /// Returns false as Elements should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeElements()
        {
            return _flagElements;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadSalutation200ResponseAllOf {\n");
            sb.Append("  Elements: ").Append(Elements).Append("\n");
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
            return this.Equals(input as ReadSalutation200ResponseAllOf);
        }

        /// <summary>
        /// Returns true if ReadSalutation200ResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadSalutation200ResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadSalutation200ResponseAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Elements == input.Elements ||
                    this.Elements != null &&
                    input.Elements != null &&
                    this.Elements.SequenceEqual(input.Elements)
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
                if (this.Elements != null)
                {
                    hashCode = (hashCode * 59) + this.Elements.GetHashCode();
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
            yield break;
        }
    }

}
