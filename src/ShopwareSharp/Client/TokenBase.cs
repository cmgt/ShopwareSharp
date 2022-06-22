// <auto-generated>

#nullable enable

using System;

namespace ShopwareSharp.Client
{
    /// <summary>
    /// The base for all tokens.
    /// </summary>
    public abstract class TokenBase
    {
        protected string raw = default!;

        /// <summary>
        /// Places the token in the cookie.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cookieName"></param>
        public virtual void UseInCookie(System.Net.Http.HttpRequestMessage request, string cookieName)
        {
            request.Headers.Add("Cookie", $"{cookieName}={raw}");
        }

        /// <summary>
        /// Places the token in the header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="headerName"></param>
        public virtual void UseInHeader(System.Net.Http.HttpRequestMessage request, string headerName)
        {
            if (String.IsNullOrWhiteSpace(raw)) return;
            request.Headers.Add(headerName, raw);
        }
        
        /// <summary>
        /// Places the token in the query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="uriBuilder"></param>
        /// <param name="parseQueryString"></param>
        /// <param name="parameterName"></param>
        public virtual void UseInQuery(System.Net.Http.HttpRequestMessage request, UriBuilder uriBuilder, System.Collections.Specialized.NameValueCollection parseQueryString, string parameterName)
        {
            parseQueryString[parameterName] = Uri.EscapeDataString(raw).ToString()!;
        }
    }
}