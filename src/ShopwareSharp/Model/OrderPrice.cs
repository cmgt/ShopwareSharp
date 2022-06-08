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
    /// OrderPrice
    /// </summary>
    [DataContract(Name = "Order_price")]
    public partial class OrderPrice : IEquatable<OrderPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPrice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderPrice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPrice" /> class.
        /// </summary>
        /// <param name="netPrice">netPrice (required).</param>
        /// <param name="totalPrice">totalPrice (required).</param>
        /// <param name="calculatedTaxes">calculatedTaxes.</param>
        /// <param name="taxRules">taxRules.</param>
        /// <param name="positionPrice">positionPrice (required).</param>
        /// <param name="rawTotal">rawTotal (required).</param>
        /// <param name="taxStatus">taxStatus (required).</param>
        public OrderPrice(float netPrice = default(float), float totalPrice = default(float), Object calculatedTaxes = default(Object), Object taxRules = default(Object), float positionPrice = default(float), float rawTotal = default(float), string taxStatus = default(string))
        {
            this.NetPrice = netPrice;
            this.TotalPrice = totalPrice;
            this.PositionPrice = positionPrice;
            this.RawTotal = rawTotal;
            // to ensure "taxStatus" is required (not null)
            if (taxStatus == null)
            {
                throw new ArgumentNullException("taxStatus is a required property for OrderPrice and cannot be null");
            }
            this.TaxStatus = taxStatus;
            this.CalculatedTaxes = calculatedTaxes;
            this.TaxRules = taxRules;
        }

        /// <summary>
        /// Gets or Sets NetPrice
        /// </summary>
        [DataMember(Name = "netPrice", IsRequired = true, EmitDefaultValue = false)]
        public float NetPrice { get; set; }

        /// <summary>
        /// Gets or Sets TotalPrice
        /// </summary>
        [DataMember(Name = "totalPrice", IsRequired = true, EmitDefaultValue = false)]
        public float TotalPrice { get; set; }

        /// <summary>
        /// Gets or Sets CalculatedTaxes
        /// </summary>
        [DataMember(Name = "calculatedTaxes", EmitDefaultValue = false)]
        public Object CalculatedTaxes { get; set; }

        /// <summary>
        /// Gets or Sets TaxRules
        /// </summary>
        [DataMember(Name = "taxRules", EmitDefaultValue = false)]
        public Object TaxRules { get; set; }

        /// <summary>
        /// Gets or Sets PositionPrice
        /// </summary>
        [DataMember(Name = "positionPrice", IsRequired = true, EmitDefaultValue = false)]
        public float PositionPrice { get; set; }

        /// <summary>
        /// Gets or Sets RawTotal
        /// </summary>
        [DataMember(Name = "rawTotal", IsRequired = true, EmitDefaultValue = false)]
        public float RawTotal { get; set; }

        /// <summary>
        /// Gets or Sets TaxStatus
        /// </summary>
        [DataMember(Name = "taxStatus", IsRequired = true, EmitDefaultValue = false)]
        public string TaxStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderPrice {\n");
            sb.Append("  NetPrice: ").Append(NetPrice).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  CalculatedTaxes: ").Append(CalculatedTaxes).Append("\n");
            sb.Append("  TaxRules: ").Append(TaxRules).Append("\n");
            sb.Append("  PositionPrice: ").Append(PositionPrice).Append("\n");
            sb.Append("  RawTotal: ").Append(RawTotal).Append("\n");
            sb.Append("  TaxStatus: ").Append(TaxStatus).Append("\n");
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
            return this.Equals(input as OrderPrice);
        }

        /// <summary>
        /// Returns true if OrderPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPrice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NetPrice == input.NetPrice ||
                    this.NetPrice.Equals(input.NetPrice)
                ) && 
                (
                    this.TotalPrice == input.TotalPrice ||
                    this.TotalPrice.Equals(input.TotalPrice)
                ) && 
                (
                    this.CalculatedTaxes == input.CalculatedTaxes ||
                    (this.CalculatedTaxes != null &&
                    this.CalculatedTaxes.Equals(input.CalculatedTaxes))
                ) && 
                (
                    this.TaxRules == input.TaxRules ||
                    (this.TaxRules != null &&
                    this.TaxRules.Equals(input.TaxRules))
                ) && 
                (
                    this.PositionPrice == input.PositionPrice ||
                    this.PositionPrice.Equals(input.PositionPrice)
                ) && 
                (
                    this.RawTotal == input.RawTotal ||
                    this.RawTotal.Equals(input.RawTotal)
                ) && 
                (
                    this.TaxStatus == input.TaxStatus ||
                    (this.TaxStatus != null &&
                    this.TaxStatus.Equals(input.TaxStatus))
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
                hashCode = (hashCode * 59) + this.NetPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPrice.GetHashCode();
                if (this.CalculatedTaxes != null)
                {
                    hashCode = (hashCode * 59) + this.CalculatedTaxes.GetHashCode();
                }
                if (this.TaxRules != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRules.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PositionPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.RawTotal.GetHashCode();
                if (this.TaxStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TaxStatus.GetHashCode();
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
