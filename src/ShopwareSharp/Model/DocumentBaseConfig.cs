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
    [DataContract(Name = "DocumentBaseConfig")]
    public partial class DocumentBaseConfig : IEquatable<DocumentBaseConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBaseConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentBaseConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBaseConfig" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="documentTypeId">documentTypeId (required).</param>
        /// <param name="logoId">logoId.</param>
        /// <param name="name">name (required).</param>
        /// <param name="filenamePrefix">filenamePrefix.</param>
        /// <param name="filenameSuffix">filenameSuffix.</param>
        /// <param name="global">global (required).</param>
        /// <param name="documentNumber">documentNumber.</param>
        /// <param name="config">config.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="logo">logo.</param>
        public DocumentBaseConfig(string id = default(string), string documentTypeId = default(string), string logoId = default(string), string name = default(string), string filenamePrefix = default(string), string filenameSuffix = default(string), bool global = default(bool), string documentNumber = default(string), Object config = default(Object), Object customFields = default(Object), Media logo = default(Media))
        {
            // to ensure "documentTypeId" is required (not null)
            if (documentTypeId == null)
            {
                throw new ArgumentNullException("documentTypeId is a required property for DocumentBaseConfig and cannot be null");
            }
            this._DocumentTypeId = documentTypeId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DocumentBaseConfig and cannot be null");
            }
            this._Name = name;
            this._Global = global;
            this._Id = id;
            if (this.Id != null)
            {
                this._flagId = true;
            }
            this._LogoId = logoId;
            if (this.LogoId != null)
            {
                this._flagLogoId = true;
            }
            this._FilenamePrefix = filenamePrefix;
            if (this.FilenamePrefix != null)
            {
                this._flagFilenamePrefix = true;
            }
            this._FilenameSuffix = filenameSuffix;
            if (this.FilenameSuffix != null)
            {
                this._flagFilenameSuffix = true;
            }
            this._DocumentNumber = documentNumber;
            if (this.DocumentNumber != null)
            {
                this._flagDocumentNumber = true;
            }
            this._Config = config;
            if (this.Config != null)
            {
                this._flagConfig = true;
            }
            this._CustomFields = customFields;
            if (this.CustomFields != null)
            {
                this._flagCustomFields = true;
            }
            this._Logo = logo;
            if (this.Logo != null)
            {
                this._flagLogo = true;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id
        {
            get{ return _Id;}
            set
            {
                _Id = value;
                _flagId = true;
            }
        }
        private string _Id;
        private bool _flagId;

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return _flagId;
        }
        /// <summary>
        /// Gets or Sets DocumentTypeId
        /// </summary>
        [DataMember(Name = "documentTypeId", IsRequired = true, EmitDefaultValue = false)]
        public string DocumentTypeId
        {
            get{ return _DocumentTypeId;}
            set
            {
                _DocumentTypeId = value;
                _flagDocumentTypeId = true;
            }
        }
        private string _DocumentTypeId;
        private bool _flagDocumentTypeId;

        /// <summary>
        /// Returns false as DocumentTypeId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDocumentTypeId()
        {
            return _flagDocumentTypeId;
        }
        /// <summary>
        /// Gets or Sets LogoId
        /// </summary>
        [DataMember(Name = "logoId", EmitDefaultValue = false)]
        public string LogoId
        {
            get{ return _LogoId;}
            set
            {
                _LogoId = value;
                _flagLogoId = true;
            }
        }
        private string _LogoId;
        private bool _flagLogoId;

        /// <summary>
        /// Returns false as LogoId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLogoId()
        {
            return _flagLogoId;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
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
        /// Gets or Sets FilenamePrefix
        /// </summary>
        [DataMember(Name = "filenamePrefix", EmitDefaultValue = false)]
        public string FilenamePrefix
        {
            get{ return _FilenamePrefix;}
            set
            {
                _FilenamePrefix = value;
                _flagFilenamePrefix = true;
            }
        }
        private string _FilenamePrefix;
        private bool _flagFilenamePrefix;

        /// <summary>
        /// Returns false as FilenamePrefix should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFilenamePrefix()
        {
            return _flagFilenamePrefix;
        }
        /// <summary>
        /// Gets or Sets FilenameSuffix
        /// </summary>
        [DataMember(Name = "filenameSuffix", EmitDefaultValue = false)]
        public string FilenameSuffix
        {
            get{ return _FilenameSuffix;}
            set
            {
                _FilenameSuffix = value;
                _flagFilenameSuffix = true;
            }
        }
        private string _FilenameSuffix;
        private bool _flagFilenameSuffix;

        /// <summary>
        /// Returns false as FilenameSuffix should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFilenameSuffix()
        {
            return _flagFilenameSuffix;
        }
        /// <summary>
        /// Gets or Sets Global
        /// </summary>
        [DataMember(Name = "global", IsRequired = true, EmitDefaultValue = true)]
        public bool Global
        {
            get{ return _Global;}
            set
            {
                _Global = value;
                _flagGlobal = true;
            }
        }
        private bool _Global;
        private bool _flagGlobal;

        /// <summary>
        /// Returns false as Global should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGlobal()
        {
            return _flagGlobal;
        }
        /// <summary>
        /// Gets or Sets DocumentNumber
        /// </summary>
        [DataMember(Name = "documentNumber", EmitDefaultValue = false)]
        public string DocumentNumber
        {
            get{ return _DocumentNumber;}
            set
            {
                _DocumentNumber = value;
                _flagDocumentNumber = true;
            }
        }
        private string _DocumentNumber;
        private bool _flagDocumentNumber;

        /// <summary>
        /// Returns false as DocumentNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDocumentNumber()
        {
            return _flagDocumentNumber;
        }
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public Object Config
        {
            get{ return _Config;}
            set
            {
                _Config = value;
                _flagConfig = true;
            }
        }
        private Object _Config;
        private bool _flagConfig;

        /// <summary>
        /// Returns false as Config should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConfig()
        {
            return _flagConfig;
        }
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
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "customFields", EmitDefaultValue = false)]
        public Object CustomFields
        {
            get{ return _CustomFields;}
            set
            {
                _CustomFields = value;
                _flagCustomFields = true;
            }
        }
        private Object _CustomFields;
        private bool _flagCustomFields;

        /// <summary>
        /// Returns false as CustomFields should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomFields()
        {
            return _flagCustomFields;
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
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public Media Logo
        {
            get{ return _Logo;}
            set
            {
                _Logo = value;
                _flagLogo = true;
            }
        }
        private Media _Logo;
        private bool _flagLogo;

        /// <summary>
        /// Returns false as Logo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLogo()
        {
            return _flagLogo;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentBaseConfig {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DocumentTypeId: ").Append(DocumentTypeId).Append("\n");
            sb.Append("  LogoId: ").Append(LogoId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FilenamePrefix: ").Append(FilenamePrefix).Append("\n");
            sb.Append("  FilenameSuffix: ").Append(FilenameSuffix).Append("\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
            return this.Equals(input as DocumentBaseConfig);
        }

        /// <summary>
        /// Returns true if DocumentBaseConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentBaseConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBaseConfig input)
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
                    this.DocumentTypeId == input.DocumentTypeId ||
                    (this.DocumentTypeId != null &&
                    this.DocumentTypeId.Equals(input.DocumentTypeId))
                ) && 
                (
                    this.LogoId == input.LogoId ||
                    (this.LogoId != null &&
                    this.LogoId.Equals(input.LogoId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FilenamePrefix == input.FilenamePrefix ||
                    (this.FilenamePrefix != null &&
                    this.FilenamePrefix.Equals(input.FilenamePrefix))
                ) && 
                (
                    this.FilenameSuffix == input.FilenameSuffix ||
                    (this.FilenameSuffix != null &&
                    this.FilenameSuffix.Equals(input.FilenameSuffix))
                ) && 
                (
                    this.Global == input.Global ||
                    this.Global.Equals(input.Global)
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
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
                if (this.DocumentTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentTypeId.GetHashCode();
                }
                if (this.LogoId != null)
                {
                    hashCode = (hashCode * 59) + this.LogoId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.FilenamePrefix != null)
                {
                    hashCode = (hashCode * 59) + this.FilenamePrefix.GetHashCode();
                }
                if (this.FilenameSuffix != null)
                {
                    hashCode = (hashCode * 59) + this.FilenameSuffix.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Global.GetHashCode();
                if (this.DocumentNumber != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentNumber.GetHashCode();
                }
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
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

            // DocumentTypeId (string) pattern
            Regex regexDocumentTypeId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexDocumentTypeId.Match(this.DocumentTypeId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentTypeId, must match a pattern of " + regexDocumentTypeId, new [] { "DocumentTypeId" });
            }

            // LogoId (string) pattern
            Regex regexLogoId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexLogoId.Match(this.LogoId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoId, must match a pattern of " + regexLogoId, new [] { "LogoId" });
            }

            yield break;
        }
    }

}
