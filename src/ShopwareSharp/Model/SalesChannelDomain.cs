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
    /// Added since version: 6.0.0.0
    /// </summary>
    [DataContract(Name = "SalesChannelDomain")]
    public partial class SalesChannelDomain : IEquatable<SalesChannelDomain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelDomain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SalesChannelDomain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelDomain" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="url">url (required).</param>
        /// <param name="salesChannelId">salesChannelId (required).</param>
        /// <param name="languageId">languageId (required).</param>
        /// <param name="currencyId">currencyId (required).</param>
        /// <param name="snippetSetId">snippetSetId (required).</param>
        /// <param name="hreflangUseOnlyLocale">hreflangUseOnlyLocale.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="language">language.</param>
        /// <param name="currency">currency.</param>
        /// <param name="salesChannelDefaultHreflang">salesChannelDefaultHreflang.</param>
        public SalesChannelDomain(string id = default(string), string url = default(string), string salesChannelId = default(string), string languageId = default(string), string currencyId = default(string), string snippetSetId = default(string), bool hreflangUseOnlyLocale = default(bool), Object customFields = default(Object), Language language = default(Language), Currency currency = default(Currency), SalesChannel salesChannelDefaultHreflang = default(SalesChannel))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for SalesChannelDomain and cannot be null");
            }
            this.Url = url;
            // to ensure "salesChannelId" is required (not null)
            if (salesChannelId == null)
            {
                throw new ArgumentNullException("salesChannelId is a required property for SalesChannelDomain and cannot be null");
            }
            this.SalesChannelId = salesChannelId;
            // to ensure "languageId" is required (not null)
            if (languageId == null)
            {
                throw new ArgumentNullException("languageId is a required property for SalesChannelDomain and cannot be null");
            }
            this.LanguageId = languageId;
            // to ensure "currencyId" is required (not null)
            if (currencyId == null)
            {
                throw new ArgumentNullException("currencyId is a required property for SalesChannelDomain and cannot be null");
            }
            this.CurrencyId = currencyId;
            // to ensure "snippetSetId" is required (not null)
            if (snippetSetId == null)
            {
                throw new ArgumentNullException("snippetSetId is a required property for SalesChannelDomain and cannot be null");
            }
            this.SnippetSetId = snippetSetId;
            this.Id = id;
            this.HreflangUseOnlyLocale = hreflangUseOnlyLocale;
            this.CustomFields = customFields;
            this.Language = language;
            this.Currency = currency;
            this.SalesChannelDefaultHreflang = salesChannelDefaultHreflang;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets SalesChannelId
        /// </summary>
        [DataMember(Name = "salesChannelId", IsRequired = true, EmitDefaultValue = false)]
        public string SalesChannelId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "languageId", IsRequired = true, EmitDefaultValue = false)]
        public string LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "currencyId", IsRequired = true, EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets SnippetSetId
        /// </summary>
        [DataMember(Name = "snippetSetId", IsRequired = true, EmitDefaultValue = false)]
        public string SnippetSetId { get; set; }

        /// <summary>
        /// Gets or Sets HreflangUseOnlyLocale
        /// </summary>
        [DataMember(Name = "hreflangUseOnlyLocale", EmitDefaultValue = true)]
        public bool HreflangUseOnlyLocale { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "customFields", EmitDefaultValue = false)]
        public Object CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public Language Language { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency Currency { get; set; }

        /// <summary>
        /// Gets or Sets SalesChannelDefaultHreflang
        /// </summary>
        [DataMember(Name = "salesChannelDefaultHreflang", EmitDefaultValue = false)]
        public SalesChannel SalesChannelDefaultHreflang { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesChannelDomain {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SalesChannelId: ").Append(SalesChannelId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  SnippetSetId: ").Append(SnippetSetId).Append("\n");
            sb.Append("  HreflangUseOnlyLocale: ").Append(HreflangUseOnlyLocale).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SalesChannelDefaultHreflang: ").Append(SalesChannelDefaultHreflang).Append("\n");
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
            return this.Equals(input as SalesChannelDomain);
        }

        /// <summary>
        /// Returns true if SalesChannelDomain instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesChannelDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelDomain input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.SnippetSetId == input.SnippetSetId ||
                    (this.SnippetSetId != null &&
                    this.SnippetSetId.Equals(input.SnippetSetId))
                ) && 
                (
                    this.HreflangUseOnlyLocale == input.HreflangUseOnlyLocale ||
                    this.HreflangUseOnlyLocale.Equals(input.HreflangUseOnlyLocale)
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.SalesChannelDefaultHreflang == input.SalesChannelDefaultHreflang ||
                    (this.SalesChannelDefaultHreflang != null &&
                    this.SalesChannelDefaultHreflang.Equals(input.SalesChannelDefaultHreflang))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.SalesChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannelId.GetHashCode();
                }
                if (this.LanguageId != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageId.GetHashCode();
                }
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.SnippetSetId != null)
                {
                    hashCode = (hashCode * 59) + this.SnippetSetId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HreflangUseOnlyLocale.GetHashCode();
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.SalesChannelDefaultHreflang != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannelDefaultHreflang.GetHashCode();
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

            // SalesChannelId (string) pattern
            Regex regexSalesChannelId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSalesChannelId.Match(this.SalesChannelId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesChannelId, must match a pattern of " + regexSalesChannelId, new [] { "SalesChannelId" });
            }

            // LanguageId (string) pattern
            Regex regexLanguageId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexLanguageId.Match(this.LanguageId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageId, must match a pattern of " + regexLanguageId, new [] { "LanguageId" });
            }

            // CurrencyId (string) pattern
            Regex regexCurrencyId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexCurrencyId.Match(this.CurrencyId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrencyId, must match a pattern of " + regexCurrencyId, new [] { "CurrencyId" });
            }

            // SnippetSetId (string) pattern
            Regex regexSnippetSetId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexSnippetSetId.Match(this.SnippetSetId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SnippetSetId, must match a pattern of " + regexSnippetSetId, new [] { "SnippetSetId" });
            }

            yield break;
        }
    }

}
