namespace GreatIdeas.Paystack.SDK.Models.Splits;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class SplitSubaccounts
{
    /// <summary>
    /// Subaccount code of the customer or partner
    /// </summary>
    [Newtonsoft.Json.JsonProperty("subaccount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Subaccount { get; set; }

    /// <summary>
    /// The percentage or flat quota of the customer or partner
    /// </summary>
    [Newtonsoft.Json.JsonProperty("share", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Share { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}