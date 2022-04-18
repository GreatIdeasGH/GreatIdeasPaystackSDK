using Newtonsoft.Json;

namespace GreatIdeas.Paystack.SDK.Responses.Transactions;

public class TransactionAuthorizationResponse
{
    [JsonProperty("status")] public bool Status { get; set; }
    [JsonProperty("message")] public string? Message { get; set; }
    [JsonProperty("data")] public TransactionChargeData? Data { get; set; }
}

public class TransactionChargeData
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

    [JsonProperty("plan")] public Dictionary<string, string>? Plan { get; set; }

    [JsonProperty("customer")] public CustomerData? Customer { get; set; }

    [JsonProperty("authorization")] public TransactionAuthorizationData? Authorization { get; set; }

    [JsonProperty("log")] public TransactionLogData? Log { get; set; }
}