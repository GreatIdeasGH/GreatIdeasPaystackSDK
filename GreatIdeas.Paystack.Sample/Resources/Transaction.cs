using GreatIdeas.Paystack.SDK.Contracts;
using GreatIdeas.Paystack.SDK.Models.Transactions;
using GreatIdeas.Paystack.SDK.Resources.Transactions;
using GreatIdeas.Paystack.SDK.Responses.Transactions;

namespace GreatIdeas.Paystack.Sample.Resources;

public class Transaction
{
    private readonly IPaystackTransaction _paystackTransaction;

    public Transaction(IPaystackTransaction paystackTransaction)
    {
        _paystackTransaction = paystackTransaction;
    }

    public async Task<TransactionInitializeResponse> AcceptPayment(TransactionInitializeModel model,
        CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.InitializeAsync(model, cancellationToken);
        return response!;
    }

    public async Task<TransactionVerifyResponse> VerifyPayment(string reference, CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.VerifyAsync(reference, cancellationToken);
        return response;
    }

    public async Task<TransactionListResponse> List(PagingParams pagingParams, CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.ListAsync(pagingParams, cancellationToken);
        return response;
    }
    
    public async Task<TransactionListResponse> List(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.ListAsync(perPage, page, from, to, cancellationToken);
        return response;
    }

    public async Task<TransactionResponse> Fetch(string id, CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.FetchAsync(id, cancellationToken);
        return response;
    }

    public async Task<TransactionTotalsResponse> Totals(PagingParams? pagingParams, CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.TotalsAsync(pagingParams, cancellationToken);
        return response;
    }
    
    public async Task<TransactionTotalsResponse> Totals(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.TotalsAsync(perPage, page, from, to, cancellationToken);
        return response;
    }

    public async Task<TransactionLogResponse> Timeline(string idReference, CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.TimelineAsync(idReference, cancellationToken);
        return response;
    }

    public async Task<TransactionDownloadResponse> Export(PagingParams pagingParams,
        CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.ExportAsync(pagingParams, cancellationToken);
        return response;
    }
    
    public async Task<TransactionDownloadResponse> Export(int? perPage, int? page, DateTime? from, DateTime? to, CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.ExportAsync(perPage, page, from, to, cancellationToken);
        return response;
    }

    public async Task<TransactionAuthorizationResponse> ChargeAuthorization(TransactionChargeAuthorization model,
        CancellationToken cancellationToken)
    {
        var response = await _paystackTransaction.ChargeAuthorizationAsync(model, cancellationToken);
        return response;
    }
}