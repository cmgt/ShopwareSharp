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
    /// Currency associated with the current user
    /// </summary>
    [DataContract(Name = "SalesChannelContext_allOf_currency")]
    public partial class SalesChannelContextAllOfCurrency : IEquatable<SalesChannelContextAllOfCurrency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesChannelContextAllOfCurrency" /> class.
        /// </summary>
        /// <param name="isoCode">isoCode.</param>
        /// <param name="factor">factor.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="name">name.</param>
        /// <param name="position">position.</param>
        /// <param name="decimalPrecision">decimalPrecision.</param>
        /// <param name="isSystemDefault">isSystemDefault.</param>
        public SalesChannelContextAllOfCurrency(string isoCode = default(string), int factor = default(int), string symbol = default(string), string shortName = default(string), string name = default(string), int position = default(int), int decimalPrecision = default(int), bool isSystemDefault = default(bool))
        {
            this._IsoCode = isoCode;
            if (this.IsoCode != null)
            {
                this._flagIsoCode = true;
            }
            this._Factor = factor;
            if (this.Factor != null)
            {
                this._flagFactor = true;
            }
            this._Symbol = symbol;
            if (this.Symbol != null)
            {
                this._flagSymbol = true;
            }
            this._ShortName = shortName;
            if (this.ShortName != null)
            {
                this._flagShortName = true;
            }
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._Position = position;
            if (this.Position != null)
            {
                this._flagPosition = true;
            }
            this._DecimalPrecision = decimalPrecision;
            if (this.DecimalPrecision != null)
            {
                this._flagDecimalPrecision = true;
            }
            this._IsSystemDefault = isSystemDefault;
            if (this.IsSystemDefault != null)
            {
                this._flagIsSystemDefault = true;
            }
        }

        /// <summary>
        /// Gets or Sets IsoCode
        /// </summary>
        [DataMember(Name = "isoCode", EmitDefaultValue = false)]
        public string IsoCode
        {
            get{ return _IsoCode;}
            set
            {
                _IsoCode = value;
                _flagIsoCode = true;
            }
        }
        private string _IsoCode;
        private bool _flagIsoCode;

        /// <summary>
        /// Returns false as IsoCode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsoCode()
        {
            return _flagIsoCode;
        }
        /// <summary>
        /// Gets or Sets Factor
        /// </summary>
        [DataMember(Name = "factor", EmitDefaultValue = false)]
        public int Factor
        {
            get{ return _Factor;}
            set
            {
                _Factor = value;
                _flagFactor = true;
            }
        }
        private int _Factor;
        private bool _flagFactor;

        /// <summary>
        /// Returns false as Factor should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFactor()
        {
            return _flagFactor;
        }
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = false)]
        public string Symbol
        {
            get{ return _Symbol;}
            set
            {
                _Symbol = value;
                _flagSymbol = true;
            }
        }
        private string _Symbol;
        private bool _flagSymbol;

        /// <summary>
        /// Returns false as Symbol should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSymbol()
        {
            return _flagSymbol;
        }
        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        public string ShortName
        {
            get{ return _ShortName;}
            set
            {
                _ShortName = value;
                _flagShortName = true;
            }
        }
        private string _ShortName;
        private bool _flagShortName;

        /// <summary>
        /// Returns false as ShortName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeShortName()
        {
            return _flagShortName;
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
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public int Position
        {
            get{ return _Position;}
            set
            {
                _Position = value;
                _flagPosition = true;
            }
        }
        private int _Position;
        private bool _flagPosition;

        /// <summary>
        /// Returns false as Position should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePosition()
        {
            return _flagPosition;
        }
        /// <summary>
        /// Gets or Sets DecimalPrecision
        /// </summary>
        [DataMember(Name = "decimalPrecision", EmitDefaultValue = false)]
        public int DecimalPrecision
        {
            get{ return _DecimalPrecision;}
            set
            {
                _DecimalPrecision = value;
                _flagDecimalPrecision = true;
            }
        }
        private int _DecimalPrecision;
        private bool _flagDecimalPrecision;

        /// <summary>
        /// Returns false as DecimalPrecision should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDecimalPrecision()
        {
            return _flagDecimalPrecision;
        }
        /// <summary>
        /// Gets or Sets IsSystemDefault
        /// </summary>
        [DataMember(Name = "isSystemDefault", EmitDefaultValue = true)]
        public bool IsSystemDefault
        {
            get{ return _IsSystemDefault;}
            set
            {
                _IsSystemDefault = value;
                _flagIsSystemDefault = true;
            }
        }
        private bool _IsSystemDefault;
        private bool _flagIsSystemDefault;

        /// <summary>
        /// Returns false as IsSystemDefault should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsSystemDefault()
        {
            return _flagIsSystemDefault;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesChannelContextAllOfCurrency {\n");
            sb.Append("  IsoCode: ").Append(IsoCode).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  DecimalPrecision: ").Append(DecimalPrecision).Append("\n");
            sb.Append("  IsSystemDefault: ").Append(IsSystemDefault).Append("\n");
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
            return this.Equals(input as SalesChannelContextAllOfCurrency);
        }

        /// <summary>
        /// Returns true if SalesChannelContextAllOfCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesChannelContextAllOfCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesChannelContextAllOfCurrency input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsoCode == input.IsoCode ||
                    (this.IsoCode != null &&
                    this.IsoCode.Equals(input.IsoCode))
                ) && 
                (
                    this.Factor == input.Factor ||
                    this.Factor.Equals(input.Factor)
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.DecimalPrecision == input.DecimalPrecision ||
                    this.DecimalPrecision.Equals(input.DecimalPrecision)
                ) && 
                (
                    this.IsSystemDefault == input.IsSystemDefault ||
                    this.IsSystemDefault.Equals(input.IsSystemDefault)
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
                if (this.IsoCode != null)
                {
                    hashCode = (hashCode * 59) + this.IsoCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Factor.GetHashCode();
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                hashCode = (hashCode * 59) + this.DecimalPrecision.GetHashCode();
                hashCode = (hashCode * 59) + this.IsSystemDefault.GetHashCode();
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
