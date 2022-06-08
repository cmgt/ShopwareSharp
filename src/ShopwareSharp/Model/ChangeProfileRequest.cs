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
    /// ChangeProfileRequest
    /// </summary>
    [DataContract(Name = "changeProfile_request")]
    public partial class ChangeProfileRequest : IEquatable<ChangeProfileRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeProfileRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeProfileRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeProfileRequest" /> class.
        /// </summary>
        /// <param name="salutationId">Id of the salutation for the customer account. Fetch options using &#x60;salutation&#x60; endpoint. (required).</param>
        /// <param name="title">(Academic) title of the customer.</param>
        /// <param name="firstName">Customer first name. Value will be reused for shipping and billing address if not provided explicitly. (required).</param>
        /// <param name="lastName">Customer last name. Value will be reused for shipping and billing address if not provided explicitly. (required).</param>
        /// <param name="company">Company of the customer. Only required when &#x60;accountType&#x60; is &#x60;business&#x60;..</param>
        /// <param name="birthdayDay">Birthday day.</param>
        /// <param name="birthdayMonth">Birthday month.</param>
        /// <param name="birthdayYear">Birthday year.</param>
        public ChangeProfileRequest(string salutationId = default(string), string title = default(string), string firstName = default(string), string lastName = default(string), string company = default(string), int birthdayDay = default(int), int birthdayMonth = default(int), int birthdayYear = default(int))
        {
            // to ensure "salutationId" is required (not null)
            if (salutationId == null)
            {
                throw new ArgumentNullException("salutationId is a required property for ChangeProfileRequest and cannot be null");
            }
            this._SalutationId = salutationId;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for ChangeProfileRequest and cannot be null");
            }
            this._FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for ChangeProfileRequest and cannot be null");
            }
            this._LastName = lastName;
            this._Title = title;
            if (this.Title != null)
            {
                this._flagTitle = true;
            }
            this._Company = company;
            if (this.Company != null)
            {
                this._flagCompany = true;
            }
            this._BirthdayDay = birthdayDay;
            if (this.BirthdayDay != null)
            {
                this._flagBirthdayDay = true;
            }
            this._BirthdayMonth = birthdayMonth;
            if (this.BirthdayMonth != null)
            {
                this._flagBirthdayMonth = true;
            }
            this._BirthdayYear = birthdayYear;
            if (this.BirthdayYear != null)
            {
                this._flagBirthdayYear = true;
            }
        }

        /// <summary>
        /// Id of the salutation for the customer account. Fetch options using &#x60;salutation&#x60; endpoint.
        /// </summary>
        /// <value>Id of the salutation for the customer account. Fetch options using &#x60;salutation&#x60; endpoint.</value>
        [DataMember(Name = "salutationId", IsRequired = true, EmitDefaultValue = false)]
        public string SalutationId
        {
            get{ return _SalutationId;}
            set
            {
                _SalutationId = value;
                _flagSalutationId = true;
            }
        }
        private string _SalutationId;
        private bool _flagSalutationId;

        /// <summary>
        /// Returns false as SalutationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSalutationId()
        {
            return _flagSalutationId;
        }
        /// <summary>
        /// (Academic) title of the customer
        /// </summary>
        /// <value>(Academic) title of the customer</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title
        {
            get{ return _Title;}
            set
            {
                _Title = value;
                _flagTitle = true;
            }
        }
        private string _Title;
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
        /// Customer first name. Value will be reused for shipping and billing address if not provided explicitly.
        /// </summary>
        /// <value>Customer first name. Value will be reused for shipping and billing address if not provided explicitly.</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName
        {
            get{ return _FirstName;}
            set
            {
                _FirstName = value;
                _flagFirstName = true;
            }
        }
        private string _FirstName;
        private bool _flagFirstName;

        /// <summary>
        /// Returns false as FirstName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFirstName()
        {
            return _flagFirstName;
        }
        /// <summary>
        /// Customer last name. Value will be reused for shipping and billing address if not provided explicitly.
        /// </summary>
        /// <value>Customer last name. Value will be reused for shipping and billing address if not provided explicitly.</value>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = false)]
        public string LastName
        {
            get{ return _LastName;}
            set
            {
                _LastName = value;
                _flagLastName = true;
            }
        }
        private string _LastName;
        private bool _flagLastName;

        /// <summary>
        /// Returns false as LastName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastName()
        {
            return _flagLastName;
        }
        /// <summary>
        /// Company of the customer. Only required when &#x60;accountType&#x60; is &#x60;business&#x60;.
        /// </summary>
        /// <value>Company of the customer. Only required when &#x60;accountType&#x60; is &#x60;business&#x60;.</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company
        {
            get{ return _Company;}
            set
            {
                _Company = value;
                _flagCompany = true;
            }
        }
        private string _Company;
        private bool _flagCompany;

        /// <summary>
        /// Returns false as Company should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompany()
        {
            return _flagCompany;
        }
        /// <summary>
        /// Birthday day
        /// </summary>
        /// <value>Birthday day</value>
        [DataMember(Name = "birthdayDay", EmitDefaultValue = false)]
        public int BirthdayDay
        {
            get{ return _BirthdayDay;}
            set
            {
                _BirthdayDay = value;
                _flagBirthdayDay = true;
            }
        }
        private int _BirthdayDay;
        private bool _flagBirthdayDay;

        /// <summary>
        /// Returns false as BirthdayDay should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBirthdayDay()
        {
            return _flagBirthdayDay;
        }
        /// <summary>
        /// Birthday month
        /// </summary>
        /// <value>Birthday month</value>
        [DataMember(Name = "birthdayMonth", EmitDefaultValue = false)]
        public int BirthdayMonth
        {
            get{ return _BirthdayMonth;}
            set
            {
                _BirthdayMonth = value;
                _flagBirthdayMonth = true;
            }
        }
        private int _BirthdayMonth;
        private bool _flagBirthdayMonth;

        /// <summary>
        /// Returns false as BirthdayMonth should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBirthdayMonth()
        {
            return _flagBirthdayMonth;
        }
        /// <summary>
        /// Birthday year
        /// </summary>
        /// <value>Birthday year</value>
        [DataMember(Name = "birthdayYear", EmitDefaultValue = false)]
        public int BirthdayYear
        {
            get{ return _BirthdayYear;}
            set
            {
                _BirthdayYear = value;
                _flagBirthdayYear = true;
            }
        }
        private int _BirthdayYear;
        private bool _flagBirthdayYear;

        /// <summary>
        /// Returns false as BirthdayYear should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBirthdayYear()
        {
            return _flagBirthdayYear;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChangeProfileRequest {\n");
            sb.Append("  SalutationId: ").Append(SalutationId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  BirthdayDay: ").Append(BirthdayDay).Append("\n");
            sb.Append("  BirthdayMonth: ").Append(BirthdayMonth).Append("\n");
            sb.Append("  BirthdayYear: ").Append(BirthdayYear).Append("\n");
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
            return this.Equals(input as ChangeProfileRequest);
        }

        /// <summary>
        /// Returns true if ChangeProfileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeProfileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeProfileRequest input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
