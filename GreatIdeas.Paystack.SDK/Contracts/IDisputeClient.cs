using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;
using GreatIdeas.Paystack.SDK.Models.Disputes;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IDisputeClient
{
    /// <summary>
    /// List Disputes
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="status">Dispute Status. Acceptable values are awaiting-merchant-feedback, awaiting-bank-feedback, pending, resolved</param>
    /// <param name="transaction">Transaction ID</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ListAsync(int? perPage, int? page, string status, string transaction, DateTime? from, DateTime? to);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List Disputes
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="status">Dispute Status. Acceptable values are awaiting-merchant-feedback, awaiting-bank-feedback, pending, resolved</param>
    /// <param name="transaction">Transaction ID</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ListAsync(int? perPage, int? page, string status, string transaction, DateTime? from, DateTime? to, CancellationToken cancellationToken);

    /// <summary>
    /// Fetch Dispute
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Dispute
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(string id, CancellationToken cancellationToken);

    /// <summary>
    /// Update Dispute
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UpdateAsync(DisputeUpdate body, string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Update Dispute
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UpdateAsync(DisputeUpdate body, string id, CancellationToken cancellationToken);

    /// <summary>
    /// Get Upload URL
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UploadUrlAsync(string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get Upload URL
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> UploadUrlAsync(string id, CancellationToken cancellationToken);

    /// <summary>
    /// Export Disputes
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> DownloadAsync(int? perPage, int? page, string status, DateTime? from, DateTime? to);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Export Disputes
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> DownloadAsync(int? perPage, int? page, string status, DateTime? from, DateTime? to, CancellationToken cancellationToken);

    /// <summary>
    /// List Transaction Disputes
    /// </summary>
    /// <param name="id">Transaction ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> TransactionAsync(string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List Transaction Disputes
    /// </summary>
    /// <param name="id">Transaction ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> TransactionAsync(string id, CancellationToken cancellationToken);

    /// <summary>
    /// Resolve a Dispute
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ResolveAsync(string id, DisputeResolve body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Resolve a Dispute
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ResolveAsync(string id, DisputeResolve body, CancellationToken cancellationToken);

    /// <summary>
    /// Add Evidence
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> EvidenceAsync(DisputeEvidence body, string id);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Add Evidence
    /// </summary>
    /// <param name="id">Dispute ID</param>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> EvidenceAsync(DisputeEvidence body, string id, CancellationToken cancellationToken);

}