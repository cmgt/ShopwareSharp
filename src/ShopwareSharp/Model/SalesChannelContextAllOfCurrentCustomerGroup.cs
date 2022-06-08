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
    /// Customer group of the current user
    /// </summary>
    [DataContract(Name = "SalesChannelContext_allOf_currentCustomerGroup")]
    public partial class SalesChannelContextAllOfCurrentCustomerGroup : IEquatable<SalesChannelContextAllOfCurrentCustomerGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelContextAllOfCurrentCustomerGroup" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="displayGross">displayGross.</param>
        public SalesChannelContextAllOfCurrentCustomerGroup(string name = default(string), bool displayGross = default(bool))
        {
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._DisplayGross = displayGross;
            if (this.DisplayGross != null)
            {
                this._flagDisplayGross = true;
            }
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name
        {
            get{ return _Name;}
            set
            {
                _Name = value;
                _flagName = true;
            }
        }
        private string _Name;
        private bool _flagName;

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return _flagName;
        }
        /// <summary>
        /// Gets or Sets DisplayGross
        /// </summary>
        [DataMember(Name = "displayGross", EmitDefaultValue = true)]
        public bool DisplayGross
        {
            get{ return _DisplayGross;}
            set
            {
                _DisplayGross = value;
                _flagDisplayGross = true;
            }
        }
        private bool _DisplayGross;
        private bool _flagDisplayGross;

        /// <summary>
        /// Returns false as DisplayGross should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayGross()
        {
            return _flagDisplayGross;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesChannelContextAllOfCurrentCustomerGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayGross: ").Append(DisplayGross).Append("\n");
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
            return this.Equals(input as SalesChannelContextAllOfCurrentCustomerGroup);
        }

        /// <summary>
        /// Returns true if SalesChannelContextAllOfCurrentCustomerGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesChannelContextAllOfCurrentCustomerGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelContextAllOfCurrentCustomerGroup input)
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
                    this.DisplayGross == input.DisplayGross ||
                    this.DisplayGross.Equals(input.DisplayGross)
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
                hashCode = (hashCode * 59) + this.DisplayGross.GetHashCode();
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
