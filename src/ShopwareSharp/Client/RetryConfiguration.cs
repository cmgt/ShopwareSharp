/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Polly;
using System.Net.Http;

namespace ShopwareSharp.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public static class RetryConfiguration
    {
        /// <summary>
        /// Retry policy
        /// </summary>
        public static Policy<HttpResponseMessage> RetryPolicy { get; set; }

        /// <summary>
        /// Async retry policy
        /// </summary>
        public static AsyncPolicy<HttpResponseMessage> AsyncRetryPolicy { get; set; }
    }
}
