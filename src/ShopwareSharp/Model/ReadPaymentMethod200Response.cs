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
    /// ReadPaymentMethod200Response
    /// </summary>
    [DataContract(Name = "readPaymentMethod_200_response")]
    public partial class ReadPaymentMethod200Response : IEquatable<ReadPaymentMethod200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadPaymentMethod200Response" /> class.
        /// </summary>
        /// <param name="total">Total amount.</param>
        /// <param name="aggregations">aggregation result.</param>
        /// <param name="elements">elements.</param>
        public ReadPaymentMethod200Response(int total = default(int), Object aggregations = default(Object), List<PaymentMethod> elements = default(List<PaymentMethod>))
        {
            this.Total = total;
            this.Aggregations = aggregations;
            this.Elements = elements;
        }

        /// <summary>
        /// Total amount
        /// </summary>
        /// <value>Total amount</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// aggregation result
        /// </summary>
        /// <value>aggregation result</value>
        [DataMember(Name = "aggregations", EmitDefaultValue = false)]
        public Object Aggregations { get; set; }

        /// <summary>
        /// Gets or Sets Elements
        /// </summary>
        [DataMember(Name = "elements", EmitDefaultValue = false)]
        public List<PaymentMethod> Elements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadPaymentMethod200Response {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
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
            return this.Equals(input as ReadPaymentMethod200Response);
        }

        /// <summary>
        /// Returns true if ReadPaymentMethod200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadPaymentMethod200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadPaymentMethod200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Aggregations == input.Aggregations ||
                    (this.Aggregations != null &&
                    this.Aggregations.Equals(input.Aggregations))
                ) && 
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
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Aggregations != null)
                {
                    hashCode = (hashCode * 59) + this.Aggregations.GetHashCode();
                }
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