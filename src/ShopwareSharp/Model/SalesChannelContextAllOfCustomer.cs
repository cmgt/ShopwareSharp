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
    /// Information about the current customer - &#x60;null&#x60; if the customer is not logged in
    /// </summary>
    public partial class SalesChannelContextAllOfCustomer : IEquatable<SalesChannelContextAllOfCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelContextAllOfCustomer" /> class.
        /// </summary>
        /// <param name="groupId">groupId</param>
        /// <param name="defaultPaymentMethodId">defaultPaymentMethodId</param>
        /// <param name="salesChannelId">salesChannelId</param>
        /// <param name="languageId">languageId</param>
        /// <param name="lastPaymentMethodId">lastPaymentMethodId</param>
        /// <param name="defaultBillingAddressId">defaultBillingAddressId</param>
        /// <param name="defaultShippingAddressId">defaultShippingAddressId</param>
        /// <param name="customerNumber">customerNumber</param>
        /// <param name="salutationId">salutationId</param>
        /// <param name="firstName">firstName</param>
        /// <param name="lastName">lastName</param>
        /// <param name="company">company</param>
        /// <param name="password">password</param>
        /// <param name="email">email</param>
        /// <param name="title">title</param>
        /// <param name="affiliateCode">affiliateCode</param>
        /// <param name="campaignCode">campaignCode</param>
        /// <param name="active">active</param>
        /// <param name="doubleOptInRegistration">doubleOptInRegistration</param>
        /// <param name="doubleOptInEmailSentDate">doubleOptInEmailSentDate</param>
        /// <param name="doubleOptInConfirmDate">doubleOptInConfirmDate</param>
        /// <param name="hash">hash</param>
        /// <param name="guest">guest</param>
        /// <param name="firstLogin">firstLogin</param>
        /// <param name="lastLogin">lastLogin</param>
        /// <param name="newsletter">newsletter</param>
        /// <param name="birthday">birthday</param>
        /// <param name="lastOrderDate">lastOrderDate</param>
        /// <param name="orderCount">orderCount</param>
        /// <param name="legacyEncoder">legacyEncoder</param>
        /// <param name="legacyPassword">legacyPassword</param>
        /// <param name="autoIncrement">autoIncrement</param>
        /// <param name="remoteAddress">remoteAddress</param>
        public SalesChannelContextAllOfCustomer(string? groupId = default, string? defaultPaymentMethodId = default, string? salesChannelId = default, string? languageId = default, string? lastPaymentMethodId = default, string? defaultBillingAddressId = default, string? defaultShippingAddressId = default, string? customerNumber = default, string? salutationId = default, string? firstName = default, string? lastName = default, string? company = default, string? password = default, string? email = default, string? title = default, string? affiliateCode = default, string? campaignCode = default, bool? active = default, bool? doubleOptInRegistration = default, DateTime? doubleOptInEmailSentDate = default, DateTime? doubleOptInConfirmDate = default, string? hash = default, bool? guest = default, DateTime? firstLogin = default, DateTime? lastLogin = default, bool? newsletter = default, DateTime? birthday = default, DateTime? lastOrderDate = default, int? orderCount = default, string? legacyEncoder = default, string? legacyPassword = default, int? autoIncrement = default, string? remoteAddress = default)
        {
            GroupId = groupId;
            DefaultPaymentMethodId = defaultPaymentMethodId;
            SalesChannelId = salesChannelId;
            LanguageId = languageId;
            LastPaymentMethodId = lastPaymentMethodId;
            DefaultBillingAddressId = defaultBillingAddressId;
            DefaultShippingAddressId = defaultShippingAddressId;
            CustomerNumber = customerNumber;
            SalutationId = salutationId;
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            Password = password;
            Email = email;
            Title = title;
            AffiliateCode = affiliateCode;
            CampaignCode = campaignCode;
            Active = active;
            DoubleOptInRegistration = doubleOptInRegistration;
            DoubleOptInEmailSentDate = doubleOptInEmailSentDate;
            DoubleOptInConfirmDate = doubleOptInConfirmDate;
            Hash = hash;
            Guest = guest;
            FirstLogin = firstLogin;
            LastLogin = lastLogin;
            Newsletter = newsletter;
            Birthday = birthday;
            LastOrderDate = lastOrderDate;
            OrderCount = orderCount;
            LegacyEncoder = legacyEncoder;
            LegacyPassword = legacyPassword;
            AutoIncrement = autoIncrement;
            RemoteAddress = remoteAddress;
        }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [JsonPropertyName("groupId")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentMethodId
        /// </summary>
        [JsonPropertyName("defaultPaymentMethodId")]
        public string? DefaultPaymentMethodId { get; set; }

        /// <summary>
        /// Gets or Sets SalesChannelId
        /// </summary>
        [JsonPropertyName("salesChannelId")]
        public string? SalesChannelId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [JsonPropertyName("languageId")]
        public string? LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets LastPaymentMethodId
        /// </summary>
        [JsonPropertyName("lastPaymentMethodId")]
        public string? LastPaymentMethodId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultBillingAddressId
        /// </summary>
        [JsonPropertyName("defaultBillingAddressId")]
        public string? DefaultBillingAddressId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultShippingAddressId
        /// </summary>
        [JsonPropertyName("defaultShippingAddressId")]
        public string? DefaultShippingAddressId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerNumber
        /// </summary>
        [JsonPropertyName("customerNumber")]
        public string? CustomerNumber { get; set; }

        /// <summary>
        /// Gets or Sets SalutationId
        /// </summary>
        [JsonPropertyName("salutationId")]
        public string? SalutationId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateCode
        /// </summary>
        [JsonPropertyName("affiliateCode")]
        public string? AffiliateCode { get; set; }

        /// <summary>
        /// Gets or Sets CampaignCode
        /// </summary>
        [JsonPropertyName("campaignCode")]
        public string? CampaignCode { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets DoubleOptInRegistration
        /// </summary>
        [JsonPropertyName("doubleOptInRegistration")]
        public bool? DoubleOptInRegistration { get; set; }

        /// <summary>
        /// Gets or Sets DoubleOptInEmailSentDate
        /// </summary>
        [JsonPropertyName("doubleOptInEmailSentDate")]
        public DateTime? DoubleOptInEmailSentDate { get; set; }

        /// <summary>
        /// Gets or Sets DoubleOptInConfirmDate
        /// </summary>
        [JsonPropertyName("doubleOptInConfirmDate")]
        public DateTime? DoubleOptInConfirmDate { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Gets or Sets Guest
        /// </summary>
        [JsonPropertyName("guest")]
        public bool? Guest { get; set; }

        /// <summary>
        /// Gets or Sets FirstLogin
        /// </summary>
        [JsonPropertyName("firstLogin")]
        public DateTime? FirstLogin { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [JsonPropertyName("lastLogin")]
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// Gets or Sets Newsletter
        /// </summary>
        [JsonPropertyName("newsletter")]
        public bool? Newsletter { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [JsonPropertyName("birthday")]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or Sets LastOrderDate
        /// </summary>
        [JsonPropertyName("lastOrderDate")]
        public DateTime? LastOrderDate { get; set; }

        /// <summary>
        /// Gets or Sets OrderCount
        /// </summary>
        [JsonPropertyName("orderCount")]
        public int? OrderCount { get; set; }

        /// <summary>
        /// Gets or Sets LegacyEncoder
        /// </summary>
        [JsonPropertyName("legacyEncoder")]
        public string? LegacyEncoder { get; set; }

        /// <summary>
        /// Gets or Sets LegacyPassword
        /// </summary>
        [JsonPropertyName("legacyPassword")]
        public string? LegacyPassword { get; set; }

        /// <summary>
        /// Gets or Sets AutoIncrement
        /// </summary>
        [JsonPropertyName("autoIncrement")]
        public int? AutoIncrement { get; set; }

        /// <summary>
        /// Gets or Sets RemoteAddress
        /// </summary>
        [JsonPropertyName("remoteAddress")]
        public string? RemoteAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesChannelContextAllOfCustomer {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  DefaultPaymentMethodId: ").Append(DefaultPaymentMethodId).Append("\n");
            sb.Append("  SalesChannelId: ").Append(SalesChannelId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  LastPaymentMethodId: ").Append(LastPaymentMethodId).Append("\n");
            sb.Append("  DefaultBillingAddressId: ").Append(DefaultBillingAddressId).Append("\n");
            sb.Append("  DefaultShippingAddressId: ").Append(DefaultShippingAddressId).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
            sb.Append("  SalutationId: ").Append(SalutationId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  AffiliateCode: ").Append(AffiliateCode).Append("\n");
            sb.Append("  CampaignCode: ").Append(CampaignCode).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DoubleOptInRegistration: ").Append(DoubleOptInRegistration).Append("\n");
            sb.Append("  DoubleOptInEmailSentDate: ").Append(DoubleOptInEmailSentDate).Append("\n");
            sb.Append("  DoubleOptInConfirmDate: ").Append(DoubleOptInConfirmDate).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Guest: ").Append(Guest).Append("\n");
            sb.Append("  FirstLogin: ").Append(FirstLogin).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Newsletter: ").Append(Newsletter).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  LastOrderDate: ").Append(LastOrderDate).Append("\n");
            sb.Append("  OrderCount: ").Append(OrderCount).Append("\n");
            sb.Append("  LegacyEncoder: ").Append(LegacyEncoder).Append("\n");
            sb.Append("  LegacyPassword: ").Append(LegacyPassword).Append("\n");
            sb.Append("  AutoIncrement: ").Append(AutoIncrement).Append("\n");
            sb.Append("  RemoteAddress: ").Append(RemoteAddress).Append("\n");
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
            return this.Equals(input as SalesChannelContextAllOfCustomer);
        }

        /// <summary>
        /// Returns true if SalesChannelContextAllOfCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesChannelContextAllOfCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelContextAllOfCustomer? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.DefaultPaymentMethodId == input.DefaultPaymentMethodId ||
                    (this.DefaultPaymentMethodId != null &&
                    this.DefaultPaymentMethodId.Equals(input.DefaultPaymentMethodId))
                ) && 
                (
                    this.SalesChannelId == input.SalesChannelId ||
                    (this.SalesChannelId != null &&
                    this.SalesChannelId.Equals(input.SalesChannelId))
                ) && 
                (
                    this.LanguageId == input.LanguageId ||
                    (this.LanguageId != null &&
                    this.LanguageId.Equals(input.LanguageId))
                ) && 
                (
                    this.LastPaymentMethodId == input.LastPaymentMethodId ||
                    (this.LastPaymentMethodId != null &&
                    this.LastPaymentMethodId.Equals(input.LastPaymentMethodId))
                ) && 
                (
                    this.DefaultBillingAddressId == input.DefaultBillingAddressId ||
                    (this.DefaultBillingAddressId != null &&
                    this.DefaultBillingAddressId.Equals(input.DefaultBillingAddressId))
                ) && 
                (
                    this.DefaultShippingAddressId == input.DefaultShippingAddressId ||
                    (this.DefaultShippingAddressId != null &&
                    this.DefaultShippingAddressId.Equals(input.DefaultShippingAddressId))
                ) && 
                (
                    this.CustomerNumber == input.CustomerNumber ||
                    (this.CustomerNumber != null &&
                    this.CustomerNumber.Equals(input.CustomerNumber))
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
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.AffiliateCode == input.AffiliateCode ||
                    (this.AffiliateCode != null &&
                    this.AffiliateCode.Equals(input.AffiliateCode))
                ) && 
                (
                    this.CampaignCode == input.CampaignCode ||
                    (this.CampaignCode != null &&
                    this.CampaignCode.Equals(input.CampaignCode))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.DoubleOptInRegistration == input.DoubleOptInRegistration ||
                    this.DoubleOptInRegistration.Equals(input.DoubleOptInRegistration)
                ) && 
                (
                    this.DoubleOptInEmailSentDate == input.DoubleOptInEmailSentDate ||
                    (this.DoubleOptInEmailSentDate != null &&
                    this.DoubleOptInEmailSentDate.Equals(input.DoubleOptInEmailSentDate))
                ) && 
                (
                    this.DoubleOptInConfirmDate == input.DoubleOptInConfirmDate ||
                    (this.DoubleOptInConfirmDate != null &&
                    this.DoubleOptInConfirmDate.Equals(input.DoubleOptInConfirmDate))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Guest == input.Guest ||
                    this.Guest.Equals(input.Guest)
                ) && 
                (
                    this.FirstLogin == input.FirstLogin ||
                    (this.FirstLogin != null &&
                    this.FirstLogin.Equals(input.FirstLogin))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.Newsletter == input.Newsletter ||
                    this.Newsletter.Equals(input.Newsletter)
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.LastOrderDate == input.LastOrderDate ||
                    (this.LastOrderDate != null &&
                    this.LastOrderDate.Equals(input.LastOrderDate))
                ) && 
                (
                    this.OrderCount == input.OrderCount ||
                    this.OrderCount.Equals(input.OrderCount)
                ) && 
                (
                    this.LegacyEncoder == input.LegacyEncoder ||
                    (this.LegacyEncoder != null &&
                    this.LegacyEncoder.Equals(input.LegacyEncoder))
                ) && 
                (
                    this.LegacyPassword == input.LegacyPassword ||
                    (this.LegacyPassword != null &&
                    this.LegacyPassword.Equals(input.LegacyPassword))
                ) && 
                (
                    this.AutoIncrement == input.AutoIncrement ||
                    this.AutoIncrement.Equals(input.AutoIncrement)
                ) && 
                (
                    this.RemoteAddress == input.RemoteAddress ||
                    (this.RemoteAddress != null &&
                    this.RemoteAddress.Equals(input.RemoteAddress))
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
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.DefaultPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultPaymentMethodId.GetHashCode();
                }
                if (this.SalesChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannelId.GetHashCode();
                }
                if (this.LanguageId != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageId.GetHashCode();
                }
                if (this.LastPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.LastPaymentMethodId.GetHashCode();
                }
                if (this.DefaultBillingAddressId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultBillingAddressId.GetHashCode();
                }
                if (this.DefaultShippingAddressId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultShippingAddressId.GetHashCode();
                }
                if (this.CustomerNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerNumber.GetHashCode();
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
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.AffiliateCode != null)
                {
                    hashCode = (hashCode * 59) + this.AffiliateCode.GetHashCode();
                }
                if (this.CampaignCode != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.DoubleOptInRegistration.GetHashCode();
                if (this.DoubleOptInEmailSentDate != null)
                {
                    hashCode = (hashCode * 59) + this.DoubleOptInEmailSentDate.GetHashCode();
                }
                if (this.DoubleOptInConfirmDate != null)
                {
                    hashCode = (hashCode * 59) + this.DoubleOptInConfirmDate.GetHashCode();
                }
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Guest.GetHashCode();
                if (this.FirstLogin != null)
                {
                    hashCode = (hashCode * 59) + this.FirstLogin.GetHashCode();
                }
                if (this.LastLogin != null)
                {
                    hashCode = (hashCode * 59) + this.LastLogin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Newsletter.GetHashCode();
                if (this.Birthday != null)
                {
                    hashCode = (hashCode * 59) + this.Birthday.GetHashCode();
                }
                if (this.LastOrderDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastOrderDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrderCount.GetHashCode();
                if (this.LegacyEncoder != null)
                {
                    hashCode = (hashCode * 59) + this.LegacyEncoder.GetHashCode();
                }
                if (this.LegacyPassword != null)
                {
                    hashCode = (hashCode * 59) + this.LegacyPassword.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoIncrement.GetHashCode();
                if (this.RemoteAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RemoteAddress.GetHashCode();
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
