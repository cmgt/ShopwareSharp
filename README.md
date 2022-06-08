# ShopwareSharp - the C# library for the Shopware Store API

This endpoint reference contains an overview of all endpoints comprising the Shopware Store API

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 6.4.9999999.9999999-dev
- SDK version: 0.1.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```
<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out ShopwareSharp.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each ApiClass (properly the ApiClient inside it) will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manager the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory.

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll loose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ShopwareSharp.Api;
using ShopwareSharp.Client;
using ShopwareSharp.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost/store-api";
            // Configure API key authorization: ApiKey
            config.ApiKey.Add("sw-access-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("sw-access-key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CartApi(httpClient, config, httpClientHandler);
            var contentType = "\"application/json\"";  // string | Content type of the request (default to "application/json")
            var accept = "\"application/json\"";  // string | Accepted response content types (default to "application/json")
            var cartItems = new CartItems?(); // CartItems? |  (optional) 

            try
            {
                // Add items to the cart
                Cart result = apiInstance.AddLineItem(contentType, accept, cartItems);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CartApi.AddLineItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost/store-api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CartApi* | [**AddLineItem**](docs/CartApi.md#addlineitem) | **POST** /checkout/cart/line-item | Add items to the cart
*CartApi* | [**DeleteCart**](docs/CartApi.md#deletecart) | **DELETE** /checkout/cart | Delete a cart
*CartApi* | [**ReadCart**](docs/CartApi.md#readcart) | **GET** /checkout/cart | Fetch or create a cart
*CartApi* | [**RemoveLineItem**](docs/CartApi.md#removelineitem) | **DELETE** /checkout/cart/line-item | Remove items from the cart
*CartApi* | [**UpdateLineItem**](docs/CartApi.md#updatelineitem) | **PATCH** /checkout/cart/line-item | Update items in the cart
*OrderApi* | [**CancelOrder**](docs/OrderApi.md#cancelorder) | **POST** /order/state/cancel | Cancel an order
*OrderApi* | [**CreateOrder**](docs/OrderApi.md#createorder) | **POST** /checkout/order | Create an order from a cart
*OrderApi* | [**OrderSetPayment**](docs/OrderApi.md#ordersetpayment) | **POST** /order/payment | Update the payment method of an order
*OrderApi* | [**ReadOrder**](docs/OrderApi.md#readorder) | **POST** /order | Fetch a list of orders
*PaymentMethodApi* | [**ReadPaymentMethod**](docs/PaymentMethodApi.md#readpaymentmethod) | **POST** /payment-method | Loads all available payment methods
*PaymentShippingApi* | [**HandlePaymentMethod**](docs/PaymentShippingApi.md#handlepaymentmethod) | **POST** /handle-payment | Initiate a payment for an order
*PaymentShippingApi* | [**ReadShippingMethod**](docs/PaymentShippingApi.md#readshippingmethod) | **POST** /shipping-method | Fetch shipping methods
*ProductApi* | [**ReadProduct**](docs/ProductApi.md#readproduct) | **POST** /product | Fetch a list of products
*ProductApi* | [**ReadProductCrossSellings**](docs/ProductApi.md#readproductcrosssellings) | **POST** /product/{productId}/cross-selling | Fetch cross-selling groups of a product
*ProductApi* | [**ReadProductDetail**](docs/ProductApi.md#readproductdetail) | **POST** /product/{productId} | Fetch a single product
*ProductApi* | [**ReadProductExport**](docs/ProductApi.md#readproductexport) | **GET** /product-export/{accessKey}/{fileName} | Export product export
*ProductApi* | [**ReadProductListing**](docs/ProductApi.md#readproductlisting) | **POST** /product-listing/{categoryId} | Fetch a product listing by category
*ProductApi* | [**ReadProductReviews**](docs/ProductApi.md#readproductreviews) | **POST** /product/{productId}/reviews | Fetch product reviews
*ProductApi* | [**SaveProductReview**](docs/ProductApi.md#saveproductreview) | **POST** /product/{productId}/review | Save a product review
*ProductApi* | [**SearchPage**](docs/ProductApi.md#searchpage) | **POST** /search | Search for products
*ProductApi* | [**SearchSuggest**](docs/ProductApi.md#searchsuggest) | **POST** /search-suggest | Search for products (suggest)


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AclRole](docs/AclRole.md)
 - [Model.App](docs/App.md)
 - [Model.AppActionButton](docs/AppActionButton.md)
 - [Model.AppPaymentMethod](docs/AppPaymentMethod.md)
 - [Model.AppTemplate](docs/AppTemplate.md)
 - [Model.ArrayStruct](docs/ArrayStruct.md)
 - [Model.CancelOrderRequest](docs/CancelOrderRequest.md)
 - [Model.Cart](docs/Cart.md)
 - [Model.CartAllOf](docs/CartAllOf.md)
 - [Model.CartAllOfErrors](docs/CartAllOfErrors.md)
 - [Model.CartAllOfPrice](docs/CartAllOfPrice.md)
 - [Model.CartAllOfTransactions](docs/CartAllOfTransactions.md)
 - [Model.CartItems](docs/CartItems.md)
 - [Model.CartItemsAllOf](docs/CartItemsAllOf.md)
 - [Model.Category](docs/Category.md)
 - [Model.CategoryJsonApi](docs/CategoryJsonApi.md)
 - [Model.CategoryJsonApiAllOf](docs/CategoryJsonApiAllOf.md)
 - [Model.ChangeEmailRequest](docs/ChangeEmailRequest.md)
 - [Model.ChangePasswordRequest](docs/ChangePasswordRequest.md)
 - [Model.ChangeProfileRequest](docs/ChangeProfileRequest.md)
 - [Model.CmsBlock](docs/CmsBlock.md)
 - [Model.CmsPage](docs/CmsPage.md)
 - [Model.CmsPageConfig](docs/CmsPageConfig.md)
 - [Model.CmsSection](docs/CmsSection.md)
 - [Model.CmsSlot](docs/CmsSlot.md)
 - [Model.ConfirmNewsletterRequest](docs/ConfirmNewsletterRequest.md)
 - [Model.ContextTokenResponse](docs/ContextTokenResponse.md)
 - [Model.Country](docs/Country.md)
 - [Model.CountryJsonApi](docs/CountryJsonApi.md)
 - [Model.CountryJsonApiAllOf](docs/CountryJsonApiAllOf.md)
 - [Model.CountryState](docs/CountryState.md)
 - [Model.CountryStateJsonApi](docs/CountryStateJsonApi.md)
 - [Model.CountryStateJsonApiAllOf](docs/CountryStateJsonApiAllOf.md)
 - [Model.CreateOrderRequest](docs/CreateOrderRequest.md)
 - [Model.Criteria](docs/Criteria.md)
 - [Model.CriteriaAggregationsInner](docs/CriteriaAggregationsInner.md)
 - [Model.CriteriaFilterInner](docs/CriteriaFilterInner.md)
 - [Model.CriteriaSortInner](docs/CriteriaSortInner.md)
 - [Model.CrossSellingElementCollectionInner](docs/CrossSellingElementCollectionInner.md)
 - [Model.CrossSellingElementCollectionInnerCrossSelling](docs/CrossSellingElementCollectionInnerCrossSelling.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.CurrencyCountryRounding](docs/CurrencyCountryRounding.md)
 - [Model.CurrencyJsonApi](docs/CurrencyJsonApi.md)
 - [Model.CurrencyJsonApiAllOf](docs/CurrencyJsonApiAllOf.md)
 - [Model.CustomField](docs/CustomField.md)
 - [Model.CustomFieldSet](docs/CustomFieldSet.md)
 - [Model.CustomFieldSetRelation](docs/CustomFieldSetRelation.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.CustomerAddress](docs/CustomerAddress.md)
 - [Model.CustomerGroup](docs/CustomerGroup.md)
 - [Model.CustomerRecovery](docs/CustomerRecovery.md)
 - [Model.CustomerTag](docs/CustomerTag.md)
 - [Model.CustomerWishlist](docs/CustomerWishlist.md)
 - [Model.CustomerWishlistProduct](docs/CustomerWishlistProduct.md)
 - [Model.Data](docs/Data.md)
 - [Model.DeadMessage](docs/DeadMessage.md)
 - [Model.DeliveryTime](docs/DeliveryTime.md)
 - [Model.Document](docs/Document.md)
 - [Model.DocumentBaseConfig](docs/DocumentBaseConfig.md)
 - [Model.DocumentBaseConfigSalesChannel](docs/DocumentBaseConfigSalesChannel.md)
 - [Model.DocumentType](docs/DocumentType.md)
 - [Model.EntitySearchResult](docs/EntitySearchResult.md)
 - [Model.EntitySearchResultAllOf](docs/EntitySearchResultAllOf.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorSource](docs/ErrorSource.md)
 - [Model.EventAction](docs/EventAction.md)
 - [Model.Failure](docs/Failure.md)
 - [Model.HandlePaymentMethodRequest](docs/HandlePaymentMethodRequest.md)
 - [Model.ImportExportFile](docs/ImportExportFile.md)
 - [Model.ImportExportLog](docs/ImportExportLog.md)
 - [Model.ImportExportProfile](docs/ImportExportProfile.md)
 - [Model.Info](docs/Info.md)
 - [Model.Integration](docs/Integration.md)
 - [Model.Jsonapi](docs/Jsonapi.md)
 - [Model.LandingPage](docs/LandingPage.md)
 - [Model.LandingPageJsonApi](docs/LandingPageJsonApi.md)
 - [Model.LandingPageJsonApiAllOf](docs/LandingPageJsonApiAllOf.md)
 - [Model.Language](docs/Language.md)
 - [Model.LanguageJsonApi](docs/LanguageJsonApi.md)
 - [Model.LanguageJsonApiAllOf](docs/LanguageJsonApiAllOf.md)
 - [Model.LineItem](docs/LineItem.md)
 - [Model.Link](docs/Link.md)
 - [Model.LinkOneOf](docs/LinkOneOf.md)
 - [Model.Linkage](docs/Linkage.md)
 - [Model.Locale](docs/Locale.md)
 - [Model.LogEntry](docs/LogEntry.md)
 - [Model.LoginCustomerRequest](docs/LoginCustomerRequest.md)
 - [Model.MailHeaderFooter](docs/MailHeaderFooter.md)
 - [Model.MailTemplate](docs/MailTemplate.md)
 - [Model.MailTemplateMedia](docs/MailTemplateMedia.md)
 - [Model.MailTemplateType](docs/MailTemplateType.md)
 - [Model.MainCategory](docs/MainCategory.md)
 - [Model.MainCategoryJsonApi](docs/MainCategoryJsonApi.md)
 - [Model.MainCategoryJsonApiAllOf](docs/MainCategoryJsonApiAllOf.md)
 - [Model.Media](docs/Media.md)
 - [Model.MediaDefaultFolder](docs/MediaDefaultFolder.md)
 - [Model.MediaFolder](docs/MediaFolder.md)
 - [Model.MediaFolderConfiguration](docs/MediaFolderConfiguration.md)
 - [Model.MediaTag](docs/MediaTag.md)
 - [Model.MediaThumbnail](docs/MediaThumbnail.md)
 - [Model.MediaThumbnailSize](docs/MediaThumbnailSize.md)
 - [Model.MergeProductOnWishlistRequest](docs/MergeProductOnWishlistRequest.md)
 - [Model.MessageQueueStats](docs/MessageQueueStats.md)
 - [Model.NewsletterRecipient](docs/NewsletterRecipient.md)
 - [Model.NumberRange](docs/NumberRange.md)
 - [Model.NumberRangeSalesChannel](docs/NumberRangeSalesChannel.md)
 - [Model.NumberRangeState](docs/NumberRangeState.md)
 - [Model.NumberRangeType](docs/NumberRangeType.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderAddress](docs/OrderAddress.md)
 - [Model.OrderCustomer](docs/OrderCustomer.md)
 - [Model.OrderDelivery](docs/OrderDelivery.md)
 - [Model.OrderDeliveryPosition](docs/OrderDeliveryPosition.md)
 - [Model.OrderLineItem](docs/OrderLineItem.md)
 - [Model.OrderPrice](docs/OrderPrice.md)
 - [Model.OrderRouteResponse](docs/OrderRouteResponse.md)
 - [Model.OrderSetPaymentRequest](docs/OrderSetPaymentRequest.md)
 - [Model.OrderShippingCosts](docs/OrderShippingCosts.md)
 - [Model.OrderShippingCostsListPrice](docs/OrderShippingCostsListPrice.md)
 - [Model.OrderTag](docs/OrderTag.md)
 - [Model.OrderTransaction](docs/OrderTransaction.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.PaymentMethod](docs/PaymentMethod.md)
 - [Model.PaymentMethodJsonApi](docs/PaymentMethodJsonApi.md)
 - [Model.PaymentMethodJsonApiAllOf](docs/PaymentMethodJsonApiAllOf.md)
 - [Model.Plugin](docs/Plugin.md)
 - [Model.Product](docs/Product.md)
 - [Model.ProductConfiguratorSetting](docs/ProductConfiguratorSetting.md)
 - [Model.ProductCrossSelling](docs/ProductCrossSelling.md)
 - [Model.ProductCrossSellingAssignedProducts](docs/ProductCrossSellingAssignedProducts.md)
 - [Model.ProductDetailResponse](docs/ProductDetailResponse.md)
 - [Model.ProductExport](docs/ProductExport.md)
 - [Model.ProductFeatureSet](docs/ProductFeatureSet.md)
 - [Model.ProductJsonApi](docs/ProductJsonApi.md)
 - [Model.ProductJsonApiAllOf](docs/ProductJsonApiAllOf.md)
 - [Model.ProductKeywordDictionary](docs/ProductKeywordDictionary.md)
 - [Model.ProductListingCriteria](docs/ProductListingCriteria.md)
 - [Model.ProductListingCriteriaAllOf](docs/ProductListingCriteriaAllOf.md)
 - [Model.ProductListingFlags](docs/ProductListingFlags.md)
 - [Model.ProductListingResult](docs/ProductListingResult.md)
 - [Model.ProductListingResultAllOf](docs/ProductListingResultAllOf.md)
 - [Model.ProductListingResultAllOfCurrentFilters](docs/ProductListingResultAllOfCurrentFilters.md)
 - [Model.ProductListingResultAllOfCurrentFiltersPrice](docs/ProductListingResultAllOfCurrentFiltersPrice.md)
 - [Model.ProductManufacturer](docs/ProductManufacturer.md)
 - [Model.ProductMedia](docs/ProductMedia.md)
 - [Model.ProductPrice](docs/ProductPrice.md)
 - [Model.ProductReview](docs/ProductReview.md)
 - [Model.ProductSearchConfig](docs/ProductSearchConfig.md)
 - [Model.ProductSearchConfigField](docs/ProductSearchConfigField.md)
 - [Model.ProductSearchKeyword](docs/ProductSearchKeyword.md)
 - [Model.ProductSorting](docs/ProductSorting.md)
 - [Model.ProductStream](docs/ProductStream.md)
 - [Model.ProductStreamFilter](docs/ProductStreamFilter.md)
 - [Model.ProductVisibility](docs/ProductVisibility.md)
 - [Model.Promotion](docs/Promotion.md)
 - [Model.PromotionDiscount](docs/PromotionDiscount.md)
 - [Model.PromotionDiscountPrices](docs/PromotionDiscountPrices.md)
 - [Model.PromotionIndividualCode](docs/PromotionIndividualCode.md)
 - [Model.PromotionSalesChannel](docs/PromotionSalesChannel.md)
 - [Model.PromotionSetgroup](docs/PromotionSetgroup.md)
 - [Model.PropertyGroup](docs/PropertyGroup.md)
 - [Model.PropertyGroupOption](docs/PropertyGroupOption.md)
 - [Model.ReadCategoryList200Response](docs/ReadCategoryList200Response.md)
 - [Model.ReadCategoryList200ResponseAllOf](docs/ReadCategoryList200ResponseAllOf.md)
 - [Model.ReadCategoryRequest](docs/ReadCategoryRequest.md)
 - [Model.ReadCmsRequest](docs/ReadCmsRequest.md)
 - [Model.ReadCmsRequestAllOf](docs/ReadCmsRequestAllOf.md)
 - [Model.ReadCountry200Response](docs/ReadCountry200Response.md)
 - [Model.ReadCountry200ResponseAllOf](docs/ReadCountry200ResponseAllOf.md)
 - [Model.ReadCurrency200Response](docs/ReadCurrency200Response.md)
 - [Model.ReadCurrency200ResponseAllOf](docs/ReadCurrency200ResponseAllOf.md)
 - [Model.ReadCustomerRequest](docs/ReadCustomerRequest.md)
 - [Model.ReadLandingPageRequest](docs/ReadLandingPageRequest.md)
 - [Model.ReadLanguages200Response](docs/ReadLanguages200Response.md)
 - [Model.ReadLanguages200ResponseAllOf](docs/ReadLanguages200ResponseAllOf.md)
 - [Model.ReadNavigationRequest](docs/ReadNavigationRequest.md)
 - [Model.ReadNavigationRequestAllOf](docs/ReadNavigationRequestAllOf.md)
 - [Model.ReadOrderRequest](docs/ReadOrderRequest.md)
 - [Model.ReadOrderRequestAllOf](docs/ReadOrderRequestAllOf.md)
 - [Model.ReadPaymentMethod200Response](docs/ReadPaymentMethod200Response.md)
 - [Model.ReadPaymentMethodRequest](docs/ReadPaymentMethodRequest.md)
 - [Model.ReadPaymentMethodRequestAllOf](docs/ReadPaymentMethodRequestAllOf.md)
 - [Model.ReadProduct200Response](docs/ReadProduct200Response.md)
 - [Model.ReadProduct200ResponseAllOf](docs/ReadProduct200ResponseAllOf.md)
 - [Model.ReadProductListingRequest](docs/ReadProductListingRequest.md)
 - [Model.ReadProductReviews200Response](docs/ReadProductReviews200Response.md)
 - [Model.ReadProductReviews200ResponseAllOf](docs/ReadProductReviews200ResponseAllOf.md)
 - [Model.ReadSalutation200Response](docs/ReadSalutation200Response.md)
 - [Model.ReadSalutation200ResponseAllOf](docs/ReadSalutation200ResponseAllOf.md)
 - [Model.ReadSeoUrl200Response](docs/ReadSeoUrl200Response.md)
 - [Model.ReadSeoUrl200ResponseAllOf](docs/ReadSeoUrl200ResponseAllOf.md)
 - [Model.ReadShippingMethod200Response](docs/ReadShippingMethod200Response.md)
 - [Model.RecoveryPasswordRequest](docs/RecoveryPasswordRequest.md)
 - [Model.RegisterConfirmRequest](docs/RegisterConfirmRequest.md)
 - [Model.RegisterRequest](docs/RegisterRequest.md)
 - [Model.RelationshipLinks](docs/RelationshipLinks.md)
 - [Model.RelationshipLinksSelf](docs/RelationshipLinksSelf.md)
 - [Model.RelationshipToOne](docs/RelationshipToOne.md)
 - [Model.Relationships](docs/Relationships.md)
 - [Model.RelationshipsAnyOf](docs/RelationshipsAnyOf.md)
 - [Model.Resource](docs/Resource.md)
 - [Model.Rule](docs/Rule.md)
 - [Model.RuleCondition](docs/RuleCondition.md)
 - [Model.SalesChannel](docs/SalesChannel.md)
 - [Model.SalesChannelAnalytics](docs/SalesChannelAnalytics.md)
 - [Model.SalesChannelContext](docs/SalesChannelContext.md)
 - [Model.SalesChannelContextAllOf](docs/SalesChannelContextAllOf.md)
 - [Model.SalesChannelContextAllOfContext](docs/SalesChannelContextAllOfContext.md)
 - [Model.SalesChannelContextAllOfCurrency](docs/SalesChannelContextAllOfCurrency.md)
 - [Model.SalesChannelContextAllOfCurrentCustomerGroup](docs/SalesChannelContextAllOfCurrentCustomerGroup.md)
 - [Model.SalesChannelContextAllOfCustomer](docs/SalesChannelContextAllOfCustomer.md)
 - [Model.SalesChannelContextAllOfFallbackCustomerGroup](docs/SalesChannelContextAllOfFallbackCustomerGroup.md)
 - [Model.SalesChannelContextAllOfPaymentMethod](docs/SalesChannelContextAllOfPaymentMethod.md)
 - [Model.SalesChannelContextAllOfSalesChannel](docs/SalesChannelContextAllOfSalesChannel.md)
 - [Model.SalesChannelContextAllOfShippingMethod](docs/SalesChannelContextAllOfShippingMethod.md)
 - [Model.SalesChannelContextAllOfTaxRules](docs/SalesChannelContextAllOfTaxRules.md)
 - [Model.SalesChannelDomain](docs/SalesChannelDomain.md)
 - [Model.SalesChannelType](docs/SalesChannelType.md)
 - [Model.Salutation](docs/Salutation.md)
 - [Model.SalutationJsonApi](docs/SalutationJsonApi.md)
 - [Model.SalutationJsonApiAllOf](docs/SalutationJsonApiAllOf.md)
 - [Model.SaveProductReviewRequest](docs/SaveProductReviewRequest.md)
 - [Model.ScheduledTask](docs/ScheduledTask.md)
 - [Model.SearchPageRequest](docs/SearchPageRequest.md)
 - [Model.SearchPageRequestAllOf](docs/SearchPageRequestAllOf.md)
 - [Model.SearchSuggestRequest](docs/SearchSuggestRequest.md)
 - [Model.SendContactMailRequest](docs/SendContactMailRequest.md)
 - [Model.SendRecoveryMailRequest](docs/SendRecoveryMailRequest.md)
 - [Model.SeoUrl](docs/SeoUrl.md)
 - [Model.SeoUrlJsonApi](docs/SeoUrlJsonApi.md)
 - [Model.SeoUrlJsonApiAllOf](docs/SeoUrlJsonApiAllOf.md)
 - [Model.SeoUrlTemplate](docs/SeoUrlTemplate.md)
 - [Model.ShippingMethod](docs/ShippingMethod.md)
 - [Model.ShippingMethodJsonApi](docs/ShippingMethodJsonApi.md)
 - [Model.ShippingMethodJsonApiAllOf](docs/ShippingMethodJsonApiAllOf.md)
 - [Model.ShippingMethodPageRouteResponseInner](docs/ShippingMethodPageRouteResponseInner.md)
 - [Model.ShippingMethodPageRouteResponseInnerAvailabilityRule](docs/ShippingMethodPageRouteResponseInnerAvailabilityRule.md)
 - [Model.ShippingMethodPageRouteResponseInnerDeliveryTime](docs/ShippingMethodPageRouteResponseInnerDeliveryTime.md)
 - [Model.ShippingMethodPageRouteResponseInnerMedia](docs/ShippingMethodPageRouteResponseInnerMedia.md)
 - [Model.ShippingMethodPageRouteResponseInnerOrderDeliveriesInner](docs/ShippingMethodPageRouteResponseInnerOrderDeliveriesInner.md)
 - [Model.ShippingMethodPageRouteResponseInnerPricesInner](docs/ShippingMethodPageRouteResponseInnerPricesInner.md)
 - [Model.ShippingMethodPageRouteResponseInnerSalesChannelDefaultAssignmentsInner](docs/ShippingMethodPageRouteResponseInnerSalesChannelDefaultAssignmentsInner.md)
 - [Model.ShippingMethodPageRouteResponseInnerTagsInner](docs/ShippingMethodPageRouteResponseInnerTagsInner.md)
 - [Model.ShippingMethodPageRouteResponseInnerTranslationsInner](docs/ShippingMethodPageRouteResponseInnerTranslationsInner.md)
 - [Model.ShippingMethodPrice](docs/ShippingMethodPrice.md)
 - [Model.Sitemap](docs/Sitemap.md)
 - [Model.SitemapAllOf](docs/SitemapAllOf.md)
 - [Model.Snippet](docs/Snippet.md)
 - [Model.SnippetSet](docs/SnippetSet.md)
 - [Model.StateMachine](docs/StateMachine.md)
 - [Model.StateMachineHistory](docs/StateMachineHistory.md)
 - [Model.StateMachineState](docs/StateMachineState.md)
 - [Model.StateMachineTransition](docs/StateMachineTransition.md)
 - [Model.SubscribeToNewsletterRequest](docs/SubscribeToNewsletterRequest.md)
 - [Model.Success](docs/Success.md)
 - [Model.SuccessLinks](docs/SuccessLinks.md)
 - [Model.SuccessResponse](docs/SuccessResponse.md)
 - [Model.SystemConfig](docs/SystemConfig.md)
 - [Model.SystemConfigConfigurationValue](docs/SystemConfigConfigurationValue.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.Tax](docs/Tax.md)
 - [Model.TaxRule](docs/TaxRule.md)
 - [Model.TaxRuleType](docs/TaxRuleType.md)
 - [Model.Theme](docs/Theme.md)
 - [Model.Unit](docs/Unit.md)
 - [Model.UnsubscribeToNewsletterRequest](docs/UnsubscribeToNewsletterRequest.md)
 - [Model.UpdateContextRequest](docs/UpdateContextRequest.md)
 - [Model.User](docs/User.md)
 - [Model.UserAccessKey](docs/UserAccessKey.md)
 - [Model.UserConfig](docs/UserConfig.md)
 - [Model.UserRecovery](docs/UserRecovery.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookEventLog](docs/WebhookEventLog.md)
 - [Model.WishlistLoadRouteResponse](docs/WishlistLoadRouteResponse.md)
 - [Model.WishlistLoadRouteResponseWishlist](docs/WishlistLoadRouteResponseWishlist.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKey"></a>
### ApiKey

- **Type**: API key
- **API key parameter name**: sw-access-key
- **Location**: HTTP header

<a name="ContextToken"></a>
### ContextToken

- **Type**: API key
- **API key parameter name**: sw-context-token
- **Location**: HTTP header

