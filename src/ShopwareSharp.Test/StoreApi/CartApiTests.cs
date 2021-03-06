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
using Microsoft.Extensions.DependencyInjection;
using ShopwareSharp.Client;
using ShopwareSharp.Model;
using ShopwareSharp.StoreApi;
using Xunit;


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


namespace ShopwareSharp.Test.StoreApi
{
    /// <summary>
    ///  Class for testing CartApi
    /// </summary>
    public sealed class CartApiTests : StoreApiTestsBase
    {
        private readonly ICartApi _instance;

        public CartApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ICartApi>();
        }

        /// <summary>
        /// Test CreateCart
        /// </summary>
        [Fact]
        public async Task CreateCartAsyncTest()
        {
            var response = await _instance.ReadCartAsync(requestOptions: new RequestOptions(){ContextKey = ContextKeyToken.Unit});
            Assert.IsType<Cart>(response);
        }


        /// <summary>
        /// Test AddLineItem
        /// </summary>
        [Fact]
        public async Task AddLineItemAsyncTest()
        {
            CartItems? cartItems = new CartItems(cartItemsAllOf: new CartItemsAllOf(new List<LineItem>()
            {
                new LineItem()
                {
                    ReferencedId = "0f683a27c45a4e408814a97fd7150ffa", Quantity = 1,
                    Type = "product"
                }
            }));

            var response = await _instance.AddLineItemAsync(cartItems);
            Assert.IsType<Cart>(response);
        }

        /// <summary>
        /// Test DeleteCart
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteCartAsyncTest()
        {
            
            
            var response = await _instance.DeleteCartAsync();
            Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test ReadCart
        /// </summary>
        [Fact]
        public async Task ReadCartAsyncTest()
        {
            string? name = default;
            var response = await _instance.ReadCartAsync(name);
            Assert.IsType<Cart>(response);
        }

        /// <summary>
        /// Test RemoveLineItem
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task RemoveLineItemAsyncTest()
        {
            List<string> ids = default;
            
            
            var response = await _instance.RemoveLineItemAsync(ids);
            Assert.IsType<Cart>(response);
        }

        /// <summary>
        /// Test UpdateLineItem
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateLineItemAsyncTest()
        {
            
            
            CartItems? cartItems = default;
            var response = await _instance.UpdateLineItemAsync(cartItems);
            Assert.IsType<Cart>(response);
        }
    }
}
