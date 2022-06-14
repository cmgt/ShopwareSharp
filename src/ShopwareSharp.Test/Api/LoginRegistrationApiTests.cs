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
    ///  Class for testing LoginRegistrationApi
    /// </summary>
    public sealed class LoginRegistrationApiTests : ApiTestsBase
    {
        private readonly ILoginRegistrationApi _instance;

        public LoginRegistrationApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ILoginRegistrationApi>();
        }

        /// <summary>
        /// Test GetCustomerGroupRegistrationInfo
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetCustomerGroupRegistrationInfoAsyncTest()
        {
            string customerGroupId = default;
            var response = await _instance.GetCustomerGroupRegistrationInfoAsync(customerGroupId);
            Assert.IsType<CustomerGroup>(response);
        }

        /// <summary>
        /// Test LoginCustomer
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task LoginCustomerAsyncTest()
        {
            LoginCustomerRequest loginCustomerRequest = default;
            var response = await _instance.LoginCustomerAsync(loginCustomerRequest);
            Assert.IsType<ContextTokenResponse>(response);
        }

        /// <summary>
        /// Test LogoutCustomer
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task LogoutCustomerAsyncTest()
        {
            var response = await _instance.LogoutCustomerAsync();
            Assert.IsType<ContextTokenResponse>(response);
        }

        /// <summary>
        /// Test Register
        /// </summary>
        [Fact]
        public async Task RegisterAsyncTest()
        {
            var countryId = "82eea3268e2d4bda8d225a997706cb5d";
            var salutationId = "9f7efcf3d889448baebd8aa9a43ee578";
            RegisterRequest registerRequest = new RegisterRequest("john@doe.com", String.Empty, salutationId, "John",
                "Doe", false, String.Empty, 
                new CustomerAddress(countryId, salutationId, "94066", "Chicago", "136 Ave", createdAt: DateTime.UtcNow), guest: true);

            var response = await _instance.RegisterAsync(registerRequest);
            Assert.IsType<Customer>(response);
        }

        /// <summary>
        /// Test RegisterConfirm
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task RegisterConfirmAsyncTest()
        {
            RegisterConfirmRequest registerConfirmRequest = default;
            await _instance.RegisterConfirmAsync(registerConfirmRequest);
        }
    }
}
