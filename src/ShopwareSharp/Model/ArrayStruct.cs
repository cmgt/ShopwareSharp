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
    /// ArrayStruct
    /// </summary>
    [DataContract(Name = "ArrayStruct")]
    public partial class ArrayStruct : IEquatable<ArrayStruct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayStruct" /> class.
        /// </summary>
        /// <param name="apiAlias">Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias)..</param>
        public ArrayStruct(string apiAlias = default(string))
        {
            this._ApiAlias = apiAlias;
            if (this.ApiAlias != null)
            {
                this._flagApiAlias = true;
            }
        }

        /// <summary>
        /// Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).
        /// </summary>
        /// <value>Alias which can be used to restrict response fields. For more information see [includes](https://shopware.stoplight.io/docs/store-api/docs/concepts/search-queries.md#includes-apialias).</value>
        [DataMember(Name = "apiAlias", EmitDefaultValue = false)]
        public string ApiAlias
        {
            get{ return _ApiAlias;}
            set
            {
                _ApiAlias = value;
                _flagApiAlias = true;
            }
        }
        private string _ApiAlias;
        private bool _flagApiAlias;

        /// <summary>
        /// Returns false as ApiAlias should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApiAlias()
        {
            return _flagApiAlias;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArrayStruct {\n");
            sb.Append("  ApiAlias: ").Append(ApiAlias).Append("\n");
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
            return this.Equals(input as ArrayStruct);
        }

        /// <summary>
        /// Returns true if ArrayStruct instances are equal
        /// </summary>
        /// <param name="input">Instance of ArrayStruct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayStruct input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiAlias == input.ApiAlias ||
                    (this.ApiAlias != null &&
                    this.ApiAlias.Equals(input.ApiAlias))
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
                if (this.ApiAlias != null)
                {
                    hashCode = (hashCode * 59) + this.ApiAlias.GetHashCode();
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
