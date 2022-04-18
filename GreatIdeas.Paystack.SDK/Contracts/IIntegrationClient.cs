using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IIntegrationClient
{
    /// <summary>
    /// Fetch Payment Session Timeout
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchPaymentSessionTimeoutAsync();

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Payment Session Timeout
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchPaymentSessionTimeoutAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Update Payment Session Timeout
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UpdatePaymentSessionTimeoutAsync(object body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update Payment Session Timeout
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UpdatePaymentSessionTimeoutAsync(object body, CancellationToken cancellationToken);

}