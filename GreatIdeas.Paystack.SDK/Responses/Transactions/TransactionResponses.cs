using Newtonsoft.Json;

namespace GreatIdeas.Paystack.SDK.Responses.Transactions;

public class TransactionResponse
{
    [JsonProperty("status")] public bool Status { get; set; }
    [JsonProperty("message")] public string? Message { get; set; }

    [JsonProperty("data")] public TransactionData? Data { get; set; }
}


public class TransactionData
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("domain")] public string? Domain { get; set; }

    [JsonProperty("status")] public string? Status { get; set; }

    [JsonProperty("reference")] public string? Reference { get; set; }

    [JsonProperty("amount")] public int Amount { get; set; }

    [JsonProperty("currency")] public string? Currency { get; set; }

    [JsonProperty("transaction_date")] public DateTime TransactionDate { get; set; }

    [JsonProperty("metadata")] public Dictionary<string, string>? Metadata { get; set; }

    [JsonProperty("gateway_response")] public string? GatewayResponse { get; set; }

    [JsonProperty("channel")] public string? Channel { get; set; }

    [JsonProperty("ip_address")] public string? IpAddress { get; set; }

    [JsonProperty("message")] public string? Message { get; set; }

    [JsonProperty("fees")] public int? Fees { get; set; }

    [JsonProperty("fees_split")] public string? FeesSplit { get; set; }

    [JsonProperty("plan")] public Dictionary<string, string>? Plan { get; set; }

    [JsonProperty("split")] public Dictionary<string, string>? Split { get; set; }

    [JsonProperty("subaccount")] public Dictionary<string, string>? SubAccount { get; set; }

    [JsonProperty("order_id")] public string? OrderId { get; set; }

    [JsonProperty("paidAt")] public string? PaidAt { get; set; }

    [JsonProperty("createdAt")] public string? CreatedAt { get; set; }

    [JsonProperty("requested_amount")] public int RequestedAmount { get; set; }

    [JsonProperty("pos_transaction_data")] public string? PosTransactionData { get; set; }

    [JsonProperty("source")] public TransactionSourceData? Source { get; set; }

    [JsonProperty("fees_breakdown")] public List<FeesBreakdownData>? FeesBreakdown { get; set; }

    [JsonProperty("customer")] public CustomerData? Customer { get; set; }

    [JsonProperty("authorization")] public TransactionAuthorizationData? Authorization { get; set; }

    [JsonProperty("log")] public TransactionLogData? Log { get; set; }
}

public class FeesBreakdownData
{
    [JsonProperty("amount")] int Amount { get; set; }
    [JsonProperty("formula")] object? Formula { get; set; }
    [JsonProperty("type")] string? Type { get; set; }
}

public class TransactionSourceData
{
    [JsonProperty("source")] public string? Source { get; set; }

    [JsonProperty("type")] public string? Type { get; set; }

    [JsonProperty("identifier")] public string? Identifier { get; set; }

    [JsonProperty("entry_point")] public string? EntryPoint { get; set; }
}

public class TransactionLogData
{
    [JsonProperty("start_time")] public int StartTime { get; set; }

    [JsonProperty("time_spent")] public int TimeSpent { get; set; }

    [JsonProperty("attempts")] public int Attempts { get; set; }

    [JsonProperty("success")] public bool Success { get; set; }

    [JsonProperty("mobile")] public bool Mobile { get; set; }

    [JsonProperty("input")] public List<string>? Input { get; set; }

    [JsonProperty("history")] public List<TransactionHistoryData>? History { get; set; }
}

public class TransactionHistoryData
{
    [JsonProperty("type")] public string? Type { get; set; }

    [JsonProperty("time")] public int Time { get; set; }

    [JsonProperty("message")] public string? Message { get; set; }
}

public class TransactionAuthorizationData
{
    [JsonProperty("authorization_code")] public string? AuthorizationCode { get; set; }

    [JsonProperty("bin")] public string? Bin { get; set; }

    [JsonProperty("last4")] public string? Last4 { get; set; }

    [JsonProperty("exp_month")] public string? ExpMonth { get; set; }

    [JsonProperty("exp_year")] public string? ExpYear { get; set; }

    [JsonProperty("channel")] public string? Channel { get; set; }

    [JsonProperty("card_type")] public string? CardType { get; set; }

    [JsonProperty("bank")] public string? Bank { get; set; }

    [JsonProperty("country_code")] public string? CountryCode { get; set; }

    [JsonProperty("brand")] public string? Brand { get; set; }

    [JsonProperty("signature")] public string? Signature { get; set; }

    [JsonProperty("account_name")] public string? AccountName { get; set; }

    [JsonProperty("reusable")] public bool Reusable { get; set; }
}

public class CustomerData
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("customer_code")] public string? CustomerCode { get; set; }

    [JsonProperty("first_name")] public string? FirstName { get; set; }

    [JsonProperty("last_name")] public string? LastName { get; set; }

    [JsonProperty("email")] public string? Email { get; set; }

    [JsonProperty("phone")] public string? Phone { get; set; }

    [JsonProperty("metadata")] public Dictionary<string, string>? Metadata { get; set; }

    [JsonProperty("risk_action")] public string? RiskAction { get; set; }

    [JsonProperty("international_format_phone")]
    public string? InternationalFormatPhone { get; set; }
}