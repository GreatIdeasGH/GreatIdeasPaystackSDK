using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;
using GreatIdeas.Paystack.SDK.Models.TransfersRecipients;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface ITransferRecipientClient
{
    /// <summary>
    /// Create Transfer Recipient
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CreateAsync(TransferRecipientCreate body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Create Transfer Recipient
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> CreateAsync(TransferRecipientCreate body, CancellationToken cancellationToken);

    /// <summary>
    /// List Transfer Recipients
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ListAsync(int? perPage, int? page, DateTime? from, DateTime? to);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List Transfer Recipients
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> ListAsync(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken);

    /// <summary>
    /// Bulk Create Transfer Recipient
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> BulkAsync(TransferRecipientBulk body);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Bulk Create Transfer Recipient
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> BulkAsync(TransferRecipientBulk body, CancellationToken cancellationToken);

    /// <summary>
    /// Fetch Transfer recipient
    /// </summary>
    /// <param name="code">Transfer recipient code</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(string code);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Transfer recipient
    /// </summary>
    /// <param name="code">Transfer recipient code</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(string code, CancellationToken cancellationToken);

}