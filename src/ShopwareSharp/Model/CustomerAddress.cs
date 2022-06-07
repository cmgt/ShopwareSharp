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
    public partial class CustomerAddress : IEquatable<CustomerAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddress" /> class.
        /// </summary>
        /// <param name="customerId">customerId (required)</param>
        /// <param name="countryId">countryId (required)</param>
        /// <param name="salutationId">salutationId (required)</param>
        /// <param name="firstName">firstName (required)</param>
        /// <param name="lastName">lastName (required)</param>
        /// <param name="zipcode">zipcode (required)</param>
        /// <param name="city">city (required)</param>
        /// <param name="street">street (required)</param>
        /// <param name="createdAt">createdAt (required)</param>
        /// <param name="id">id</param>
        /// <param name="countryStateId">countryStateId</param>
        /// <param name="company">company</param>
        /// <param name="department">department</param>
        /// <param name="title">title</param>
        /// <param name="phoneNumber">phoneNumber</param>
        /// <param name="additionalAddressLine1">additionalAddressLine1</param>
        /// <param name="additionalAddressLine2">additionalAddressLine2</param>
        /// <param name="customFields">customFields</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="country">country</param>
        /// <param name="countryState">countryState</param>
        /// <param name="salutation">salutation</param>
        public CustomerAddress(string customerId, string countryId, string salutationId, string firstName, string lastName, string zipcode, string city, string street, DateTime createdAt, string? id = default, string? countryStateId = default, string? company = default, string? department = default, string? title = default, string? phoneNumber = default, string? additionalAddressLine1 = default, string? additionalAddressLine2 = default, Object? customFields = default, DateTime? updatedAt = default, Country? country = default, CountryState? countryState = default, Salutation? salutation = default)
        {
            if (customerId == null)
                throw new ArgumentNullException("customerId is a required property for CustomerAddress and cannot be null.");

            if (countryId == null)
                throw new ArgumentNullException("countryId is a required property for CustomerAddress and cannot be null.");

            if (salutationId == null)
                throw new ArgumentNullException("salutationId is a required property for CustomerAddress and cannot be null.");

            if (firstName == null)
                throw new ArgumentNullException("firstName is a required property for CustomerAddress and cannot be null.");

            if (lastName == null)
                throw new ArgumentNullException("lastName is a required property for CustomerAddress and cannot be null.");

            if (zipcode == null)
                throw new ArgumentNullException("zipcode is a required property for CustomerAddress and cannot be null.");

            if (city == null)
                throw new ArgumentNullException("city is a required property for CustomerAddress and cannot be null.");

            if (street == null)
                throw new ArgumentNullException("street is a required property for CustomerAddress and cannot be null.");

            if (createdAt == null)
                throw new ArgumentNullException("createdAt is a required property for CustomerAddress and cannot be null.");

            CustomerId = customerId;
            CountryId = countryId;
            SalutationId = salutationId;
            FirstName = firstName;
            LastName = lastName;
            Zipcode = zipcode;
            City = city;
            Street = street;
            CreatedAt = createdAt;
            Id = id;
            CountryStateId = countryStateId;
            Company = company;
            Department = department;
            Title = title;
            PhoneNumber = phoneNumber;
            AdditionalAddressLine1 = additionalAddressLine1;
            AdditionalAddressLine2 = additionalAddressLine2;
            CustomFields = customFields;
            UpdatedAt = updatedAt;
            Country = country;
            CountryState = countryState;
            Salutation = salutation;
        }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [JsonPropertyName("customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [JsonPropertyName("countryId")]
        public string CountryId { get; set; }

        /// <summary>
        /// Gets or Sets SalutationId
        /// </summary>
        [JsonPropertyName("salutationId")]
        public string SalutationId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Zipcode
        /// </summary>
        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }

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
        /// Gets or Sets CountryStateId
        /// </summary>
        [JsonPropertyName("countryStateId")]
        public string? CountryStateId { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAddressLine1
        /// </summary>
        [JsonPropertyName("additionalAddressLine1")]
        public string? AdditionalAddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalAddressLine2
        /// </summary>
        [JsonPropertyName("additionalAddressLine2")]
        public string? AdditionalAddressLine2 { get; set; }

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
        /// Gets or Sets Country
        /// </summary>
        [JsonPropertyName("country")]
        public Country? Country { get; set; }

        /// <summary>
        /// Gets or Sets CountryState
        /// </summary>
        [JsonPropertyName("countryState")]
        public CountryState? CountryState { get; set; }

        /// <summary>
        /// Gets or Sets Salutation
        /// </summary>
        [JsonPropertyName("salutation")]
        public Salutation? Salutation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerAddress {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  SalutationId: ").Append(SalutationId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CountryStateId: ").Append(CountryStateId).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  AdditionalAddressLine1: ").Append(AdditionalAddressLine1).Append("\n");
            sb.Append("  AdditionalAddressLine2: ").Append(AdditionalAddressLine2).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryState: ").Append(CountryState).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
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
            return this.Equals(input as CustomerAddress);
        }

        /// <summary>
        /// Returns true if CustomerAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerAddress? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.SalutationId == input.SalutationId ||
                    (this.SalutationId != null &&
                    this.SalutationId.Equals(input.SalutationId))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Zipcode == input.Zipcode ||
                    (this.Zipcode != null &&
                    this.Zipcode.Equals(input.Zipcode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
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
                    this.CountryStateId == input.CountryStateId ||
                    (this.CountryStateId != null &&
                    this.CountryStateId.Equals(input.CountryStateId))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.AdditionalAddressLine1 == input.AdditionalAddressLine1 ||
                    (this.AdditionalAddressLine1 != null &&
                    this.AdditionalAddressLine1.Equals(input.AdditionalAddressLine1))
                ) && 
                (
                    this.AdditionalAddressLine2 == input.AdditionalAddressLine2 ||
                    (this.AdditionalAddressLine2 != null &&
                    this.AdditionalAddressLine2.Equals(input.AdditionalAddressLine2))
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
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryState == input.CountryState ||
                    (this.CountryState != null &&
                    this.CountryState.Equals(input.CountryState))
                ) && 
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
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
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.CountryId != null)
                {
                    hashCode = (hashCode * 59) + this.CountryId.GetHashCode();
                }
                if (this.SalutationId != null)
                {
                    hashCode = (hashCode * 59) + this.SalutationId.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Zipcode != null)
                {
                    hashCode = (hashCode * 59) + this.Zipcode.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CountryStateId != null)
                {
                    hashCode = (hashCode * 59) + this.CountryStateId.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Department != null)
                {
                    hashCode = (hashCode * 59) + this.Department.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.AdditionalAddressLine1 != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalAddressLine1.GetHashCode();
                }
                if (this.AdditionalAddressLine2 != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalAddressLine2.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.CountryState != null)
                {
                    hashCode = (hashCode * 59) + this.CountryState.GetHashCode();
                }
                if (this.Salutation != null)
                {
                    hashCode = (hashCode * 59) + this.Salutation.GetHashCode();
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
            // CustomerId (string) pattern
            Regex regexCustomerId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexCustomerId.Match(this.CustomerId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerId, must match a pattern of " + regexCustomerId, new [] { "CustomerId" });
            }

            // CountryId (string) pattern
            Regex regexCountryId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexCountryId.Match(this.CountryId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryId, must match a pattern of " + regexCountryId, new [] { "CountryId" });
            }

            // SalutationId (string) pattern
            Regex regexSalutationId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSalutationId.Match(this.SalutationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalutationId, must match a pattern of " + regexSalutationId, new [] { "SalutationId" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // CountryStateId (string) pattern
            Regex regexCountryStateId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexCountryStateId.Match(this.CountryStateId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryStateId, must match a pattern of " + regexCountryStateId, new [] { "CountryStateId" });
            }

            yield break;
        }
    }

}
