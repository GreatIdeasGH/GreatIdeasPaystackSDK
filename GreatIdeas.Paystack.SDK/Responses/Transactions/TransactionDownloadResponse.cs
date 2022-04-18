using Newtonsoft.Json;

namespace GreatIdeas.Paystack.SDK.Responses.Transactions;

public class TransactionDownloadResponse
{
    [JsonProperty("status")] public bool Status { get; set; }
    [JsonProperty("message")] public string? Message { get; set; }

    [JsonProperty("data")] public TransactionDownloadData? Data { get; set; }
}

public class TransactionDownloadData
{
    [JsonProperty("path")] public string? Path { get; set; }
    [JsonProperty("expiresAt")] public string? ExpiresAt { get; set; }
}