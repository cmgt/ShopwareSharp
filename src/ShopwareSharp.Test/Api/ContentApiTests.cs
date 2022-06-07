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
    ///  Class for testing ContentApi
    /// </summary>
    public sealed class ContentApiTests : ApiTestsBase
    {
        private readonly IContentApi _instance;

        public ContentApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IContentApi>();
        }


        /// <summary>
        /// Test ReadCms
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadCmsAsyncTest()
        {
            string id = default;
            string contentType = default;
            string accept = default;
            ReadCmsRequest? readCmsRequest = default;
            var response = await _instance.ReadCmsAsync(id, contentType, accept, readCmsRequest);
            Assert.IsType<CmsPage>(response);
        }

        /// <summary>
        /// Test ReadLandingPage
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ReadLandingPageAsyncTest()
        {
            string landingPageId = default;
            string contentType = default;
            string accept = default;
            ReadLandingPageRequest? readLandingPageRequest = default;
            var response = await _instance.ReadLandingPageAsync(landingPageId, contentType, accept, readLandingPageRequest);
            Assert.IsType<LandingPage>(response);
        }

        /// <summary>
        /// Test SendContactMail
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SendContactMailAsyncTest()
        {
            SendContactMailRequest sendContactMailRequest = default;
            string contentType = default;
            string accept = default;
            await _instance.SendContactMailAsync(sendContactMailRequest, contentType, accept);
        }
    }
}
