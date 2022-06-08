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
    /// ShippingMethodPageRouteResponseInnerMedia
    /// </summary>
    [DataContract(Name = "ShippingMethodPageRouteResponse_inner_media")]
    public partial class ShippingMethodPageRouteResponseInnerMedia : IEquatable<ShippingMethodPageRouteResponseInnerMedia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMethodPageRouteResponseInnerMedia" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="mimeType">mimeType.</param>
        /// <param name="fileExtension">fileExtension.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="title">title.</param>
        /// <param name="metaDataRaw">metaDataRaw.</param>
        /// <param name="mediaTypeRaw">mediaTypeRaw.</param>
        /// <param name="uploadedAt">uploadedAt.</param>
        /// <param name="alt">alt.</param>
        /// <param name="url">url.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="mediaFolderId">mediaFolderId.</param>
        /// <param name="_private">_private.</param>
        /// <param name="thumbnailsRo">thumbnailsRo.</param>
        public ShippingMethodPageRouteResponseInnerMedia(string userId = default(string), string mimeType = default(string), string fileExtension = default(string), int fileSize = default(int), string title = default(string), string metaDataRaw = default(string), string mediaTypeRaw = default(string), DateTime uploadedAt = default(DateTime), string alt = default(string), string url = default(string), string fileName = default(string), string mediaFolderId = default(string), bool _private = default(bool), string thumbnailsRo = default(string))
        {
            this._UserId = userId;
            if (this.UserId != null)
            {
                this._flagUserId = true;
            }
            this._MimeType = mimeType;
            if (this.MimeType != null)
            {
                this._flagMimeType = true;
            }
            this._FileExtension = fileExtension;
            if (this.FileExtension != null)
            {
                this._flagFileExtension = true;
            }
            this._FileSize = fileSize;
            if (this.FileSize != null)
            {
                this._flagFileSize = true;
            }
            this._Title = title;
            if (this.Title != null)
            {
                this._flagTitle = true;
            }
            this._MetaDataRaw = metaDataRaw;
            if (this.MetaDataRaw != null)
            {
                this._flagMetaDataRaw = true;
            }
            this._MediaTypeRaw = mediaTypeRaw;
            if (this.MediaTypeRaw != null)
            {
                this._flagMediaTypeRaw = true;
            }
            this._UploadedAt = uploadedAt;
            if (this.UploadedAt != null)
            {
                this._flagUploadedAt = true;
            }
            this._Alt = alt;
            if (this.Alt != null)
            {
                this._flagAlt = true;
            }
            this._Url = url;
            if (this.Url != null)
            {
                this._flagUrl = true;
            }
            this._FileName = fileName;
            if (this.FileName != null)
            {
                this._flagFileName = true;
            }
            this._MediaFolderId = mediaFolderId;
            if (this.MediaFolderId != null)
            {
                this._flagMediaFolderId = true;
            }
            this._Private = _private;
            if (this.Private != null)
            {
                this._flagPrivate = true;
            }
            this._ThumbnailsRo = thumbnailsRo;
            if (this.ThumbnailsRo != null)
            {
                this._flagThumbnailsRo = true;
            }
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId
        {
            get{ return _UserId;}
            set
            {
                _UserId = value;
                _flagUserId = true;
            }
        }
        private string _UserId;
        private bool _flagUserId;

        /// <summary>
        /// Returns false as UserId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUserId()
        {
            return _flagUserId;
        }
        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name = "mimeType", EmitDefaultValue = false)]
        public string MimeType
        {
            get{ return _MimeType;}
            set
            {
                _MimeType = value;
                _flagMimeType = true;
            }
        }
        private string _MimeType;
        private bool _flagMimeType;

        /// <summary>
        /// Returns false as MimeType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMimeType()
        {
            return _flagMimeType;
        }
        /// <summary>
        /// Gets or Sets FileExtension
        /// </summary>
        [DataMember(Name = "fileExtension", EmitDefaultValue = false)]
        public string FileExtension
        {
            get{ return _FileExtension;}
            set
            {
                _FileExtension = value;
                _flagFileExtension = true;
            }
        }
        private string _FileExtension;
        private bool _flagFileExtension;

        /// <summary>
        /// Returns false as FileExtension should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFileExtension()
        {
            return _flagFileExtension;
        }
        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public int FileSize
        {
            get{ return _FileSize;}
            set
            {
                _FileSize = value;
                _flagFileSize = true;
            }
        }
        private int _FileSize;
        private bool _flagFileSize;

        /// <summary>
        /// Returns false as FileSize should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFileSize()
        {
            return _flagFileSize;
        }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
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
        /// Gets or Sets MetaDataRaw
        /// </summary>
        [DataMember(Name = "metaDataRaw", EmitDefaultValue = false)]
        public string MetaDataRaw
        {
            get{ return _MetaDataRaw;}
            set
            {
                _MetaDataRaw = value;
                _flagMetaDataRaw = true;
            }
        }
        private string _MetaDataRaw;
        private bool _flagMetaDataRaw;

        /// <summary>
        /// Returns false as MetaDataRaw should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetaDataRaw()
        {
            return _flagMetaDataRaw;
        }
        /// <summary>
        /// Gets or Sets MediaTypeRaw
        /// </summary>
        [DataMember(Name = "mediaTypeRaw", EmitDefaultValue = false)]
        public string MediaTypeRaw
        {
            get{ return _MediaTypeRaw;}
            set
            {
                _MediaTypeRaw = value;
                _flagMediaTypeRaw = true;
            }
        }
        private string _MediaTypeRaw;
        private bool _flagMediaTypeRaw;

        /// <summary>
        /// Returns false as MediaTypeRaw should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMediaTypeRaw()
        {
            return _flagMediaTypeRaw;
        }
        /// <summary>
        /// Gets or Sets UploadedAt
        /// </summary>
        [DataMember(Name = "uploadedAt", EmitDefaultValue = false)]
        public DateTime UploadedAt
        {
            get{ return _UploadedAt;}
            set
            {
                _UploadedAt = value;
                _flagUploadedAt = true;
            }
        }
        private DateTime _UploadedAt;
        private bool _flagUploadedAt;

        /// <summary>
        /// Returns false as UploadedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUploadedAt()
        {
            return _flagUploadedAt;
        }
        /// <summary>
        /// Gets or Sets Alt
        /// </summary>
        [DataMember(Name = "alt", EmitDefaultValue = false)]
        public string Alt
        {
            get{ return _Alt;}
            set
            {
                _Alt = value;
                _flagAlt = true;
            }
        }
        private string _Alt;
        private bool _flagAlt;

        /// <summary>
        /// Returns false as Alt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAlt()
        {
            return _flagAlt;
        }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url
        {
            get{ return _Url;}
            set
            {
                _Url = value;
                _flagUrl = true;
            }
        }
        private string _Url;
        private bool _flagUrl;

        /// <summary>
        /// Returns false as Url should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUrl()
        {
            return _flagUrl;
        }
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "fileName", EmitDefaultValue = false)]
        public string FileName
        {
            get{ return _FileName;}
            set
            {
                _FileName = value;
                _flagFileName = true;
            }
        }
        private string _FileName;
        private bool _flagFileName;

        /// <summary>
        /// Returns false as FileName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFileName()
        {
            return _flagFileName;
        }
        /// <summary>
        /// Gets or Sets MediaFolderId
        /// </summary>
        [DataMember(Name = "mediaFolderId", EmitDefaultValue = false)]
        public string MediaFolderId
        {
            get{ return _MediaFolderId;}
            set
            {
                _MediaFolderId = value;
                _flagMediaFolderId = true;
            }
        }
        private string _MediaFolderId;
        private bool _flagMediaFolderId;

        /// <summary>
        /// Returns false as MediaFolderId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMediaFolderId()
        {
            return _flagMediaFolderId;
        }
        /// <summary>
        /// Gets or Sets Private
        /// </summary>
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private
        {
            get{ return _Private;}
            set
            {
                _Private = value;
                _flagPrivate = true;
            }
        }
        private bool _Private;
        private bool _flagPrivate;

        /// <summary>
        /// Returns false as Private should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrivate()
        {
            return _flagPrivate;
        }
        /// <summary>
        /// Gets or Sets ThumbnailsRo
        /// </summary>
        [DataMember(Name = "thumbnailsRo", EmitDefaultValue = false)]
        public string ThumbnailsRo
        {
            get{ return _ThumbnailsRo;}
            set
            {
                _ThumbnailsRo = value;
                _flagThumbnailsRo = true;
            }
        }
        private string _ThumbnailsRo;
        private bool _flagThumbnailsRo;

        /// <summary>
        /// Returns false as ThumbnailsRo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeThumbnailsRo()
        {
            return _flagThumbnailsRo;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShippingMethodPageRouteResponseInnerMedia {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  MetaDataRaw: ").Append(MetaDataRaw).Append("\n");
            sb.Append("  MediaTypeRaw: ").Append(MediaTypeRaw).Append("\n");
            sb.Append("  UploadedAt: ").Append(UploadedAt).Append("\n");
            sb.Append("  Alt: ").Append(Alt).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  MediaFolderId: ").Append(MediaFolderId).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  ThumbnailsRo: ").Append(ThumbnailsRo).Append("\n");
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
            return this.Equals(input as ShippingMethodPageRouteResponseInnerMedia);
        }

        /// <summary>
        /// Returns true if ShippingMethodPageRouteResponseInnerMedia instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingMethodPageRouteResponseInnerMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingMethodPageRouteResponseInnerMedia input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.FileExtension == input.FileExtension ||
                    (this.FileExtension != null &&
                    this.FileExtension.Equals(input.FileExtension))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    this.FileSize.Equals(input.FileSize)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.MetaDataRaw == input.MetaDataRaw ||
                    (this.MetaDataRaw != null &&
                    this.MetaDataRaw.Equals(input.MetaDataRaw))
                ) && 
                (
                    this.MediaTypeRaw == input.MediaTypeRaw ||
                    (this.MediaTypeRaw != null &&
                    this.MediaTypeRaw.Equals(input.MediaTypeRaw))
                ) && 
                (
                    this.UploadedAt == input.UploadedAt ||
                    (this.UploadedAt != null &&
                    this.UploadedAt.Equals(input.UploadedAt))
                ) && 
                (
                    this.Alt == input.Alt ||
                    (this.Alt != null &&
                    this.Alt.Equals(input.Alt))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.MediaFolderId == input.MediaFolderId ||
                    (this.MediaFolderId != null &&
                    this.MediaFolderId.Equals(input.MediaFolderId))
                ) && 
                (
                    this.Private == input.Private ||
                    this.Private.Equals(input.Private)
                ) && 
                (
                    this.ThumbnailsRo == input.ThumbnailsRo ||
                    (this.ThumbnailsRo != null &&
                    this.ThumbnailsRo.Equals(input.ThumbnailsRo))
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
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.MimeType != null)
                {
                    hashCode = (hashCode * 59) + this.MimeType.GetHashCode();
                }
                if (this.FileExtension != null)
                {
                    hashCode = (hashCode * 59) + this.FileExtension.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FileSize.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.MetaDataRaw != null)
                {
                    hashCode = (hashCode * 59) + this.MetaDataRaw.GetHashCode();
                }
                if (this.MediaTypeRaw != null)
                {
                    hashCode = (hashCode * 59) + this.MediaTypeRaw.GetHashCode();
                }
                if (this.UploadedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UploadedAt.GetHashCode();
                }
                if (this.Alt != null)
                {
                    hashCode = (hashCode * 59) + this.Alt.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                if (this.MediaFolderId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaFolderId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Private.GetHashCode();
                if (this.ThumbnailsRo != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailsRo.GetHashCode();
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
