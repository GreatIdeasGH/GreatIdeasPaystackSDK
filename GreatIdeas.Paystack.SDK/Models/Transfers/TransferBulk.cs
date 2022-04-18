namespace GreatIdeas.Paystack.SDK.Models.Transfers;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TransferBulk
{
    /// <summary>
    /// Where should we transfer from? Only balance is allowed for now
    /// </summary>
    [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Source { get; set; }

    /// <summary>
    /// A list of transfer object. Each object should contain amount, recipient, and reference
    /// </summary>
    [Newtonsoft.Json.JsonProperty("transfers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public ICollection<TransferInitiate> Transfers { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}