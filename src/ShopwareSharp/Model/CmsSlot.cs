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
    [DataContract(Name = "CmsSlot")]
    public partial class CmsSlot : IEquatable<CmsSlot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CmsSlot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CmsSlot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CmsSlot" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="versionId">versionId.</param>
        /// <param name="type">type (required).</param>
        /// <param name="slot">slot (required).</param>
        /// <param name="locked">locked.</param>
        /// <param name="config">config.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="blockId">blockId (required).</param>
        /// <param name="cmsBlockVersionId">cmsBlockVersionId.</param>
        /// <param name="translated">translated.</param>
        /// <param name="block">block.</param>
        public CmsSlot(string id = default(string), string versionId = default(string), string type = default(string), string slot = default(string), bool locked = default(bool), Object config = default(Object), Object customFields = default(Object), string blockId = default(string), string cmsBlockVersionId = default(string), Object translated = default(Object), CmsBlock block = default(CmsBlock))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for CmsSlot and cannot be null");
            }
            this.Type = type;
            // to ensure "slot" is required (not null)
            if (slot == null)
            {
                throw new ArgumentNullException("slot is a required property for CmsSlot and cannot be null");
            }
            this.Slot = slot;
            // to ensure "blockId" is required (not null)
            if (blockId == null)
            {
                throw new ArgumentNullException("blockId is a required property for CmsSlot and cannot be null");
            }
            this.BlockId = blockId;
            this.Id = id;
            this.VersionId = versionId;
            this.Locked = locked;
            this.Config = config;
            this.CustomFields = customFields;
            this.CmsBlockVersionId = cmsBlockVersionId;
            this.Translated = translated;
            this.Block = block;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VersionId
        /// </summary>
        [DataMember(Name = "versionId", EmitDefaultValue = false)]
        public string VersionId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Slot
        /// </summary>
        [DataMember(Name = "slot", IsRequired = true, EmitDefaultValue = false)]
        public string Slot { get; set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        public bool Locked { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public Object Config { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name = "customFields", EmitDefaultValue = false)]
        public Object CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Object Data { get; private set; }

        /// <summary>
        /// Returns false as Data should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeData()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BlockId
        /// </summary>
        [DataMember(Name = "blockId", IsRequired = true, EmitDefaultValue = false)]
        public string BlockId { get; set; }

        /// <summary>
        /// Gets or Sets CmsBlockVersionId
        /// </summary>
        [DataMember(Name = "cmsBlockVersionId", EmitDefaultValue = false)]
        public string CmsBlockVersionId { get; set; }

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
        /// Gets or Sets Translated
        /// </summary>
        [DataMember(Name = "translated", EmitDefaultValue = false)]
        public Object Translated { get; set; }

        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name = "block", EmitDefaultValue = false)]
        public CmsBlock Block { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CmsSlot {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Slot: ").Append(Slot).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  BlockId: ").Append(BlockId).Append("\n");
            sb.Append("  CmsBlockVersionId: ").Append(CmsBlockVersionId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Translated: ").Append(Translated).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
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
            return this.Equals(input as CmsSlot);
        }

        /// <summary>
        /// Returns true if CmsSlot instances are equal
        /// </summary>
        /// <param name="input">Instance of CmsSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CmsSlot input)
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
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Slot == input.Slot ||
                    (this.Slot != null &&
                    this.Slot.Equals(input.Slot))
                ) && 
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    (this.CustomFields != null &&
                    this.CustomFields.Equals(input.CustomFields))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.BlockId == input.BlockId ||
                    (this.BlockId != null &&
                    this.BlockId.Equals(input.BlockId))
                ) && 
                (
                    this.CmsBlockVersionId == input.CmsBlockVersionId ||
                    (this.CmsBlockVersionId != null &&
                    this.CmsBlockVersionId.Equals(input.CmsBlockVersionId))
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
                    this.Translated == input.Translated ||
                    (this.Translated != null &&
                    this.Translated.Equals(input.Translated))
                ) && 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
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
                if (this.VersionId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Slot != null)
                {
                    hashCode = (hashCode * 59) + this.Slot.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Locked.GetHashCode();
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.CustomFields != null)
                {
                    hashCode = (hashCode * 59) + this.CustomFields.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.BlockId != null)
                {
                    hashCode = (hashCode * 59) + this.BlockId.GetHashCode();
                }
                if (this.CmsBlockVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.CmsBlockVersionId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Translated != null)
                {
                    hashCode = (hashCode * 59) + this.Translated.GetHashCode();
                }
                if (this.Block != null)
                {
                    hashCode = (hashCode * 59) + this.Block.GetHashCode();
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

            // VersionId (string) pattern
            Regex regexVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexVersionId.Match(this.VersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VersionId, must match a pattern of " + regexVersionId, new [] { "VersionId" });
            }

            // BlockId (string) pattern
            Regex regexBlockId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexBlockId.Match(this.BlockId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BlockId, must match a pattern of " + regexBlockId, new [] { "BlockId" });
            }

            // CmsBlockVersionId (string) pattern
            Regex regexCmsBlockVersionId = new Regex(@"^[0-9a-f]{32}$", RegexOptions.CultureInvariant);
            if (false == regexCmsBlockVersionId.Match(this.CmsBlockVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CmsBlockVersionId, must match a pattern of " + regexCmsBlockVersionId, new [] { "CmsBlockVersionId" });
            }

            yield break;
        }
    }

}