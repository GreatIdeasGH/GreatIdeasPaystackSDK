namespace GreatIdeas.Paystack.SDK.Models.Transactions;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TransactionChargeAuthorization
{
    /// <summary>
    /// Customer's email address
    /// </summary>
    [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? Email { get; set; }

    /// <summary>
    /// Amount should be in kobo if currency is NGN, pesewas, if currency is GHS, and cents, if currency is ZAR
    /// </summary>
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
    public int Amount { get; set; }

    /// <summary>
    /// Valid authorization code to charge
    /// </summary>
    [Newtonsoft.Json.JsonProperty("authorization_code", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? Authorization_code { get; set; }

    /// <summary>
    /// Unique transaction reference. Only -, ., = and alphanumeric characters allowed.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Reference { get; set; }

    /// <summary>
    /// The transaction currency
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Currency { get; set; }

    /// <summary>
    /// Stringified JSON object of custom data
    /// </summary>
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Metadata { get; set; }

    /// <summary>
    /// The split code of the transaction split
    /// </summary>
    [Newtonsoft.Json.JsonProperty("split_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? SplitCode { get; set; }

    /// <summary>
    /// The code for the subaccount that owns the payment
    /// </summary>
    [Newtonsoft.Json.JsonProperty("subaccount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? SubAccount { get; set; }

    /// <summary>
    /// A flat fee to charge the subaccount for a transaction. 
    /// <br/>This overrides the split percentage set when the subaccount was created
    /// </summary>
    [Newtonsoft.Json.JsonProperty("transaction_charge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? TransactionCharge { get; set; }

    /// <summary>
    /// The beare of the transaction charge
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bearer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Bearer { get; set; }

    /// <summary>
    /// If you are making a scheduled charge call, it is a good idea to queue them so the processing system does not get overloaded causing transaction processing errors.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("queue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Queue { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}