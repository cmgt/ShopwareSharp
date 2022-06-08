/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using ShopwareSharp.Client;
using ShopwareSharp.Api;
// uncomment below to import models
//using ShopwareSharp.Model;

namespace ShopwareSharp.Test.Api
{
    /// <summary>
    ///  Class for testing ProductApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductApiTests : IDisposable
    {
        private ProductApi instance;

        public ProductApiTests()
        {
            instance = new ProductApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductApi
            //Assert.IsType<ProductApi>(instance);
        }

        /// <summary>
        /// Test ReadProduct
        /// </summary>
        [Fact]
        public void ReadProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string accept = null;
            //ReadCustomerRequest? readCustomerRequest = null;
            //var response = instance.ReadProduct(contentType, accept, readCustomerRequest);
            //Assert.IsType<ReadProduct200Response>(response);
        }

        /// <summary>
        /// Test ReadProductCrossSellings
        /// </summary>
        [Fact]
        public void ReadProductCrossSellingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string contentType = null;
            //string accept = null;
            //var response = instance.ReadProductCrossSellings(productId, contentType, accept);
            //Assert.IsType<List<CrossSellingElementCollectionInner>>(response);
        }

        /// <summary>
        /// Test ReadProductDetail
        /// </summary>
        [Fact]
        public void ReadProductDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string contentType = null;
            //string accept = null;
            //var response = instance.ReadProductDetail(productId, contentType, accept);
            //Assert.IsType<ProductDetailResponse>(response);
        }

        /// <summary>
        /// Test ReadProductExport
        /// </summary>
        [Fact]
        public void ReadProductExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessKey = null;
            //string fileName = null;
            //string contentType = null;
            //string accept = null;
            //instance.ReadProductExport(accessKey, fileName, contentType, accept);
        }

        /// <summary>
        /// Test ReadProductListing
        /// </summary>
        [Fact]
        public void ReadProductListingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryId = null;
            //string contentType = null;
            //string accept = null;
            //ReadProductListingRequest? readProductListingRequest = null;
            //var response = instance.ReadProductListing(categoryId, contentType, accept, readProductListingRequest);
            //Assert.IsType<ProductListingResult>(response);
        }

        /// <summary>
        /// Test ReadProductReviews
        /// </summary>
        [Fact]
        public void ReadProductReviewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string contentType = null;
            //string accept = null;
            //ReadCustomerRequest? readCustomerRequest = null;
            //var response = instance.ReadProductReviews(productId, contentType, accept, readCustomerRequest);
            //Assert.IsType<ReadProductReviews200Response>(response);
        }

        /// <summary>
        /// Test SaveProductReview
        /// </summary>
        [Fact]
        public void SaveProductReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //string contentType = null;
            //string accept = null;
            //SaveProductReviewRequest? saveProductReviewRequest = null;
            //instance.SaveProductReview(productId, contentType, accept, saveProductReviewRequest);
        }

        /// <summary>
        /// Test SearchPage
        /// </summary>
        [Fact]
        public void SearchPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string accept = null;
            //SearchPageRequest? searchPageRequest = null;
            //var response = instance.SearchPage(contentType, accept, searchPageRequest);
            //Assert.IsType<ProductListingResult>(response);
        }

        /// <summary>
        /// Test SearchSuggest
        /// </summary>
        [Fact]
        public void SearchSuggestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string accept = null;
            //SearchSuggestRequest searchSuggestRequest = null;
            //var response = instance.SearchSuggest(contentType, accept, searchSuggestRequest);
            //Assert.IsType<ProductListingResult>(response);
        }
    }
}
