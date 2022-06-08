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
    /// Information about the current sales channel
    /// </summary>
    [DataContract(Name = "SalesChannelContext_allOf_salesChannel")]
    public partial class SalesChannelContextAllOfSalesChannel : IEquatable<SalesChannelContextAllOfSalesChannel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelContextAllOfSalesChannel" /> class.
        /// </summary>
        /// <param name="typeId">typeId.</param>
        /// <param name="languageId">languageId.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="paymentMethodId">paymentMethodId.</param>
        /// <param name="shippingMethodId">shippingMethodId.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="navigationCategoryId">navigationCategoryId.</param>
        /// <param name="navigationCategoryDepth">navigationCategoryDepth.</param>
        /// <param name="footerCategoryId">footerCategoryId.</param>
        /// <param name="serviceCategoryId">serviceCategoryId.</param>
        /// <param name="name">name.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="active">active.</param>
        /// <param name="maintenance">maintenance.</param>
        /// <param name="maintenanceIpWhitelist">maintenanceIpWhitelist.</param>
        /// <param name="mailHeaderFooterId">mailHeaderFooterId.</param>
        /// <param name="customerGroupId">customerGroupId.</param>
        /// <param name="hreflangActive">hreflangActive.</param>
        /// <param name="hreflangDefaultDomainId">hreflangDefaultDomainId.</param>
        /// <param name="analyticsId">analyticsId.</param>
        public SalesChannelContextAllOfSalesChannel(string typeId = default(string), string languageId = default(string), string currencyId = default(string), string paymentMethodId = default(string), string shippingMethodId = default(string), string countryId = default(string), string navigationCategoryId = default(string), int navigationCategoryDepth = default(int), string footerCategoryId = default(string), string serviceCategoryId = default(string), string name = default(string), string shortName = default(string), string accessKey = default(string), bool active = default(bool), bool maintenance = default(bool), string maintenanceIpWhitelist = default(string), string mailHeaderFooterId = default(string), string customerGroupId = default(string), bool hreflangActive = default(bool), string hreflangDefaultDomainId = default(string), string analyticsId = default(string))
        {
            this.TypeId = typeId;
            this.LanguageId = languageId;
            this.CurrencyId = currencyId;
            this.PaymentMethodId = paymentMethodId;
            this.ShippingMethodId = shippingMethodId;
            this.CountryId = countryId;
            this.NavigationCategoryId = navigationCategoryId;
            this.NavigationCategoryDepth = navigationCategoryDepth;
            this.FooterCategoryId = footerCategoryId;
            this.ServiceCategoryId = serviceCategoryId;
            this.Name = name;
            this.ShortName = shortName;
            this.AccessKey = accessKey;
            this.Active = active;
            this.Maintenance = maintenance;
            this.MaintenanceIpWhitelist = maintenanceIpWhitelist;
            this.MailHeaderFooterId = mailHeaderFooterId;
            this.CustomerGroupId = customerGroupId;
            this.HreflangActive = hreflangActive;
            this.HreflangDefaultDomainId = hreflangDefaultDomainId;
            this.AnalyticsId = analyticsId;
        }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name = "typeId", EmitDefaultValue = false)]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "languageId", EmitDefaultValue = false)]
        public string LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "currencyId", EmitDefaultValue = false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethodId
        /// </summary>
        [DataMember(Name = "paymentMethodId", EmitDefaultValue = false)]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or Sets ShippingMethodId
        /// </summary>
        [DataMember(Name = "shippingMethodId", EmitDefaultValue = false)]
        public string ShippingMethodId { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "countryId", EmitDefaultValue = false)]
        public string CountryId { get; set; }

        /// <summary>
        /// Gets or Sets NavigationCategoryId
        /// </summary>
        [DataMember(Name = "navigationCategoryId", EmitDefaultValue = false)]
        public string NavigationCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets NavigationCategoryDepth
        /// </summary>
        [DataMember(Name = "navigationCategoryDepth", EmitDefaultValue = false)]
        public int NavigationCategoryDepth { get; set; }

        /// <summary>
        /// Gets or Sets FooterCategoryId
        /// </summary>
        [DataMember(Name = "footerCategoryId", EmitDefaultValue = false)]
        public string FooterCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceCategoryId
        /// </summary>
        [DataMember(Name = "serviceCategoryId", EmitDefaultValue = false)]
        public string ServiceCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name = "accessKey", EmitDefaultValue = false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Maintenance
        /// </summary>
        [DataMember(Name = "maintenance", EmitDefaultValue = true)]
        public bool Maintenance { get; set; }

        /// <summary>
        /// Gets or Sets MaintenanceIpWhitelist
        /// </summary>
        [DataMember(Name = "maintenanceIpWhitelist", EmitDefaultValue = false)]
        public string MaintenanceIpWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets MailHeaderFooterId
        /// </summary>
        [DataMember(Name = "mailHeaderFooterId", EmitDefaultValue = false)]
        public string MailHeaderFooterId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerGroupId
        /// </summary>
        [DataMember(Name = "customerGroupId", EmitDefaultValue = false)]
        public string CustomerGroupId { get; set; }

        /// <summary>
        /// Gets or Sets HreflangActive
        /// </summary>
        [DataMember(Name = "hreflangActive", EmitDefaultValue = true)]
        public bool HreflangActive { get; set; }

        /// <summary>
        /// Gets or Sets HreflangDefaultDomainId
        /// </summary>
        [DataMember(Name = "hreflangDefaultDomainId", EmitDefaultValue = false)]
        public string HreflangDefaultDomainId { get; set; }

        /// <summary>
        /// Gets or Sets AnalyticsId
        /// </summary>
        [DataMember(Name = "analyticsId", EmitDefaultValue = false)]
        public string AnalyticsId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesChannelContextAllOfSalesChannel {\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  ShippingMethodId: ").Append(ShippingMethodId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  NavigationCategoryId: ").Append(NavigationCategoryId).Append("\n");
            sb.Append("  NavigationCategoryDepth: ").Append(NavigationCategoryDepth).Append("\n");
            sb.Append("  FooterCategoryId: ").Append(FooterCategoryId).Append("\n");
            sb.Append("  ServiceCategoryId: ").Append(ServiceCategoryId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Maintenance: ").Append(Maintenance).Append("\n");
            sb.Append("  MaintenanceIpWhitelist: ").Append(MaintenanceIpWhitelist).Append("\n");
            sb.Append("  MailHeaderFooterId: ").Append(MailHeaderFooterId).Append("\n");
            sb.Append("  CustomerGroupId: ").Append(CustomerGroupId).Append("\n");
            sb.Append("  HreflangActive: ").Append(HreflangActive).Append("\n");
            sb.Append("  HreflangDefaultDomainId: ").Append(HreflangDefaultDomainId).Append("\n");
            sb.Append("  AnalyticsId: ").Append(AnalyticsId).Append("\n");
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
            return this.Equals(input as SalesChannelContextAllOfSalesChannel);
        }

        /// <summary>
        /// Returns true if SalesChannelContextAllOfSalesChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesChannelContextAllOfSalesChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelContextAllOfSalesChannel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
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
                    this.PaymentMethodId == input.PaymentMethodId ||
                    (this.PaymentMethodId != null &&
                    this.PaymentMethodId.Equals(input.PaymentMethodId))
                ) && 
                (
                    this.ShippingMethodId == input.ShippingMethodId ||
                    (this.ShippingMethodId != null &&
                    this.ShippingMethodId.Equals(input.ShippingMethodId))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.NavigationCategoryId == input.NavigationCategoryId ||
                    (this.NavigationCategoryId != null &&
                    this.NavigationCategoryId.Equals(input.NavigationCategoryId))
                ) && 
                (
                    this.NavigationCategoryDepth == input.NavigationCategoryDepth ||
                    this.NavigationCategoryDepth.Equals(input.NavigationCategoryDepth)
                ) && 
                (
                    this.FooterCategoryId == input.FooterCategoryId ||
                    (this.FooterCategoryId != null &&
                    this.FooterCategoryId.Equals(input.FooterCategoryId))
                ) && 
                (
                    this.ServiceCategoryId == input.ServiceCategoryId ||
                    (this.ServiceCategoryId != null &&
                    this.ServiceCategoryId.Equals(input.ServiceCategoryId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Maintenance == input.Maintenance ||
                    this.Maintenance.Equals(input.Maintenance)
                ) && 
                (
                    this.MaintenanceIpWhitelist == input.MaintenanceIpWhitelist ||
                    (this.MaintenanceIpWhitelist != null &&
                    this.MaintenanceIpWhitelist.Equals(input.MaintenanceIpWhitelist))
                ) && 
                (
                    this.MailHeaderFooterId == input.MailHeaderFooterId ||
                    (this.MailHeaderFooterId != null &&
                    this.MailHeaderFooterId.Equals(input.MailHeaderFooterId))
                ) && 
                (
                    this.CustomerGroupId == input.CustomerGroupId ||
                    (this.CustomerGroupId != null &&
                    this.CustomerGroupId.Equals(input.CustomerGroupId))
                ) && 
                (
                    this.HreflangActive == input.HreflangActive ||
                    this.HreflangActive.Equals(input.HreflangActive)
                ) && 
                (
                    this.HreflangDefaultDomainId == input.HreflangDefaultDomainId ||
                    (this.HreflangDefaultDomainId != null &&
                    this.HreflangDefaultDomainId.Equals(input.HreflangDefaultDomainId))
                ) && 
                (
                    this.AnalyticsId == input.AnalyticsId ||
                    (this.AnalyticsId != null &&
                    this.AnalyticsId.Equals(input.AnalyticsId))
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
                if (this.TypeId != null)
                {
                    hashCode = (hashCode * 59) + this.TypeId.GetHashCode();
                }
                if (this.LanguageId != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageId.GetHashCode();
                }
                if (this.CurrencyId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                }
                if (this.PaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodId.GetHashCode();
                }
                if (this.ShippingMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingMethodId.GetHashCode();
                }
                if (this.CountryId != null)
                {
                    hashCode = (hashCode * 59) + this.CountryId.GetHashCode();
                }
                if (this.NavigationCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.NavigationCategoryId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NavigationCategoryDepth.GetHashCode();
                if (this.FooterCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.FooterCategoryId.GetHashCode();
                }
                if (this.ServiceCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCategoryId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.AccessKey != null)
                {
                    hashCode = (hashCode * 59) + this.AccessKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.Maintenance.GetHashCode();
                if (this.MaintenanceIpWhitelist != null)
                {
                    hashCode = (hashCode * 59) + this.MaintenanceIpWhitelist.GetHashCode();
                }
                if (this.MailHeaderFooterId != null)
                {
                    hashCode = (hashCode * 59) + this.MailHeaderFooterId.GetHashCode();
                }
                if (this.CustomerGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerGroupId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HreflangActive.GetHashCode();
                if (this.HreflangDefaultDomainId != null)
                {
                    hashCode = (hashCode * 59) + this.HreflangDefaultDomainId.GetHashCode();
                }
                if (this.AnalyticsId != null)
                {
                    hashCode = (hashCode * 59) + this.AnalyticsId.GetHashCode();
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
