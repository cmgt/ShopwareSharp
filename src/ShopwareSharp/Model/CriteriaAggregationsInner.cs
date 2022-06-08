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
    /// CriteriaAggregationsInner
    /// </summary>
    [DataContract(Name = "Criteria_aggregations_inner")]
    public partial class CriteriaAggregationsInner : IEquatable<CriteriaAggregationsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CriteriaAggregationsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CriteriaAggregationsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CriteriaAggregationsInner" /> class.
        /// </summary>
        /// <param name="name">Give your aggregation an identifier, so you can find it easier (required).</param>
        /// <param name="type">The type of aggregation (required).</param>
        /// <param name="field">The field you want to aggregate over. (required).</param>
        public CriteriaAggregationsInner(string name = default(string), string type = default(string), string field = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CriteriaAggregationsInner and cannot be null");
            }
            this.Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for CriteriaAggregationsInner and cannot be null");
            }
            this.Type = type;
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for CriteriaAggregationsInner and cannot be null");
            }
            this.Field = field;
        }

        /// <summary>
        /// Give your aggregation an identifier, so you can find it easier
        /// </summary>
        /// <value>Give your aggregation an identifier, so you can find it easier</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of aggregation
        /// </summary>
        /// <value>The type of aggregation</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The field you want to aggregate over.
        /// </summary>
        /// <value>The field you want to aggregate over.</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CriteriaAggregationsInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(input as CriteriaAggregationsInner);
        }

        /// <summary>
        /// Returns true if CriteriaAggregationsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of CriteriaAggregationsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CriteriaAggregationsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
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
