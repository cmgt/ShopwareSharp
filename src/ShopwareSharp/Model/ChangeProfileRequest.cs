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
    /// ChangeProfileRequest
    /// </summary>
    public partial class ChangeProfileRequest : IEquatable<ChangeProfileRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeProfileRequest" /> class.
        /// </summary>
        /// <param name="salutationId">Id of the salutation for the customer account. Fetch options using &#x60;salutation&#x60; endpoint. (required)</param>
        /// <param name="firstName">Customer first name. Value will be reused for shipping and billing address if not provided explicitly. (required)</param>
        /// <param name="lastName">Customer last name. Value will be reused for shipping and billing address if not provided explicitly. (required)</param>
        /// <param name="title">(Academic) title of the customer</param>
        /// <param name="company">Company of the customer. Only required when &#x60;accountType&#x60; is &#x60;business&#x60;.</param>
        /// <param name="birthdayDay">Birthday day</param>
        /// <param name="birthdayMonth">Birthday month</param>
        /// <param name="birthdayYear">Birthday year</param>
        public ChangeProfileRequest(string salutationId, string firstName, string lastName, string? title = default, string? company = default, int? birthdayDay = default, int? birthdayMonth = default, int? birthdayYear = default)
        {
            if (salutationId == null)
                throw new ArgumentNullException("salutationId is a required property for ChangeProfileRequest and cannot be null.");

            if (firstName == null)
                throw new ArgumentNullException("firstName is a required property for ChangeProfileRequest and cannot be null.");

            if (lastName == null)
                throw new ArgumentNullException("lastName is a required property for ChangeProfileRequest and cannot be null.");

            SalutationId = salutationId;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Company = company;
            BirthdayDay = birthdayDay;
            BirthdayMonth = birthdayMonth;
            BirthdayYear = birthdayYear;
        }

        /// <summary>
        /// Id of the salutation for the customer account. Fetch options using &#x60;salutation&#x60; endpoint.
        /// </summary>
        /// <value>Id of the salutation for the customer account. Fetch options using &#x60;salutation&#x60; endpoint.</value>
        [JsonPropertyName("salutationId")]
        public string SalutationId { get; set; }

        /// <summary>
        /// Customer first name. Value will be reused for shipping and billing address if not provided explicitly.
        /// </summary>
        /// <value>Customer first name. Value will be reused for shipping and billing address if not provided explicitly.</value>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name. Value will be reused for shipping and billing address if not provided explicitly.
        /// </summary>
        /// <value>Customer last name. Value will be reused for shipping and billing address if not provided explicitly.</value>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// (Academic) title of the customer
        /// </summary>
        /// <value>(Academic) title of the customer</value>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Company of the customer. Only required when &#x60;accountType&#x60; is &#x60;business&#x60;.
        /// </summary>
        /// <value>Company of the customer. Only required when &#x60;accountType&#x60; is &#x60;business&#x60;.</value>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Birthday day
        /// </summary>
        /// <value>Birthday day</value>
        [JsonPropertyName("birthdayDay")]
        public int? BirthdayDay { get; set; }

        /// <summary>
        /// Birthday month
        /// </summary>
        /// <value>Birthday month</value>
        [JsonPropertyName("birthdayMonth")]
        public int? BirthdayMonth { get; set; }

        /// <summary>
        /// Birthday year
        /// </summary>
        /// <value>Birthday year</value>
        [JsonPropertyName("birthdayYear")]
        public int? BirthdayYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChangeProfileRequest {\n");
            sb.Append("  SalutationId: ").Append(SalutationId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  BirthdayDay: ").Append(BirthdayDay).Append("\n");
            sb.Append("  BirthdayMonth: ").Append(BirthdayMonth).Append("\n");
            sb.Append("  BirthdayYear: ").Append(BirthdayYear).Append("\n");
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
            return this.Equals(input as ChangeProfileRequest);
        }

        /// <summary>
        /// Returns true if ChangeProfileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeProfileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeProfileRequest? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.BirthdayDay == input.BirthdayDay ||
                    this.BirthdayDay.Equals(input.BirthdayDay)
                ) && 
                (
                    this.BirthdayMonth == input.BirthdayMonth ||
                    this.BirthdayMonth.Equals(input.BirthdayMonth)
                ) && 
                (
                    this.BirthdayYear == input.BirthdayYear ||
                    this.BirthdayYear.Equals(input.BirthdayYear)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BirthdayDay.GetHashCode();
                hashCode = (hashCode * 59) + this.BirthdayMonth.GetHashCode();
                hashCode = (hashCode * 59) + this.BirthdayYear.GetHashCode();
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
