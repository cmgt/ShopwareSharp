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
using ShopwareSharp.Client;
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
    ///  Class for testing OrderApi
    /// </summary>
    public sealed class OrderApiTests : ApiTestsBase
    {
        private readonly IOrderApi _instance;

        public OrderApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IOrderApi>();
        }


        /// <summary>
        /// Test CancelOrder
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CancelOrderAsyncTest()
        {
            CancelOrderRequest cancelOrderRequest = default;
            
            var response = await _instance.CancelOrderAsync(cancelOrderRequest);
            Assert.IsType<StateMachineState>(response);
        }

        /// <summary>
        /// Test CreateOrder
        /// </summary>
        [Fact]
        public async Task CreateOrderAsyncTest()
        {
            CreateOrderRequest? createOrderRequest = default;
            var response = await _instance.CreateOrderAsync(createOrderRequest);
            Assert.IsType<Order>(response);
        }

        /// <summary>
        /// Test OrderSetPayment
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task OrderSetPaymentAsyncTest()
        {
            OrderSetPaymentRequest orderSetPaymentRequest = default;
            
            
            var response = await _instance.OrderSetPaymentAsync(orderSetPaymentRequest);
            Assert.IsType<SuccessResponse>(response);
        }

        /// <summary>
        /// Test ReadOrder
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadOrderAsyncTest()
        {
            ReadOrderRequest readOrderRequest = default;
            
            
            var response = await _instance.ReadOrderAsync(readOrderRequest);
            Assert.IsType<OrderRouteResponse>(response);
        }
    }
}
