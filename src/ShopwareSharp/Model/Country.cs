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
    public partial class Country : IEquatable<Country>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Country" /> class.
        /// </summary>
        /// <param name="name">name (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="iso">iso</param>
        /// <param name="position">position</param>
        /// <param name="taxFree">taxFree</param>
        /// <param name="active">active</param>
        /// <param name="shippingAvailable">shippingAvailable</param>
        /// <param name="iso3">iso3</param>
        /// <param name="displayStateInRegistration">displayStateInRegistration</param>
        /// <param name="forceStateInRegistration">forceStateInRegistration</param>
        /// <param name="companyTaxFree">companyTaxFree</param>
        /// <param name="checkVatIdPattern">checkVatIdPattern</param>
        /// <param name="vatIdPattern">vatIdPattern</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="translated">translated</param>
        /// <param name="states">states</param>
        public Country(string name, DateTime createdAt, string? id = default, string? iso = default, long? position = default, bool? taxFree = default, bool? active = default, bool? shippingAvailable = default, string? iso3 = default, bool? displayStateInRegistration = default, bool? forceStateInRegistration = default, bool? companyTaxFree = default, bool? checkVatIdPattern = default, string? vatIdPattern = default, Object? customFields = default, DateTime? updatedAt = default, Object? translated = default, CountryState? states = default)
        {
            if (name == null)
                throw new ArgumentNullException("name is a required property for Country and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for Country and cannot be null.");

            Name = name;
            CreatedAt = createdAt;
            Id = id;
            Iso = iso;
            Position = position;
            TaxFree = taxFree;
            Active = active;
            ShippingAvailable = shippingAvailable;
            Iso3 = iso3;
            DisplayStateInRegistration = displayStateInRegistration;
            ForceStateInRegistration = forceStateInRegistration;
            CompanyTaxFree = companyTaxFree;
            CheckVatIdPattern = checkVatIdPattern;
            VatIdPattern = vatIdPattern;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
            Translated = translated;
            States = states;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

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
        /// Gets or Sets Iso
        /// </summary>
        [JsonPropertyName("iso")]
        public string? Iso { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [JsonPropertyName("position")]
        public long? Position { get; set; }

        /// <summary>
        /// Gets or Sets TaxFree
        /// </summary>
        [JsonPropertyName("taxFree")]
        public bool? TaxFree { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAvailable
        /// </summary>
        [JsonPropertyName("shippingAvailable")]
        public bool? ShippingAvailable { get; set; }

        /// <summary>
        /// Gets or Sets Iso3
        /// </summary>
        [JsonPropertyName("iso3")]
        public string? Iso3 { get; set; }

        /// <summary>
        /// Gets or Sets DisplayStateInRegistration
        /// </summary>
        [JsonPropertyName("displayStateInRegistration")]
        public bool? DisplayStateInRegistration { get; set; }

        /// <summary>
        /// Gets or Sets ForceStateInRegistration
        /// </summary>
        [JsonPropertyName("forceStateInRegistration")]
        public bool? ForceStateInRegistration { get; set; }

        /// <summary>
        /// Gets or Sets CompanyTaxFree
        /// </summary>
        [JsonPropertyName("companyTaxFree")]
        public bool? CompanyTaxFree { get; set; }

        /// <summary>
        /// Gets or Sets CheckVatIdPattern
        /// </summary>
        [JsonPropertyName("checkVatIdPattern")]
        public bool? CheckVatIdPattern { get; set; }

        /// <summary>
        /// Gets or Sets VatIdPattern
        /// </summary>
        [JsonPropertyName("vatIdPattern")]
        public string? VatIdPattern { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [JsonPropertyName("customFields")]
        public Object? CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Translated
        /// </summary>
        [JsonPropertyName("translated")]
        public Object? Translated { get; set; }

        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [JsonPropertyName("states")]
        public CountryState? States { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Country {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Iso: ").Append(Iso).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  TaxFree: ").Append(TaxFree).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ShippingAvailable: ").Append(ShippingAvailable).Append("\n");
            sb.Append("  Iso3: ").Append(Iso3).Append("\n");
            sb.Append("  DisplayStateInRegistration: ").Append(DisplayStateInRegistration).Append("\n");
            sb.Append("  ForceStateInRegistration: ").Append(ForceStateInRegistration).Append("\n");
            sb.Append("  CompanyTaxFree: ").Append(CompanyTaxFree).Append("\n");
            sb.Append("  CheckVatIdPattern: ").Append(CheckVatIdPattern).Append("\n");
            sb.Append("  VatIdPattern: ").Append(VatIdPattern).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
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
            return this.Equals(input as Country);
        }

        /// <summary>
        /// Returns true if Country instances are equal
        /// </summary>
        /// <param name="input">Instance of Country to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Country? input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Iso == input.Iso ||
                    (this.Iso != null &&
                    this.Iso.Equals(input.Iso))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.TaxFree == input.TaxFree ||
                    this.TaxFree.Equals(input.TaxFree)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.ShippingAvailable == input.ShippingAvailable ||
                    this.ShippingAvailable.Equals(input.ShippingAvailable)
                ) && 
                (
                    this.Iso3 == input.Iso3 ||
                    (this.Iso3 != null &&
                    this.Iso3.Equals(input.Iso3))
                ) && 
                (
                    this.DisplayStateInRegistration == input.DisplayStateInRegistration ||
                    this.DisplayStateInRegistration.Equals(input.DisplayStateInRegistration)
                ) && 
                (
                    this.ForceStateInRegistration == input.ForceStateInRegistration ||
                    this.ForceStateInRegistration.Equals(input.ForceStateInRegistration)
                ) && 
                (
                    this.CompanyTaxFree == input.CompanyTaxFree ||
                    this.CompanyTaxFree.Equals(input.CompanyTaxFree)
                ) && 
                (
                    this.CheckVatIdPattern == input.CheckVatIdPattern ||
                    this.CheckVatIdPattern.Equals(input.CheckVatIdPattern)
                ) && 
                (
                    this.VatIdPattern == input.VatIdPattern ||
                    (this.VatIdPattern != null &&
                    this.VatIdPattern.Equals(input.VatIdPattern))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
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
                    this.States == input.States ||
                    (this.States != null &&
                    this.States.Equals(input.States))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Iso != null)
                {
                    hashCode = (hashCode * 59) + this.Iso.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                hashCode = (hashCode * 59) + this.TaxFree.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippingAvailable.GetHashCode();
                if (this.Iso3 != null)
                {
                    hashCode = (hashCode * 59) + this.Iso3.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayStateInRegistration.GetHashCode();
                hashCode = (hashCode * 59) + this.ForceStateInRegistration.GetHashCode();
                hashCode = (hashCode * 59) + this.CompanyTaxFree.GetHashCode();
                hashCode = (hashCode * 59) + this.CheckVatIdPattern.GetHashCode();
                if (this.VatIdPattern != null)
                {
                    hashCode = (hashCode * 59) + this.VatIdPattern.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Translated != null)
                {
                    hashCode = (hashCode * 59) + this.Translated.GetHashCode();
                }
                if (this.States != null)
                {
                    hashCode = (hashCode * 59) + this.States.GetHashCode();
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
