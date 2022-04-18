using Newtonsoft.Json;

namespace GreatIdeas.Paystack.SDK.Responses.Transactions;

public class TransactionTotalsResponse
{
    [JsonProperty("status")] public bool Status { get; set; }
    [JsonProperty("message")] public string? Message { get; set; }

    [JsonProperty("data")] public TransactionTotalsData? Data { get; set; }
}

public class TransactionTotalsData
{
    [JsonProperty("total_transactions")] public int TotalTransactions { get; set; }
    [JsonProperty("total_volume")] public int TotalVolume { get; set; }
    
    [JsonProperty("total_volume_by_currency")]
    public List<CurrencyAmount>? TotalVolumeByCurrency { get; set; }
    
    [JsonProperty("pending_transfers")] 
    public int PendingTransfers { get; set; }
    
    [JsonProperty("pending_transfers_by_currency")]
    public List<CurrencyAmount>? PendingTransfersByCurrency { get; set; }
    
}

public class CurrencyAmount
{
    [JsonProperty("currency")] 
    public string? Currency { get; set; }
    
    [JsonProperty("amount")] 
    public int Amount { get; set; }
}