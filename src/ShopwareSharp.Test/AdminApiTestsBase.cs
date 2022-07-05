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
                "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiJhZG1pbmlzdHJhdGlvbiIsImp0aSI6IjEyYmEyYTI0YjgzZGRjNWMwYmU0MTRkNGM2NzJmODJhZDE5NTJmMWVmZTlkZGVmMjliYjNiYmU2NDQyNmZlOTYyY2FlNjQyMWYxYTI1OGJlIiwiaWF0IjoxNjU3MDI2MDY4LjcwMDEzNSwibmJmIjoxNjU3MDI2MDY4LjcwMDE0LCJleHAiOjE2NTcwMjY2NjguNjU3MDc4LCJzdWIiOiI2OWY0Zjc0NmVkOWY0MjE0YWRmYzk5NDA0MWE2YWFiNiIsInNjb3BlcyI6WyJ3cml0ZSIsImFkbWluIl19.dj38DbE8ojXZqDOgK_o-TFZkfqYPLzOCSqgins6v7dUHVGLgdKQOISZraCCN6gb-lu9M2yMDXbiwvt2Vfu-7FrnuWCZf6SH43NLLO7HWvnZC_ds0srJTtC0I2e8VI4ZECT1Hlq0dgOZlYNxLzUDO8MRPxH2UqSvWZ8r4rdaOplR93m3dYoGpebtOoWkNM62ykY-kwulxz0UN6kUl_3YQDnWChRYWPbQEOVoiwXfze6MDo1QheRPkUlcg58dwkVyaHJbvprFMf3fGVS3EKmh-yFzKNDtwqDsJWTdZRYzrU9KadMLAU2FlK60AYBUq0kxqptSYcZi4Q0Yj1OQS6yNsGg"));

            options.AddApiHttpClients(c => c.BaseAddress = new Uri("https://stage.shopware.cledeploy.com/api"));

        });
}