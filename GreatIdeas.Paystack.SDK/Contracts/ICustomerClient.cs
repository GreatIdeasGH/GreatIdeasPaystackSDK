using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;
using GreatIdeas.Paystack.SDK.Models.Customers;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ICustomerClient
{
    /// <summary>
    /// Create Customer
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CreateAsync(CustomerCreate body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create Customer
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CreateAsync(CustomerCreate body, CancellationToken cancellationToken);

    /// <summary>
    /// List Customers
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ListAsync(bool? use_cursor, string next, string previous, string from, string to, string perPage, string page);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List Customers
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ListAsync(bool? use_cursor, string next, string previous, string from, string to, string perPage, string page, CancellationToken cancellationToken);

    /// <summary>
    /// Fetch Customer
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(string code);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Customer
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(string code, CancellationToken cancellationToken);

    /// <summary>
    /// Update Customer
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UpdateAsync(CustomerUpdate body, string code);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update Customer
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UpdateAsync(CustomerUpdate body, string code, CancellationToken cancellationToken);

    /// <summary>
    /// White/blacklist Customer
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> RiskActionAsync(CustomerRiskAction body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// White/blacklist Customer
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> RiskActionAsync(CustomerRiskAction body, CancellationToken cancellationToken);

    /// <summary>
    /// Deactivate Authorization
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> DeactivateAuthorizationAsync(CustomerDeactivateAuthorization body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Deactivate Authorization
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> DeactivateAuthorizationAsync(CustomerDeactivateAuthorization body, CancellationToken cancellationToken);

    /// <summary>
    /// Validate Customer
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ValidatteAsync(CustomerValidation body, string code);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Validate Customer
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ValidatteAsync(CustomerValidation body, string code, CancellationToken cancellationToken);

}