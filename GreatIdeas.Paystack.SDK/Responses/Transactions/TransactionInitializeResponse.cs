using Newtonsoft.Json;

namespace GreatIdeas.Paystack.SDK.Responses.Transactions;

public class TransactionInitializeResponse
{
    [JsonProperty("status", Required = Required.DisallowNull)]
    public bool Status { get; set; }

    [JsonProperty("message", Required = Required.DisallowNull)]
    public string? Message { get; set; }
    
    [JsonProperty("data")]
    public TransactionInitializeData? Data { get; set; }
}

public class TransactionInitializeData
{
    [JsonProperty("authorization_url")]
    public string? AuthorizationUrl { get; set; }

    [JsonProperty("access_code")]
    public string? AccessCode { get; set; }

    [JsonProperty("reference")]
    public string? Reference { get; set; }
}
