using System;
using Microsoft.Extensions.Hosting;
using ShopwareSharp.Client;

namespace ShopwareSharp.Test;

/// <summary>
///  Base class for API tests
/// </summary>
public class AdminApiTestsBase
{
    protected readonly IHost _host;

    public AdminApiTestsBase(string[] args)
    {
        _host = CreateHostBuilder(args).Build();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
        .ShopwareConfigureApi((_, options) =>
        {
            options.AddTokens(new OAuthToken(
                "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiJTV0lBQUpWMlpVVFFVTTlKVDBOR01XMURNRyIsImp0aSI6ImY5MWI5NzhiMTM5ZDNkNzZhYjE1NjFjMWIyODg5NmY4OGNlYzJmZThiZjVlZmRiZmZiNDMwMjMxNmQ0MjQzNzIxMWU5ZTAyOGE5YTFmNzRiIiwiaWF0IjoxNjU1OTA0NzA4LjMyNzE2MywibmJmIjoxNjU1OTA0NzA4LjMyNzE2OSwiZXhwIjoxNjU1OTA1MzA4LjMyNTI4Niwic3ViIjoiIiwic2NvcGVzIjpbIndyaXRlIl19.TMyKfHTfDaB59bXh3kEIvZ_0ItEVf3c3tOwKLyk-jU4DSAD1n4pyleSp4IyUQ06J2NQxX0wMMqhRvc1UzSX9VKYsX3kHclgLP49SstXWAj1mMybrJU3Iz5lfmBoN6UEFCOFhxZmcQ6u6T0eWmTOkZqZH0Ji5l4XH_4QRdNqtpwVcm-OGVNwPBXzvfrQJFKdpwqLEuHHW1ykr7XUzhMm5YBaeuiwmux1OqieAt0tImIYhaTRotDOG1KJKvl2ppMvXvR192BnLOg-CGmgGdbIoCLHAEoBmjs5oe3u7WoR96xmsdc_KzcPThqbXQIvSqArCbECw_mPKW6YQTSeeEwb54g"));

            options.AddApiHttpClients(c => c.BaseAddress = new Uri("https://stage.shopware.cledeploy.com/api"));

        });
}