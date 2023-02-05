using GreatIdeas.Paystack.SDK.Contracts;
using GreatIdeas.Paystack.SDK.Models;
using GreatIdeas.Paystack.SDK.Models.Transactions;
using GreatIdeas.Paystack.SDK.Responses.Transactions;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace GreatIdeas.Paystack.SDK.Resources.Transactions;

public class PaystackTransaction : IPaystackTransaction
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<PaystackTransaction> _logger;

    public PaystackTransaction(IHttpClientFactory httpClientFactory, ILogger<PaystackTransaction> logger)
    {
        _httpClient = httpClientFactory.CreateClient(PaystackConstants.PaystackHttpClientName);
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }


    /// <param name="requestModel">Paystack transaction initialize request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Initialize Transaction
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public virtual async Task<TransactionInitializeResponse?> InitializeAsync(TransactionInitializeModel requestModel,
        CancellationToken cancellationToken)
    {
        try
        {
            // Convert amount to integer type based on the recommendation from Paystack
            requestModel.Amount = Convert.ToInt32(requestModel.Amount * 100);

            var response = await _httpClient.PostAsJsonAsync(PaystackConstants.TransactionInitialize, requestModel,
                cancellationToken);
            var content = JsonConvert.DeserializeObject<TransactionInitializeResponse>(await response.Content.ReadAsStringAsync(cancellationToken));

            _logger.LogInformation("Paystack initialization successful with Reference: {PaystackReference}", content!.Data!.Reference);
            return content;
        }
        catch (Exception exception)
        {
            _logger.LogCritical(exception, "Paystack transaction initialization failed.");
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="reference">The transaction reference to verify</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Verify Transaction
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<TransactionVerifyResponse> VerifyAsync(string reference, CancellationToken cancellationToken)
    {
        try
        {
            _httpClient.BaseAddress = new Uri("https://api.paystack.co/");
            var response = await _httpClient.GetAsync($"transaction/verify/{reference}");
            //var response = await _httpClient.GetAsync($"{PaystackConstants.TransactionVerify}/{reference}", cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                return new TransactionVerifyResponse
                {
                    Status = false,
                    Message = response.ReasonPhrase!
                };
            }

            var content = JsonConvert.DeserializeObject<TransactionVerifyResponse>(await response.Content.ReadAsStringAsync(cancellationToken));

            _logger.LogInformation("Paystack verification successful with Id: {PaystackReference}", content?.Data!.Id);
            return content!;
        }
        catch (Exception exception)
        {
            _logger.LogCritical(exception, "Paystack transaction verification failed.");
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="pagingParams"><see cref="PagingParams"/> to paginate the transactions</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// List Transactions
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<TransactionListResponse> ListAsync(PagingParams pagingParams,
        CancellationToken cancellationToken)
    {
        try
        {
            var queryString = new Dictionary<string, string?>();
            if (pagingParams.PerPage != null)
            {
                queryString.Add("perPage", pagingParams.PerPage.ToString());
            }
            if (pagingParams.Page != null)
            {
                queryString.Add("page", pagingParams.Page.ToString());
            }
            if (pagingParams.From != null)
            {
                queryString.Add("from", pagingParams.From.Value.ToString("yyyy-MM-dd"));
            }
            if (pagingParams.To != null)
            {
                queryString.Add("to", pagingParams.To.Value.ToString("yyyy-MM-dd"));
            }

            var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(PaystackConstants.Transaction!, queryString!), cancellationToken);
            var content = JsonConvert.DeserializeObject<TransactionListResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

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
    public async Task<TransactionListResponse> ListAsync(int? perPage, int? page, DateTime? from, DateTime? to,
        CancellationToken cancellationToken)
    {
        try
        {
            var queryString = QueryString(perPage, page, from, to);

            var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(PaystackConstants.Transaction!, queryString!), cancellationToken);
            var content = JsonConvert.DeserializeObject<TransactionListResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Transaction
    /// </summary>
    /// <param name="id">The ID of the transaction to fetch</param>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<TransactionResponse> FetchAsync(string id, CancellationToken cancellationToken)
    {
        try
        {
            var response = await _httpClient.GetAsync($"{PaystackConstants.Transaction}/{id}", cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                return new TransactionResponse
                {
                    Status = false,
                    Message = response.ReasonPhrase!
                };
            }

            var content = JsonConvert.DeserializeObject<TransactionResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="idReference"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Fetch Transaction Timeline
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<TransactionLogResponse> TimelineAsync(string idReference, CancellationToken cancellationToken)
    {
        try
        {
            var response = await _httpClient.GetAsync($"{PaystackConstants.TransactionTimeline}/{idReference}", cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                return new TransactionLogResponse
                {
                    Status = false,
                    Message = response.ReasonPhrase!
                };
            }

            var content = JsonConvert.DeserializeObject<TransactionLogResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="pagingParams"><see cref="PagingParams"/> to paginate the transactions</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Transaction Totals
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<TransactionTotalsResponse> TotalsAsync(PagingParams? pagingParams,
        CancellationToken cancellationToken)
    {
        try
        {
            var queryString = QueryString(pagingParams!);

            var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(PaystackConstants.TransactionTotals!, queryString!), cancellationToken);
            var content = JsonConvert.DeserializeObject<TransactionTotalsResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    public async Task<TransactionTotalsResponse> TotalsAsync(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken)
    {
        try
        {
            var queryString = QueryString(perPage, page, from, to);

            var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(PaystackConstants.TransactionTotals!, queryString!), cancellationToken);
            var content = JsonConvert.DeserializeObject<TransactionTotalsResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="pagingParams"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Export Transactions
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<TransactionDownloadResponse> ExportAsync(PagingParams pagingParams, CancellationToken cancellationToken)
    {
        try
        {
            var queryString = QueryString(pagingParams);

            var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(PaystackConstants.TransactionExport!, queryString!), cancellationToken);
            var content = JsonConvert.DeserializeObject<TransactionDownloadResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (ApiException exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    public async Task<TransactionDownloadResponse> ExportAsync(int? perPage, int? page, DateTime? @from, DateTime? to, CancellationToken cancellationToken)
    {
        try
        {
            var queryString = QueryString(perPage, page, from, to);

            var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(PaystackConstants.TransactionExport!, queryString!), cancellationToken);
            var content = JsonConvert.DeserializeObject<TransactionDownloadResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (ApiException exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="requestModel"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Charge Authorization
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<TransactionAuthorizationResponse?> ChargeAuthorizationAsync(TransactionChargeAuthorization requestModel, CancellationToken cancellationToken)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync(PaystackConstants.TransactionChargeAuthorization, requestModel,
                cancellationToken);
            return JsonConvert.DeserializeObject<TransactionAuthorizationResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="requestModel"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Check Authorization
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<TransactionAuthorizationResponse?> CheckAuthorizationAsync(TransactionCheckAuthorization requestModel, CancellationToken cancellationToken)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync(PaystackConstants.TransactionCheckAuthorization, requestModel,
                cancellationToken);
            return JsonConvert.DeserializeObject<TransactionAuthorizationResponse>(await response.Content.ReadAsStringAsync(cancellationToken));
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="requestModel"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Partial Debit
    /// </summary>
    /// <returns>Resource created</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<Response?> PartialDebitAsync(TransactionPartialDebit requestModel, CancellationToken cancellationToken)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync(PaystackConstants.TransactionPartialDebit, requestModel,
                cancellationToken);
            return JsonConvert.DeserializeObject<Response>(await response.Content.ReadAsStringAsync(cancellationToken));
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="id"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get Transaction Session
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<Response> EventAsync(string id, CancellationToken cancellationToken)
    {
        try
        {
            var response = await _httpClient.GetAsync($"{PaystackConstants.TransactionEvent}/{id}/event", cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                return new Response()
                {
                    Status = false,
                    Message = response.ReasonPhrase!
                };
            }

            var content = JsonConvert.DeserializeObject<Response>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    /// <param name="id"></param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <summary>
    /// Get Transaction Session
    /// </summary>
    /// <returns>Successful operation</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    public async Task<Response> SessionAsync(string id, CancellationToken cancellationToken)
    {
        try
        {
            var response = await _httpClient.GetAsync($"{PaystackConstants.TransactionSession}/{id}/session", cancellationToken);
            if (!response.IsSuccessStatusCode)
            {
                return new Response()
                {
                    Status = false,
                    Message = response.ReasonPhrase!
                };
            }

            var content = JsonConvert.DeserializeObject<Response>(await response.Content.ReadAsStringAsync(cancellationToken));
            return content!;
        }
        catch (Exception exception)
        {
            throw new ApiException(exception.Message, 422);
        }
    }

    private static Dictionary<string, string?> QueryString(PagingParams pagingParams)
    {
        var queryString = new Dictionary<string, string?>();
        if (pagingParams.PerPage != null)
        {
            queryString.Add("perPage", pagingParams.PerPage.ToString());
        }

        if (pagingParams.Page != null)
        {
            queryString.Add("page", pagingParams.Page.ToString());
        }

        if (pagingParams.From != null)
        {
            queryString.Add("from", pagingParams.From.Value.ToString("yyyy-MM-dd"));
        }

        if (pagingParams.To != null)
        {
            queryString.Add("to", pagingParams.To.Value.ToString("yyyy-MM-dd"));
        }

        return queryString;
    }

    private static Dictionary<string, string?> QueryString(int? perPage, int? page, DateTime? from, DateTime? to)
    {
        var queryString = new Dictionary<string, string?>();
        if (perPage != null)
        {
            queryString.Add("perPage", perPage.ToString());
        }

        if (page != null)
        {
            queryString.Add("page", page.ToString());
        }

        if (from != null)
        {
            queryString.Add("from", from.Value.ToString("yyyy-MM-dd"));
        }

        if (to != null)
        {
            queryString.Add("to", to.Value.ToString("yyyy-MM-dd"));
        }

        return queryString;
    }
}