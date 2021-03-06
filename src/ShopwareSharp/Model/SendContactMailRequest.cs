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
    /// SendContactMailRequest
    /// </summary>
    public partial class SendContactMailRequest : IEquatable<SendContactMailRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendContactMailRequest" /> class.
        /// </summary>
        /// <param name="salutationId">Identifier of the salutation. Use &#x60;/api/salutation&#x60; endpoint to fetch possible values. (required)</param>
        /// <param name="email">Email address (required)</param>
        /// <param name="subject">The subject of the contact form. (required)</param>
        /// <param name="comment">The message of the contact form (required)</param>
        /// <param name="firstName">Firstname. This field may be required depending on the system settings.</param>
        /// <param name="lastName">Lastname. This field may be required depending on the system settings.</param>
        /// <param name="phone">Phone. This field may be required depending on the system settings.</param>
        /// <param name="navigationId">Identifier of the navigation page. Can be used to override the configuration. Take a look at the settings of a category containing a concact form in the administration.</param>
        /// <param name="slotId">Identifier of the cms element</param>
        /// <param name="cmsPageType">Type of the content management page</param>
        /// <param name="entityName">Entity name for slot config</param>
        public SendContactMailRequest(string salutationId, string email, string subject, string comment, string? firstName = default, string? lastName = default, string? phone = default, string? navigationId = default, string? slotId = default, string? cmsPageType = default, string? entityName = default)
        {
            if (salutationId == null)
                throw new ArgumentNullException("salutationId is a required property for SendContactMailRequest and cannot be null.");

            if (email == null)
                throw new ArgumentNullException("email is a required property for SendContactMailRequest and cannot be null.");

            if (subject == null)
                throw new ArgumentNullException("subject is a required property for SendContactMailRequest and cannot be null.");

            if (comment == null)
                throw new ArgumentNullException("comment is a required property for SendContactMailRequest and cannot be null.");

            SalutationId = salutationId;
            Email = email;
            Subject = subject;
            Comment = comment;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            NavigationId = navigationId;
            SlotId = slotId;
            CmsPageType = cmsPageType;
            EntityName = entityName;
        }

        /// <summary>
        /// Identifier of the salutation. Use &#x60;/api/salutation&#x60; endpoint to fetch possible values.
        /// </summary>
        /// <value>Identifier of the salutation. Use &#x60;/api/salutation&#x60; endpoint to fetch possible values.</value>
        [JsonPropertyName("salutationId")]
        public string SalutationId { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        /// <value>Email address</value>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The subject of the contact form.
        /// </summary>
        /// <value>The subject of the contact form.</value>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// The message of the contact form
        /// </summary>
        /// <value>The message of the contact form</value>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Firstname. This field may be required depending on the system settings.
        /// </summary>
        /// <value>Firstname. This field may be required depending on the system settings.</value>
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Lastname. This field may be required depending on the system settings.
        /// </summary>
        /// <value>Lastname. This field may be required depending on the system settings.</value>
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Phone. This field may be required depending on the system settings.
        /// </summary>
        /// <value>Phone. This field may be required depending on the system settings.</value>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Identifier of the navigation page. Can be used to override the configuration. Take a look at the settings of a category containing a concact form in the administration.
        /// </summary>
        /// <value>Identifier of the navigation page. Can be used to override the configuration. Take a look at the settings of a category containing a concact form in the administration.</value>
        [JsonPropertyName("navigationId")]
        public string? NavigationId { get; set; }

        /// <summary>
        /// Identifier of the cms element
        /// </summary>
        /// <value>Identifier of the cms element</value>
        [JsonPropertyName("slotId")]
        public string? SlotId { get; set; }

        /// <summary>
        /// Type of the content management page
        /// </summary>
        /// <value>Type of the content management page</value>
        [JsonPropertyName("cmsPageType")]
        public string? CmsPageType { get; set; }

        /// <summary>
        /// Entity name for slot config
        /// </summary>
        /// <value>Entity name for slot config</value>
        [JsonPropertyName("entityName")]
        public string? EntityName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendContactMailRequest {\n");
            sb.Append("  SalutationId: ").Append(SalutationId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  NavigationId: ").Append(NavigationId).Append("\n");
            sb.Append("  SlotId: ").Append(SlotId).Append("\n");
            sb.Append("  CmsPageType: ").Append(CmsPageType).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
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
            return this.Equals(input as SendContactMailRequest);
        }

        /// <summary>
        /// Returns true if SendContactMailRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SendContactMailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendContactMailRequest? input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.NavigationId == input.NavigationId ||
                    (this.NavigationId != null &&
                    this.NavigationId.Equals(input.NavigationId))
                ) && 
                (
                    this.SlotId == input.SlotId ||
                    (this.SlotId != null &&
                    this.SlotId.Equals(input.SlotId))
                ) && 
                (
                    this.CmsPageType == input.CmsPageType ||
                    (this.CmsPageType != null &&
                    this.CmsPageType.Equals(input.CmsPageType))
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.NavigationId != null)
                {
                    hashCode = (hashCode * 59) + this.NavigationId.GetHashCode();
                }
                if (this.SlotId != null)
                {
                    hashCode = (hashCode * 59) + this.SlotId.GetHashCode();
                }
                if (this.CmsPageType != null)
                {
                    hashCode = (hashCode * 59) + this.CmsPageType.GetHashCode();
                }
                if (this.EntityName != null)
                {
                    hashCode = (hashCode * 59) + this.EntityName.GetHashCode();
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
