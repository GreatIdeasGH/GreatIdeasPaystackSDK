using Newtonsoft.Json;

namespace GreatIdeas.Paystack.SDK.Responses.Transactions;

public class TransactionListResponse
{
    [JsonProperty("status", Required = Required.DisallowNull)]
    public bool Status { get; set; }

    [JsonProperty("message", Required = Required.DisallowNull)]
    public string? Message { get; set; }
    
    [JsonProperty("data")]
    public List<TransactionData>? Data { get; set; }
}