// <auto-generated>
/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace ShopwareSharp.Model
{
    /// <summary>
    /// RegisterConfirmRequest
    /// </summary>
    public partial class RegisterConfirmRequest : IEquatable<RegisterConfirmRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterConfirmRequest" /> class.
        /// </summary>
        /// <param name="hash">Hash from the email received (required)</param>
        /// <param name="em">Email hash from the email received (required)</param>
        public RegisterConfirmRequest(string hash, string em)
        {
            if (hash == null)
                throw new ArgumentNullException("hash is a required property for RegisterConfirmRequest and cannot be null.");

            if (em == null)
                throw new ArgumentNullException("em is a required property for RegisterConfirmRequest and cannot be null.");

            Hash = hash;
            Em = em;
        }

        /// <summary>
        /// Hash from the email received
        /// </summary>
        /// <value>Hash from the email received</value>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Email hash from the email received
        /// </summary>
        /// <value>Email hash from the email received</value>
        [JsonPropertyName("em")]
        public string Em { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegisterConfirmRequest {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Em: ").Append(Em).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return this.Equals(input as RegisterConfirmRequest);
        }

        /// <summary>
        /// Returns true if RegisterConfirmRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterConfirmRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterConfirmRequest? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Em == input.Em ||
                    (this.Em != null &&
                    this.Em.Equals(input.Em))
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
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.Em != null)
                {
                    hashCode = (hashCode * 59) + this.Em.GetHashCode();
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
