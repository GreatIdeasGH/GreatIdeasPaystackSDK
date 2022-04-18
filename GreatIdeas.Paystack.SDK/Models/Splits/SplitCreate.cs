namespace GreatIdeas.Paystack.SDK.Models.Splits;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class SplitCreate
{
    /// <summary>
    /// Name of the transaction split
    /// </summary>
    [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Name { get; set; }

    /// <summary>
    /// The type of transaction split you want to create.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Type { get; set; }

    /// <summary>
    /// A list of object containing subaccount code and number of shares
    /// </summary>
    [Newtonsoft.Json.JsonProperty("subaccounts", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required]
    public ICollection<SplitSubaccounts> Subaccounts { get; set; } = new System.Collections.ObjectModel.Collection<SplitSubaccounts>();

    /// <summary>
    /// The transaction currency
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Currency { get; set; }

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