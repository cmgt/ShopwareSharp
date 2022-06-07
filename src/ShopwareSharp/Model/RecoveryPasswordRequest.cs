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
    /// RecoveryPasswordRequest
    /// </summary>
    public partial class RecoveryPasswordRequest : IEquatable<RecoveryPasswordRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecoveryPasswordRequest" /> class.
        /// </summary>
        /// <param name="hash">Parameter from the link in the confirmation mail sent in Step 1 (required)</param>
        /// <param name="newPassword">New password for the customer (required)</param>
        /// <param name="newPasswordConfirm">Confirmation of the new password (required)</param>
        public RecoveryPasswordRequest(string hash, string newPassword, string newPasswordConfirm)
        {
            if (hash == null)
                throw new ArgumentNullException("hash is a required property for RecoveryPasswordRequest and cannot be null.");

            if (newPassword == null)
                throw new ArgumentNullException("newPassword is a required property for RecoveryPasswordRequest and cannot be null.");

            if (newPasswordConfirm == null)
                throw new ArgumentNullException("newPasswordConfirm is a required property for RecoveryPasswordRequest and cannot be null.");

            Hash = hash;
            NewPassword = newPassword;
            NewPasswordConfirm = newPasswordConfirm;
        }

        /// <summary>
        /// Parameter from the link in the confirmation mail sent in Step 1
        /// </summary>
        /// <value>Parameter from the link in the confirmation mail sent in Step 1</value>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// New password for the customer
        /// </summary>
        /// <value>New password for the customer</value>
        [JsonPropertyName("newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Confirmation of the new password
        /// </summary>
        /// <value>Confirmation of the new password</value>
        [JsonPropertyName("newPasswordConfirm")]
        public string NewPasswordConfirm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecoveryPasswordRequest {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  NewPasswordConfirm: ").Append(NewPasswordConfirm).Append("\n");
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
            return this.Equals(input as RecoveryPasswordRequest);
        }

        /// <summary>
        /// Returns true if RecoveryPasswordRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoveryPasswordRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoveryPasswordRequest? input)
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
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.NewPasswordConfirm == input.NewPasswordConfirm ||
                    (this.NewPasswordConfirm != null &&
                    this.NewPasswordConfirm.Equals(input.NewPasswordConfirm))
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
                if (this.NewPassword != null)
                {
                    hashCode = (hashCode * 59) + this.NewPassword.GetHashCode();
                }
                if (this.NewPasswordConfirm != null)
                {
                    hashCode = (hashCode * 59) + this.NewPasswordConfirm.GetHashCode();
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
