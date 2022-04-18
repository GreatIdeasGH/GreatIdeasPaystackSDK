using System.Net.Http.Headers;
using GreatIdeas.Paystack.SDK.Contracts;
using GreatIdeas.Paystack.SDK.Resources.Transactions;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace GreatIdeas.Paystack.SDK;

public static class DependencyInjection
{
    /// <summary>
    /// Register Paystack in the DI container with Polly retry policy. This can be used together with the HttpClientFactory.
    /// </summary>
    /// <param name="services">Paystack services to register</param>
    /// <param name="secretKey">Secret key from Paystack</param>
    public static void AddPaystack(this IServiceCollection services, string secretKey)
    {
        // Add HttpClient 
        services.AddHttpClient(PaystackConstants.PaystackHttpClientName, client =>
            {
                client.BaseAddress = new Uri(PaystackConstants.PaystackBaseEndPoint);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(PaystackConstants.ContentTypeHeaderJson));

                client.DefaultRequestHeaders.Add("cache-control", "no-cache");

                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(PaystackConstants.AuthorizationHeaderType, secretKey);
            })
            .AddTransientHttpErrorPolicy(x =>
                x.WaitAndRetryAsync(3, _ => TimeSpan.FromMilliseconds(300)));

        // Register clients
        services.AddScoped<IPaystackTransaction, PaystackTransaction>();
    }
}