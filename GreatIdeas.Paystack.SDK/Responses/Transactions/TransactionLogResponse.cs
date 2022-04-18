using Newtonsoft.Json;

namespace GreatIdeas.Paystack.SDK.Responses.Transactions;

public class TransactionLogResponse
{
    [JsonProperty("status")] public bool Status { get; set; }
    [JsonProperty("message")] public string? Message { get; set; }
    [JsonProperty("data")] public TransactionLogData? Data { get; set; }
}