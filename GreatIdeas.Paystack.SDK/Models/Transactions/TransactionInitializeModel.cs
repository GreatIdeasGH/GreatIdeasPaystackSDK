namespace GreatIdeas.Paystack.SDK.Models.Transactions;

public class TransactionInitializeModel
{
    /// <summary>
    /// Customer First Name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("firstname", Required = Newtonsoft.Json.Required.Always)]
    public string? FirstName { get; set; }

    /// <summary>
    /// Customer Last Name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("lastname", Required = Newtonsoft.Json.Required.Always)]
    public string? LastName { get; set; }

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
    public decimal Amount { get; set; }

    /// <summary>
    /// The transaction currency
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Currency { get; set; }

    /// <summary>
    /// Unique transaction reference. Only -, ., = and alphanumeric characters allowed.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Reference { get; set; }

    /// <summary>
    /// Fully qualified url, e.g. https://example.com/ . Use this to override the callback url provided on the dashboard for this transaction
    /// </summary>
    [Newtonsoft.Json.JsonProperty("callback_url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? CallbackUrl { get; set; }

    /// <summary>
    /// If transaction is to create a subscription to a predefined plan, provide plan code here. 
    /// <br/>This would invalidate the value provided in amount
    /// </summary>
    [Newtonsoft.Json.JsonProperty("plan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Plan { get; set; }

    /// <summary>
    /// Number of times to charge customer during subscription to plan
    /// </summary>
    [Newtonsoft.Json.JsonProperty("invoice_limit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Invoice_limit { get; set; }

    /// <summary>
    /// Stringified JSON object of custom data
    /// </summary>
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Metadata { get; set; }

    /// <summary>
    /// An array of payment channels to control what channels you want to make available to the user to make a payment with
    /// </summary>
    [Newtonsoft.Json.JsonProperty("channels", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public ICollection<string>? Channels { get; set; }

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
    /// A flat fee to charge the sub account for a transaction. 
    /// <br/>This overrides the split percentage set when the sub account was created
    /// </summary>
    [Newtonsoft.Json.JsonProperty("transaction_charge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? TransactionCharge { get; set; }

    /// <summary>
    /// The bearer of the transaction charge
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bearer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Bearer { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}