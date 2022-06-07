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
using ShopwareSharp.Api;
using ShopwareSharp.Model;


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
    ///  Class for testing CategoryApi
    /// </summary>
    public sealed class CategoryApiTests : ApiTestsBase
    {
        private readonly ICategoryApi _instance;

        public CategoryApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ICategoryApi>();
        }


        /// <summary>
        /// Test ReadCategory
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadCategoryAsyncTest()
        {
            string categoryId = default;
            string contentType = default;
            string accept = default;
            string? slots = default;
            ReadCategoryRequest? readCategoryRequest = default;
            var response = await _instance.ReadCategoryAsync(categoryId, contentType, accept, slots, readCategoryRequest);
            Assert.IsType<Category>(response);
        }

        /// <summary>
        /// Test ReadCategoryList
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadCategoryListAsyncTest()
        {
            string contentType = default;
            string accept = default;
            ReadCustomerRequest? readCustomerRequest = default;
            var response = await _instance.ReadCategoryListAsync(contentType, accept, readCustomerRequest);
            Assert.IsType<ReadCategoryList200Response>(response);
        }

        /// <summary>
        /// Test ReadNavigation
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadNavigationAsyncTest()
        {
            string requestActiveId = default;
            string requestRootId = default;
            ReadNavigationRequest readNavigationRequest = default;
            string contentType = default;
            string accept = default;
            bool? swIncludeSeoUrls = default;
            var response = await _instance.ReadNavigationAsync(requestActiveId, requestRootId, readNavigationRequest, contentType, accept, swIncludeSeoUrls);
            Assert.IsType<List<Category>>(response);
        }
    }
}
