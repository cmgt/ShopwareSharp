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
    /// SaveProductReviewRequest
    /// </summary>
    [DataContract(Name = "saveProductReview_request")]
    public partial class SaveProductReviewRequest : IEquatable<SaveProductReviewRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveProductReviewRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveProductReviewRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveProductReviewRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the review author. If not set, the first name of the customer is chosen..</param>
        /// <param name="email">The email address of the review author. If not set, the email of the customer is chosen..</param>
        /// <param name="title">The title of the review. (required).</param>
        /// <param name="content">The content of review. (required).</param>
        /// <param name="points">The review rating for the product. (required).</param>
        public SaveProductReviewRequest(string name = default(string), string email = default(string), Object title = default(Object), Object content = default(Object), Object points = default(Object))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for SaveProductReviewRequest and cannot be null");
            }
            this._Title = title;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for SaveProductReviewRequest and cannot be null");
            }
            this._Content = content;
            // to ensure "points" is required (not null)
            if (points == null)
            {
                throw new ArgumentNullException("points is a required property for SaveProductReviewRequest and cannot be null");
            }
            this._Points = points;
            this._Name = name;
            if (this.Name != null)
            {
                this._flagName = true;
            }
            this._Email = email;
            if (this.Email != null)
            {
                this._flagEmail = true;
            }
        }

        /// <summary>
        /// The name of the review author. If not set, the first name of the customer is chosen.
        /// </summary>
        /// <value>The name of the review author. If not set, the first name of the customer is chosen.</value>
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
        /// The email address of the review author. If not set, the email of the customer is chosen.
        /// </summary>
        /// <value>The email address of the review author. If not set, the email of the customer is chosen.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email
        {
            get{ return _Email;}
            set
            {
                _Email = value;
                _flagEmail = true;
            }
        }
        private string _Email;
        private bool _flagEmail;

        /// <summary>
        /// Returns false as Email should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmail()
        {
            return _flagEmail;
        }
        /// <summary>
        /// The title of the review.
        /// </summary>
        /// <value>The title of the review.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public Object Title
        {
            get{ return _Title;}
            set
            {
                _Title = value;
                _flagTitle = true;
            }
        }
        private Object _Title;
        private bool _flagTitle;

        /// <summary>
        /// Returns false as Title should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTitle()
        {
            return _flagTitle;
        }
        /// <summary>
        /// The content of review.
        /// </summary>
        /// <value>The content of review.</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public Object Content
        {
            get{ return _Content;}
            set
            {
                _Content = value;
                _flagContent = true;
            }
        }
        private Object _Content;
        private bool _flagContent;

        /// <summary>
        /// Returns false as Content should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContent()
        {
            return _flagContent;
        }
        /// <summary>
        /// The review rating for the product.
        /// </summary>
        /// <value>The review rating for the product.</value>
        [DataMember(Name = "points", IsRequired = true, EmitDefaultValue = true)]
        public Object Points
        {
            get{ return _Points;}
            set
            {
                _Points = value;
                _flagPoints = true;
            }
        }
        private Object _Points;
        private bool _flagPoints;

        /// <summary>
        /// Returns false as Points should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePoints()
        {
            return _flagPoints;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SaveProductReviewRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(input as SaveProductReviewRequest);
        }

        /// <summary>
        /// Returns true if SaveProductReviewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveProductReviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveProductReviewRequest input)
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
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Points != null)
                {
                    hashCode = (hashCode * 59) + this.Points.GetHashCode();
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
