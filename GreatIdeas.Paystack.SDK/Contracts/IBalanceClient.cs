using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IBalanceClient
{
    /// <summary>
    /// Fetch Balance
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync();

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Balance
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> FetchAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Balance Ledger
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> LedgerAsync(int? perPage, int? page, DateTime? from, DateTime? to);

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Balance Ledger
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> LedgerAsync(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken);

}