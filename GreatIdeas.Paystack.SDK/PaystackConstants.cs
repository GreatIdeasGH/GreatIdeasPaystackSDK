namespace GreatIdeas.Paystack.SDK;

public class PaystackConstants
{
    public const string PaystackBaseEndPoint = "https://api.paystack.co/";
    public const string PaystackHttpClientName = "PaystackAPI";
    public const string ContentTypeHeaderJson = "application/json";
    public const string AuthorizationHeaderType = "Bearer";

    public const string TransactionInitialize = "transaction/initialize";
    public const string TransactionVerify = "transaction/verify";
    public const string Transaction = "transaction";
    public const string TransactionTimeline = "transaction/timeline";
    public const string TransactionExport = "transaction/export";
    public const string TransactionTotals = "transaction/totals";
    public const string TransactionChargeAuthorization = "transaction/charge_authorization";
    public const string TransactionCheckAuthorization = "transaction/check_authorization";
    public const string TransactionPartialDebit = "transaction/partial_debit";
    public const string TransactionEvent = "transaction/event";
    public const string TransactionSession = "transaction/session";
}