using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareSharp.Client
{
    /// <summary>
    /// Additional request options
    /// </summary>
    public class RequestOptions
    {
        /// <summary>
        /// API base url
        /// </summary>
        public Uri? Host { get; set; }
        /// <summary>
        /// Additional request headers
        /// </summary>
        public KeyValuePair<string, string>[]? Headers { get; set; }
        /// <summary>
        /// Context key token
        /// </summary>
        public ContextKeyToken? ContextKey { get; set; }
        /// <summary>
        /// Api key token
        /// </summary>
        public ApiKeyToken? ApiKey { get; set; }
        /// <summary>
        /// OAuth token
        /// </summary>
        public OAuthToken? OAuthToken { get; set; }
    }
}
