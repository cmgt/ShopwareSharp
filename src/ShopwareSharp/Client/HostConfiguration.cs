/*
 * Shopware Store API
 *
 * This endpoint reference contains an overview of all endpoints comprising the Shopware Store API
 *
 * The version of the OpenAPI document: 6.4.9999999.9999999-dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using ShopwareSharp.Api;
using ShopwareSharp.Model;

namespace ShopwareSharp.Client
{
    /// <summary>
    /// Provides hosting configuration for ShopwareSharp
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection services;

        private readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull};

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            this.services = services;
            jsonOptions.Converters.Add(new JsonStringEnumConverter());
            jsonOptions.Converters.Add(new OpenAPIDateJsonConverter());
            jsonOptions.Converters.Add(new CartJsonConverter());
            jsonOptions.Converters.Add(new CartItemsJsonConverter());
            jsonOptions.Converters.Add(new EntitySearchResultJsonConverter());
            jsonOptions.Converters.Add(new LinkJsonConverter());
            jsonOptions.Converters.Add(new ProductListingCriteriaJsonConverter());
            jsonOptions.Converters.Add(new ProductListingResultJsonConverter());
            jsonOptions.Converters.Add(new ReadCategoryList200ResponseJsonConverter());
            jsonOptions.Converters.Add(new ReadCategoryRequestJsonConverter());
            jsonOptions.Converters.Add(new ReadCmsRequestJsonConverter());
            jsonOptions.Converters.Add(new ReadCountry200ResponseJsonConverter());
            jsonOptions.Converters.Add(new ReadCurrency200ResponseJsonConverter());
            jsonOptions.Converters.Add(new ReadCustomerRequestJsonConverter());
            jsonOptions.Converters.Add(new ReadLandingPageRequestJsonConverter());
            jsonOptions.Converters.Add(new ReadLanguages200ResponseJsonConverter());
            jsonOptions.Converters.Add(new ReadNavigationRequestJsonConverter());
            jsonOptions.Converters.Add(new ReadOrderRequestJsonConverter());
            jsonOptions.Converters.Add(new ReadPaymentMethodRequestJsonConverter());
            jsonOptions.Converters.Add(new ReadProduct200ResponseJsonConverter());
            jsonOptions.Converters.Add(new ReadProductListingRequestJsonConverter());
            jsonOptions.Converters.Add(new ReadProductReviews200ResponseJsonConverter());
            jsonOptions.Converters.Add(new ReadSalutation200ResponseJsonConverter());
            jsonOptions.Converters.Add(new ReadSeoUrl200ResponseJsonConverter());
            jsonOptions.Converters.Add(new RelationshipLinksSelfJsonConverter());
            jsonOptions.Converters.Add(new SalesChannelContextJsonConverter());
            jsonOptions.Converters.Add(new SearchPageRequestJsonConverter());
            jsonOptions.Converters.Add(new SearchSuggestRequestJsonConverter());
            jsonOptions.Converters.Add(new SitemapJsonConverter());
            jsonOptions.Converters.Add(new SuccessLinksJsonConverter());
            this.services.AddSingleton(new JsonSerializerOptionsProvider(jsonOptions));
            this.services.AddSingleton<ICartApi, CartApi>();
            this.services.AddSingleton<IOrderApi, OrderApi>();
            this.services.AddSingleton<IPaymentMethodApi, PaymentMethodApi>();
            this.services.AddSingleton<IPaymentShippingApi, PaymentShippingApi>();
            this.services.AddSingleton<IProductApi, ProductApi>();
            this.services.AddSingleton<ILoginRegistrationApi, LoginRegistrationApi>();
            this.services.AddSingleton<ISystemContextApi, SystemContextApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients<TCartApi, TOrderApi, TPaymentMethodApi, TPaymentShippingApi,
            TProductApi, TLoginRegistrationApi, TSystemContextApi>
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
            where TCartApi : class, ICartApi
            where TOrderApi : class, IOrderApi
            where TPaymentMethodApi : class, IPaymentMethodApi
            where TPaymentShippingApi : class, IPaymentShippingApi
            where TProductApi : class, IProductApi
            where TLoginRegistrationApi : class, ILoginRegistrationApi
            where TSystemContextApi : class, ISystemContextApi
        {
            client ??= c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            var builders = new[]
            {
                services.AddHttpClient<ICartApi, TCartApi>(client),
                services.AddHttpClient<IOrderApi, TOrderApi>(client),
                services.AddHttpClient<IPaymentMethodApi, TPaymentMethodApi>(client),
                services.AddHttpClient<IPaymentShippingApi, TPaymentShippingApi>(client),
                services.AddHttpClient<IProductApi, TProductApi>(client),
                services.AddHttpClient<ILoginRegistrationApi, TLoginRegistrationApi>(client),
                services.AddHttpClient<ISystemContextApi, TSystemContextApi>(client)
            };

            if (builder != null)
                foreach (var instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients(Action<HttpClient>? client = null,
            Action<IHttpClientBuilder>? builder = null)
        {
            AddApiHttpClients<CartApi, OrderApi, PaymentMethodApi, PaymentShippingApi, ProductApi,
                LoginRegistrationApi, SystemContextApi>(client, builder);

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            services.AddSingleton<TTokenProvider>();
            services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
