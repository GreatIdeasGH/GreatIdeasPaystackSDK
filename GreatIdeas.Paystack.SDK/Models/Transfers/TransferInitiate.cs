namespace GreatIdeas.Paystack.SDK.Models.Transfers;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TransferInitiate
{
    /// <summary>
    /// Where should we transfer from? Only balance is allowed for now
    /// </summary>
    [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Source { get; set; }

    /// <summary>
    /// Amount to transfer in kobo if currency is NGN and pesewas if currency is GHS.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Amount { get; set; }

    /// <summary>
    /// The transfer recipient's code
    /// </summary>
    [Newtonsoft.Json.JsonProperty("recipient", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Recipient { get; set; }

    /// <summary>
    /// The reason or narration for the transfer.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Reason { get; set; }

    /// <summary>
    /// Specify the currency of the transfer. Defaults to NGN.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Currency { get; set; }

    /// <summary>
    /// If specified, the field should be a unique identifier (in lowercase) for the object. 
    /// <br/>Only -,_ and alphanumeric characters are allowed.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Reference { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}