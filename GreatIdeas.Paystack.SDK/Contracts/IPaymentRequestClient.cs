using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;
using GreatIdeas.Paystack.SDK.Models.PaymentRequests;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IPaymentRequestClient
{
    /// <summary>
    /// Create Payment Request
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CreateAsync(PaymentRequestCreate body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create Payment Request
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CreateAsync(PaymentRequestCreate body, CancellationToken cancellationToken);

    /// <summary>
    /// List Payment Request
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="customer">Customer ID</param>
    /// <param name="status">Invoice status to filter</param>
    /// <param name="currency">If your integration supports more than one currency, choose the one to filter</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ListAsync(int? perPage, int? page, string customer, string status, string currency, DateTime? from, DateTime? to);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List Payment Request
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="customer">Customer ID</param>
    /// <param name="status">Invoice status to filter</param>
    /// <param name="currency">If your integration supports more than one currency, choose the one to filter</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ListAsync(int? perPage, int? page, string customer, string status, string currency, DateTime? from, DateTime? to, CancellationToken cancellationToken);

    /// <summary>
    /// Fetch Payment Request
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Payment Request
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(string id, CancellationToken cancellationToken);

    /// <summary>
    /// Update Payment Request
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UpdateAsync(PaymentRequestUpdate body, string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update Payment Request
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UpdateAsync(PaymentRequestUpdate body, string id, CancellationToken cancellationToken);

    /// <summary>
    /// Verify Payment Request
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> VerifyAsync(string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Verify Payment Request
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> VerifyAsync(string id, CancellationToken cancellationToken);

    /// <summary>
    /// Send Notification
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> NotifyAsync(string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Send Notification
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> NotifyAsync(string id, CancellationToken cancellationToken);

    /// <summary>
    /// Payment Request Total
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> TotalsAsync();

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Payment Request Total
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> TotalsAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Finalize Payment Request
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FinalizeAsync(string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Finalize Payment Request
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FinalizeAsync(string id, CancellationToken cancellationToken);

    /// <summary>
    /// Archive Payment Request
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ArchiveAsync(string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Archive Payment Request
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ArchiveAsync(string id, CancellationToken cancellationToken);

}