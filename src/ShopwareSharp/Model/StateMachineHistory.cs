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
    /// Added since version: 6.0.0.0
    /// </summary>
    public partial class StateMachineHistory : IEquatable<StateMachineHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateMachineHistory" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="fromStateMachineState">fromStateMachineState</param>
        /// <param name="toStateMachineState">toStateMachineState</param>
        public StateMachineHistory(DateTime createdAt, string? id = default, DateTime? updatedAt = default, StateMachineState? fromStateMachineState = default, StateMachineState? toStateMachineState = default)
        {
            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for StateMachineHistory and cannot be null.");

            CreatedAt = createdAt;
            Id = id;
            UpdatedAt = updatedAt;
            FromStateMachineState = fromStateMachineState;
            ToStateMachineState = toStateMachineState;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets FromStateMachineState
        /// </summary>
        [JsonPropertyName("fromStateMachineState")]
        public StateMachineState? FromStateMachineState { get; set; }

        /// <summary>
        /// Gets or Sets ToStateMachineState
        /// </summary>
        [JsonPropertyName("toStateMachineState")]
        public StateMachineState? ToStateMachineState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StateMachineHistory {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FromStateMachineState: ").Append(FromStateMachineState).Append("\n");
            sb.Append("  ToStateMachineState: ").Append(ToStateMachineState).Append("\n");
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
            return this.Equals(input as StateMachineHistory);
        }

        /// <summary>
        /// Returns true if StateMachineHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of StateMachineHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateMachineHistory? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt 
                    
                    
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.FromStateMachineState == input.FromStateMachineState ||
                    (this.FromStateMachineState != null &&
                    this.FromStateMachineState.Equals(input.FromStateMachineState))
                ) && 
                (
                    this.ToStateMachineState == input.ToStateMachineState ||
                    (this.ToStateMachineState != null &&
                    this.ToStateMachineState.Equals(input.ToStateMachineState))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.FromStateMachineState != null)
                {
                    hashCode = (hashCode * 59) + this.FromStateMachineState.GetHashCode();
                }
                if (this.ToStateMachineState != null)
                {
                    hashCode = (hashCode * 59) + this.ToStateMachineState.GetHashCode();
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
