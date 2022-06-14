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
    ///  Class for testing ProductApi
    /// </summary>
    public sealed class ProductApiTests : ApiTestsBase
    {
        private readonly IProductApi _instance;

        public ProductApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IProductApi>();
        }

        /// <summary>
        /// Test ReadProduct
        /// </summary>
        [Fact]
        public async Task ReadProductAsyncTest()
        {
            ReadCustomerRequest? readCustomerRequest = default;
            var response = await _instance.ReadProductAsync(readCustomerRequest);
            Assert.IsType<ReadProduct200Response>(response);
        }

        /// <summary>
        /// Test ReadProductCrossSellings
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadProductCrossSellingsAsyncTest()
        {
            string productId = default;
            
            
            var response = await _instance.ReadProductCrossSellingsAsync(productId);
            Assert.IsType<List<CrossSellingElementCollectionInner>>(response);
        }

        /// <summary>
        /// Test ReadProductDetail
        /// </summary>
        [Fact]
        public async Task ReadProductDetailAsyncTest()
        {
            string productId = "0f683a27c45a4e408814a97fd7150ffa";
            
            var response = await _instance.ReadProductDetailAsync(productId);
            Assert.IsType<ProductDetailResponse>(response);
        }

        /// <summary>
        /// Test ReadProductExport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadProductExportAsyncTest()
        {
            string accessKey = default;
            string fileName = default;
            
            
            await _instance.ReadProductExportAsync(accessKey, fileName);
        }

        /// <summary>
        /// Test ReadProductListing
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadProductListingAsyncTest()
        {
            string categoryId = default;
            
            
            ReadProductListingRequest? readProductListingRequest = default;
            var response = await _instance.ReadProductListingAsync(categoryId, readProductListingRequest);
            Assert.IsType<ProductListingResult>(response);
        }

        /// <summary>
        /// Test ReadProductReviews
        /// </summary>
        [Fact]
        public async Task ReadProductReviewsAsyncTest()
        {
            string productId = "0f683a27c45a4e408814a97fd7150ffa";
            
            
            ReadCustomerRequest? readCustomerRequest = default;
            var response = await _instance.ReadProductReviewsAsync(productId, readCustomerRequest);
            Assert.IsType<ReadProductReviews200Response>(response);
        }

        /// <summary>
        /// Test SaveProductReview
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SaveProductReviewAsyncTest()
        {
            string productId = default;
            
            
            SaveProductReviewRequest? saveProductReviewRequest = default;
            await _instance.SaveProductReviewAsync(productId, saveProductReviewRequest);
        }

        /// <summary>
        /// Test SearchPage
        /// </summary>
        [Fact]
        public async Task SearchPageAsyncTest()
        {
            
            
            SearchPageRequest? searchPageRequest = new SearchPageRequest(new SearchPageRequestAllOf("test"));
            var response = await _instance.SearchPageAsync(searchPageRequest);
            Assert.IsType<ProductListingResult>(response);
        }

        /// <summary>
        /// Test SearchSuggest
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SearchSuggestAsyncTest()
        {
            SearchSuggestRequest searchSuggestRequest = default;
            
            
            var response = await _instance.SearchSuggestAsync(searchSuggestRequest);
            Assert.IsType<ProductListingResult>(response);
        }
    }
}
