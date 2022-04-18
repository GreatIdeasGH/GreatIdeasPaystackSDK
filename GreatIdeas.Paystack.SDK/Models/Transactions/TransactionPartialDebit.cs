namespace GreatIdeas.Paystack.SDK.Models.Transactions;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TransactionPartialDebit
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
    public string? AuthorizationCode { get; set; }

    /// <summary>
    /// The transaction currency
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string? Currency { get; set; }

    /// <summary>
    /// Unique transaction reference. Only -, ., = and alphanumeric characters allowed.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? Reference { get; set; }

    /// <summary>
    /// Minimum amount to charge
    /// </summary>
    [Newtonsoft.Json.JsonProperty("at_least", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string? AtLeast { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}