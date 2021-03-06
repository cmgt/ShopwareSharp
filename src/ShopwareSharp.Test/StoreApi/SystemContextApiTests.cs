/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using ShopwareSharp.StoreApi;
using ShopwareSharp.Model;
using ShopwareSharp.Test.StoreApi;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace ShopwareSharp.Test.Api
{
    /// <summary>
    ///  Class for testing SystemContextApi
    /// </summary>
    public sealed class SystemContextApiTests : StoreApiTestsBase
    {
        private readonly ISystemContextApi _instance;

        public SystemContextApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ISystemContextApi>();
        }


        /// <summary>
        /// Test ReadContext
        /// </summary>
        [Fact]
        public async Task ReadContextAsyncTest()
        {
            var response = await _instance.ReadContextAsync();
            Assert.IsType<SalesChannelContext>(response);
        }

        /// <summary>
        /// Test ReadCountry
        /// </summary>
        [Fact]
        public async Task ReadCountryAsyncTest()
        {
            ReadCustomerRequest? readCustomerRequest = new ReadCustomerRequest(
                new Criteria(filter: new List<CriteriaFilterInner>()
                        {new CriteriaFilterInner("contains", "iso", "us")},
                    includes: new Dictionary<string, string[]> {["country"] = new[] {"id"}}));
            var response = await _instance.ReadCountryAsync(readCustomerRequest);
            Assert.IsType<ReadCountry200Response>(response);
        }

        /// <summary>
        /// Test ReadCurrency
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadCurrencyAsyncTest()
        {
            ReadCustomerRequest? readCustomerRequest = default;
            var response = await _instance.ReadCurrencyAsync(readCustomerRequest);
            Assert.IsType<ReadCurrency200Response>(response);
        }

        /// <summary>
        /// Test ReadLanguages
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadLanguagesAsyncTest()
        {
            ReadCustomerRequest? readCustomerRequest = default;
            var response = await _instance.ReadLanguagesAsync(readCustomerRequest);
            Assert.IsType<ReadLanguages200Response>(response);
        }

        /// <summary>
        /// Test ReadSalutation
        /// </summary>
        [Fact]
        public async Task ReadSalutationAsyncTest()
        {
            ReadCustomerRequest? readCustomerRequest = default;
            var response = await _instance.ReadSalutationAsync(readCustomerRequest);
            Assert.IsType<ReadSalutation200Response>(response);
        }

        /// <summary>
        /// Test UpdateContext
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateContextAsyncTest()
        {
            UpdateContextRequest updateContextRequest = default;
            var response = await _instance.UpdateContextAsync(updateContextRequest);
            Assert.IsType<ContextTokenResponse>(response);
        }
    }
}
