/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ShopwareSharp.Api;
using ShopwareSharp.Model;
using ShopwareSharp.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ShopwareSharp.Test.Model
{
    /// <summary>
    ///  Class for testing Customer
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CustomerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Customer
        //private Customer instance;

        public CustomerTests()
        {
            // TODO uncomment below to create an instance of Customer
            //instance = new Customer();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Customer
        /// </summary>
        [Fact]
        public void CustomerInstanceTest()
        {
            // TODO uncomment below to test "IsType" Customer
            //Assert.IsType<Customer>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'GroupId'
        /// </summary>
        [Fact]
        public void GroupIdTest()
        {
            // TODO unit test for the property 'GroupId'
        }
        /// <summary>
        /// Test the property 'DefaultPaymentMethodId'
        /// </summary>
        [Fact]
        public void DefaultPaymentMethodIdTest()
        {
            // TODO unit test for the property 'DefaultPaymentMethodId'
        }
        /// <summary>
        /// Test the property 'SalesChannelId'
        /// </summary>
        [Fact]
        public void SalesChannelIdTest()
        {
            // TODO unit test for the property 'SalesChannelId'
        }
        /// <summary>
        /// Test the property 'LanguageId'
        /// </summary>
        [Fact]
        public void LanguageIdTest()
        {
            // TODO unit test for the property 'LanguageId'
        }
        /// <summary>
        /// Test the property 'LastPaymentMethodId'
        /// </summary>
        [Fact]
        public void LastPaymentMethodIdTest()
        {
            // TODO unit test for the property 'LastPaymentMethodId'
        }
        /// <summary>
        /// Test the property 'DefaultBillingAddressId'
        /// </summary>
        [Fact]
        public void DefaultBillingAddressIdTest()
        {
            // TODO unit test for the property 'DefaultBillingAddressId'
        }
        /// <summary>
        /// Test the property 'DefaultShippingAddressId'
        /// </summary>
        [Fact]
        public void DefaultShippingAddressIdTest()
        {
            // TODO unit test for the property 'DefaultShippingAddressId'
        }
        /// <summary>
        /// Test the property 'CustomerNumber'
        /// </summary>
        [Fact]
        public void CustomerNumberTest()
        {
            // TODO unit test for the property 'CustomerNumber'
        }
        /// <summary>
        /// Test the property 'SalutationId'
        /// </summary>
        [Fact]
        public void SalutationIdTest()
        {
            // TODO unit test for the property 'SalutationId'
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Fact]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Fact]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'Company'
        /// </summary>
        [Fact]
        public void CompanyTest()
        {
            // TODO unit test for the property 'Company'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'VatIds'
        /// </summary>
        [Fact]
        public void VatIdsTest()
        {
            // TODO unit test for the property 'VatIds'
        }
        /// <summary>
        /// Test the property 'AffiliateCode'
        /// </summary>
        [Fact]
        public void AffiliateCodeTest()
        {
            // TODO unit test for the property 'AffiliateCode'
        }
        /// <summary>
        /// Test the property 'CampaignCode'
        /// </summary>
        [Fact]
        public void CampaignCodeTest()
        {
            // TODO unit test for the property 'CampaignCode'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Fact]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'DoubleOptInRegistration'
        /// </summary>
        [Fact]
        public void DoubleOptInRegistrationTest()
        {
            // TODO unit test for the property 'DoubleOptInRegistration'
        }
        /// <summary>
        /// Test the property 'DoubleOptInEmailSentDate'
        /// </summary>
        [Fact]
        public void DoubleOptInEmailSentDateTest()
        {
            // TODO unit test for the property 'DoubleOptInEmailSentDate'
        }
        /// <summary>
        /// Test the property 'DoubleOptInConfirmDate'
        /// </summary>
        [Fact]
        public void DoubleOptInConfirmDateTest()
        {
            // TODO unit test for the property 'DoubleOptInConfirmDate'
        }
        /// <summary>
        /// Test the property 'Hash'
        /// </summary>
        [Fact]
        public void HashTest()
        {
            // TODO unit test for the property 'Hash'
        }
        /// <summary>
        /// Test the property 'Guest'
        /// </summary>
        [Fact]
        public void GuestTest()
        {
            // TODO unit test for the property 'Guest'
        }
        /// <summary>
        /// Test the property 'FirstLogin'
        /// </summary>
        [Fact]
        public void FirstLoginTest()
        {
            // TODO unit test for the property 'FirstLogin'
        }
        /// <summary>
        /// Test the property 'LastLogin'
        /// </summary>
        [Fact]
        public void LastLoginTest()
        {
            // TODO unit test for the property 'LastLogin'
        }
        /// <summary>
        /// Test the property 'Newsletter'
        /// </summary>
        [Fact]
        public void NewsletterTest()
        {
            // TODO unit test for the property 'Newsletter'
        }
        /// <summary>
        /// Test the property 'Birthday'
        /// </summary>
        [Fact]
        public void BirthdayTest()
        {
            // TODO unit test for the property 'Birthday'
        }
        /// <summary>
        /// Test the property 'LastOrderDate'
        /// </summary>
        [Fact]
        public void LastOrderDateTest()
        {
            // TODO unit test for the property 'LastOrderDate'
        }
        /// <summary>
        /// Test the property 'OrderCount'
        /// </summary>
        [Fact]
        public void OrderCountTest()
        {
            // TODO unit test for the property 'OrderCount'
        }
        /// <summary>
        /// Test the property 'CustomFields'
        /// </summary>
        [Fact]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }
        /// <summary>
        /// Test the property 'TagIds'
        /// </summary>
        [Fact]
        public void TagIdsTest()
        {
            // TODO unit test for the property 'TagIds'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'Group'
        /// </summary>
        [Fact]
        public void GroupTest()
        {
            // TODO unit test for the property 'Group'
        }
        /// <summary>
        /// Test the property 'DefaultPaymentMethod'
        /// </summary>
        [Fact]
        public void DefaultPaymentMethodTest()
        {
            // TODO unit test for the property 'DefaultPaymentMethod'
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }
        /// <summary>
        /// Test the property 'LastPaymentMethod'
        /// </summary>
        [Fact]
        public void LastPaymentMethodTest()
        {
            // TODO unit test for the property 'LastPaymentMethod'
        }
        /// <summary>
        /// Test the property 'DefaultBillingAddress'
        /// </summary>
        [Fact]
        public void DefaultBillingAddressTest()
        {
            // TODO unit test for the property 'DefaultBillingAddress'
        }
        /// <summary>
        /// Test the property 'DefaultShippingAddress'
        /// </summary>
        [Fact]
        public void DefaultShippingAddressTest()
        {
            // TODO unit test for the property 'DefaultShippingAddress'
        }
        /// <summary>
        /// Test the property 'Salutation'
        /// </summary>
        [Fact]
        public void SalutationTest()
        {
            // TODO unit test for the property 'Salutation'
        }
        /// <summary>
        /// Test the property 'Addresses'
        /// </summary>
        [Fact]
        public void AddressesTest()
        {
            // TODO unit test for the property 'Addresses'
        }

    }

}