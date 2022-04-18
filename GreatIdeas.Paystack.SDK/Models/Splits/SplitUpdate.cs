namespace GreatIdeas.Paystack.SDK.Models.Splits;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class SplitUpdate
{
    /// <summary>
    /// Name of the transaction split
    /// </summary>
    [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Toggle status of split. When true, the split is active, else it's inactive
    /// </summary>
    [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Active { get; set; }

    /// <summary>
    /// This allows you specify how the transaction charge should be processed
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bearer_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Bearer_type { get; set; }

    /// <summary>
    /// This is the subaccount code of the customer or partner that would bear the transaction charge if you specified subaccount as the bearer type
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bearer_subaccount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Bearer_subaccount { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}