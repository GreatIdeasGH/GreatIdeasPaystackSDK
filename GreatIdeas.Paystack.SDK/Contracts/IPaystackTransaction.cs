using System.CodeDom.Compiler;
using GreatIdeas.Paystack.SDK.Models;
using GreatIdeas.Paystack.SDK.Models.Transactions;
using GreatIdeas.Paystack.SDK.Resources.Transactions;
using GreatIdeas.Paystack.SDK.Responses.Transactions;

namespace GreatIdeas.Paystack.SDK.Contracts;

[GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public interface IPaystackTransaction
{
    /// <param name="requestModel"><see cref="TransactionInitializeModel"/> Transaction initialize model</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Initialize Transaction
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionInitializeResponse?> InitializeAsync(TransactionInitializeModel requestModel, CancellationToken cancellationToken);

    /// <param name="reference">The transaction reference to verify</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Verify Transaction
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionVerifyResponse> VerifyAsync(string reference, CancellationToken cancellationToken);

    /// <param name="pagingParams"><see cref="PagingParams"/> to paginate the transactions</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List Transactions
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionListResponse> ListAsync(PagingParams pagingParams, CancellationToken cancellationToken);
    
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List Transactions
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionListResponse> ListAsync(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken);


    /// <param name="id">The ID of the transaction to fetch</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Transaction
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionResponse> FetchAsync(string id, CancellationToken cancellationToken);


    /// <param name="idReference">Id or Reference number</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Transaction Timeline
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionLogResponse> TimelineAsync(string idReference, CancellationToken cancellationToken);


    /// <param name="pagingParams"><see cref="PagingParams"/> to paginate the transactions</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Transaction Totals
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionTotalsResponse> TotalsAsync(PagingParams? pagingParams, CancellationToken cancellationToken);
    
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Transaction Totals
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionTotalsResponse> TotalsAsync(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken);


    /// <param name="pagingParams"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Export Transactions
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionDownloadResponse> ExportAsync(PagingParams pagingParams, CancellationToken cancellationToken);
    
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Export Transactions
    /// </summary>
    /// <param name="perPage">Number of records to fetch per page</param>
    /// <param name="page">The section to retrieve</param>
    /// <param name="from">The start date</param>
    /// <param name="to">The end date</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionDownloadResponse> ExportAsync(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken);


    /// <param name="requestModel"><see cref="TransactionChargeAuthorization"/></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Charge Authorization
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionAuthorizationResponse?> ChargeAuthorizationAsync(TransactionChargeAuthorization requestModel,
        CancellationToken cancellationToken);


    /// <param name="requestModel"><see cref="TransactionCheckAuthorization"/></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Check Authorization
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<TransactionAuthorizationResponse?> CheckAuthorizationAsync(TransactionCheckAuthorization requestModel,
        CancellationToken cancellationToken);


    /// <param name="requestModel"><see cref="TransactionPartialDebit"/></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Partial Debit
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response?> PartialDebitAsync(TransactionPartialDebit requestModel, CancellationToken cancellationToken);


    /// <param name="id"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get Transaction Event
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> EventAsync(string id, CancellationToken cancellationToken);


    /// <param name="id"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get Transaction Session
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<Response> SessionAsync(string id, CancellationToken cancellationToken);

}